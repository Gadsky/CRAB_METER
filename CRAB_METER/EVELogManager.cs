using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class EVELogManager {
    class FileEntry {
        public string Path { get; set; }
        public string Tag { get; set; }
        public long Offset { get; set; }
    }

    private FileSystemWatcher fileSystemWatcher;
    private SortedList<string, FileEntry> files = new SortedList<string, FileEntry>();
    private SortedList<string, EVECharacter> characters = new SortedList<string, EVECharacter>();
    public SortedList<string, EVECharacter> Characters { get { return characters; } }

    private static Regex listener = new Regex("  Listener: (.*)");

    private static string GetPersonalPath() { return Environment.GetFolderPath(Environment.SpecialFolder.Personal); }
    public static string GetBasePath() { return GetPersonalPath() + "\\EVE\\logs\\Gamelogs\\"; }


    public EVELogManager() {
        fileSystemWatcher = new FileSystemWatcher();
        fileSystemWatcher.Path = GetBasePath();
        fileSystemWatcher.Changed += FSWOnChanged;
        fileSystemWatcher.EnableRaisingEvents = true;
    }

    private string PreReadFile(string path) {
        using (var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read)) {
            var lineIndex = 0;
            using (var streamReader = new StreamReader(file)) {
                string line;
                while ((line = streamReader.ReadLine()) != null) {
                    if (lineIndex > 2) return null;

                    Match listenerMatch = listener.Match(line);
                    if (listenerMatch.Success) return listenerMatch.Groups[1].Value;

                    lineIndex++;
                }
            }
        }

        return null;
    }

    private void FSWOnChanged(object sender, FileSystemEventArgs e) {
        try {
            if (!files.ContainsKey(e.FullPath)) {

                var tag = PreReadFile(e.FullPath);
                if (tag == null) return;

                var fileEntry = new FileEntry { Path = e.FullPath, Tag = tag, Offset = 0 };
                files.Add(e.FullPath, fileEntry);
            }

            var fileToRead = files[e.FullPath];
            ReadFile(fileToRead);
        }
        catch (IOException) {
            return;
        }
    }

    private void ReadFile(FileEntry fileEntry) {
        if (!characters.ContainsKey(fileEntry.Tag)) {
            var character = new EVECharacter(fileEntry.Tag);
            characters.Add(character.Name, character);
        }

        var characterToProcess = characters[fileEntry.Tag];

        using (var file = File.Open(fileEntry.Path, FileMode.Open, FileAccess.Read, FileShare.Read)) {
            file.Seek(fileEntry.Offset, SeekOrigin.Begin);

            using (var streamReader = new StreamReader(file)) {
                string line;
                while ((line = streamReader.ReadLine()) != null) characterToProcess.OnNewLine(line);
                fileEntry.Offset = file.Position;
            }
        }
    }
}


public class EVECharacter {
    private struct Undock {
        public DateTime timestamp;
    }

    private struct HitFrom {
        public DateTime timestamp;
        public int qty;
    }

    private struct HitTo {
        public DateTime timestamp;
        public int qty;
        public string weapon;
    }

    private struct Bounty {
        public DateTime timestamp;
        public int qty;
    }

    public string Name { get; private set; }
    public Control Control { get; set; }

    DateTime startTimeStamp = DateTime.MinValue;
    DateTime startNow = DateTime.MinValue;
    DateTime lastTimeStamp = DateTime.Now;
    DateTime lastNow = DateTime.Now;
    private List<Undock> actionBreaker = new List<Undock>();
    private List<Undock> undocks = new List<Undock>();
    private List<HitFrom> hitsFrom = new List<HitFrom>();
    private List<HitTo> hitsTo = new List<HitTo>();
    private List<Bounty> bounties = new List<Bounty>();

    private static Regex from = new Regex("\\[ (\\d*\\.\\d*.\\d* \\d*:\\d*:\\d*) ] \\(combat\\) <.*><b>(\\d*)</b> <.*>from<.*> <b><.*>(.*)</b><.*> - (.*)");
    private static Regex to = new Regex("\\[ (\\d*\\.\\d*.\\d* \\d*:\\d*:\\d*) ] \\(combat\\) <.*><b>(\\d*)</b> <.*>to<.*> - (.*) - (.*)");
    private static Regex undocking = new Regex("\\[ (\\d*\\.\\d*.\\d* \\d*:\\d*:\\d*) ] \\(None\\) Undocking .*");
    private static Regex jumping = new Regex("\\[ (\\d*\\.\\d*.\\d* \\d*:\\d*:\\d*) ] \\(None\\) Jumping .*");
    private static Regex bounty = new Regex("\\[ (\\d*\\.\\d*.\\d* \\d*:\\d*:\\d*) ] \\(bounty\\) (.*)>([ 0-9]+) ISK(.*)");
    private static Regex start = new Regex("  Session Started: (\\d*\\.\\d*.\\d* \\d*:\\d*:\\d*)");

    public enum IntervalType { _10sec, _60sec, _3600sec, _sinceUndock, _sinceUndockJump, _activeSinceUndock, _start }

    public struct Statistics {
        public double IntervalLength;
        public int EventCount;
        public double Total;
        public double Avg;
    }

    public EVECharacter(string name) {
        Name = name;
    }

    public static T Min<T>(T first, T second) {
        if (Comparer<T>.Default.Compare(first, second) < 0) return first;
        return second;
    }

    public static T Max<T>(T first, T second) {
        if (Comparer<T>.Default.Compare(first, second) > 0) return first;
        return second;
    }

    DateTime ParseLogTime(string asText) {
        return new DateTime(
            int.Parse(asText.Substring(0, 4)),
            int.Parse(asText.Substring(5, 2)),
            int.Parse(asText.Substring(8, 2)),
            int.Parse(asText.Substring(11, 2)),
            int.Parse(asText.Substring(14, 2)),
            int.Parse(asText.Substring(17, 2))
          );
    }

    private void FixTimes(string timestamp) {
        lastTimeStamp = ParseLogTime(timestamp);
        lastNow = DateTime.Now;
    }

    public void OnNewLine(string line) {
        Match startMatch = start.Match(line);
        if (startMatch.Success) {
            OnStarted(startMatch.Groups[1].Value);
            return;
        }

        Match fromMatch = from.Match(line);
        if (fromMatch.Success) {
            OnFrom(fromMatch.Groups[1].Value, fromMatch.Groups[2].Value, fromMatch.Groups[3].Value, fromMatch.Groups[4].Value);
            return;
        }

        Match toMatch = to.Match(line);
        if (toMatch.Success) {
            OnTo(toMatch.Groups[1].Value, toMatch.Groups[2].Value, toMatch.Groups[3].Value, toMatch.Groups[4].Value);
            return;
        }

        Match bountyMatch = bounty.Match(line);
        if (bountyMatch.Success) {
            OnBounty(bountyMatch.Groups[1].Value, bountyMatch.Groups[3].Value);
            return;
        }

        Match undockingMatch = undocking.Match(line);
        if (undockingMatch.Success) {
            OnUndocking(undockingMatch.Groups[1].Value);
            return;
        }

        Match jumpingMatch = jumping.Match(line);
        if (jumpingMatch.Success) {
            OnJumping(jumpingMatch.Groups[1].Value);
            return;
        }

    }

    private void OnBounty(string timestamp, string qty) {
        FixTimes(timestamp);
        bounties.Add(new Bounty() { timestamp = lastTimeStamp, qty = int.Parse(qty.Replace(" ", "")) });
    }

    private void OnFrom(string timestamp, string qty, string from, string kind) {
        FixTimes(timestamp);
        hitsFrom.Add(new HitFrom() { timestamp = lastTimeStamp, qty = int.Parse(qty) });
    }

    private void OnTo(string timestamp, string qty, string weapon, string kind) {
        FixTimes(timestamp);
        hitsTo.Add(new HitTo() { timestamp = lastTimeStamp, qty = int.Parse(qty), weapon = weapon });
    }

    private void OnUndocking(string timestamp) {
        FixTimes(timestamp);
        undocks.Add(new Undock() { timestamp = lastTimeStamp });
        actionBreaker.Add(new Undock() { timestamp = lastTimeStamp });
    }

    private void OnJumping(string timestamp) {
        FixTimes(timestamp);
        actionBreaker.Add(new Undock() { timestamp = lastTimeStamp });
    }

    private void OnStarted(string timestamp) {
        if (startNow != DateTime.MinValue) return;

        FixTimes(timestamp);
        startNow = lastNow;
        startTimeStamp = lastTimeStamp;
    }

    public void SimulateUndocking() {
        var now = DateTime.Now;

        long ticksOffset = lastNow.Ticks - lastTimeStamp.Ticks;
        lastTimeStamp = new DateTime(now.Ticks - ticksOffset);
        lastNow = now;

        actionBreaker.Add(new Undock() { timestamp = lastTimeStamp });
    }

    public Statistics CalcStatsHitFrom(IntervalType intervalType) {
        long ticksOffset = lastNow.Ticks - lastTimeStamp.Ticks;
        DateTime nowTimeStamp = new DateTime(DateTime.Now.Ticks - ticksOffset);

        DateTime from = nowTimeStamp;
        DateTime to = nowTimeStamp;

        if (intervalType == IntervalType._10sec) from = from.AddSeconds(-10);
        if (intervalType == IntervalType._60sec) from = from.AddSeconds(-60);
        if (intervalType == IntervalType._3600sec) from = from.AddSeconds(-3600);
        if (intervalType == IntervalType._start) from = startTimeStamp;

        if (intervalType == IntervalType._sinceUndock) {
            if (undocks.Count > 0) from = undocks[undocks.Count - 1].timestamp;
        }

        if (intervalType == IntervalType._sinceUndockJump) {
            if (actionBreaker.Count > 0) from = actionBreaker[actionBreaker.Count - 1].timestamp;
        }

        if (intervalType == IntervalType._activeSinceUndock) {
            var lastActionBreak = startTimeStamp;
            if (actionBreaker.Count > 0) lastActionBreak = actionBreaker[actionBreaker.Count - 1].timestamp;

            to = lastActionBreak;
            for (int i = hitsFrom.Count - 1; i >= 0; i--) {
                if (hitsFrom[i].timestamp < lastActionBreak) break;
                from = Min(from, hitsFrom[i].timestamp);
                to = Max(to, hitsFrom[i].timestamp);
            }
        }

        from = Max(from, startTimeStamp);
        to = Max(from, to);

        Statistics statistics = new Statistics { EventCount = 0, Total = 0 };

        for (int i = hitsFrom.Count - 1; i >= 0; i--) {
            if (hitsFrom[i].timestamp > to) continue;
            if (hitsFrom[i].timestamp < from) break;
            statistics.Total += hitsFrom[i].qty;
            statistics.EventCount++;
        }

        statistics.IntervalLength = Max(0, TimeSpan.FromTicks(to.Ticks - from.Ticks).TotalSeconds);

        if (statistics.IntervalLength > 1.0) {
            statistics.Avg = statistics.Total / statistics.IntervalLength;
        }
        else {
            statistics.Avg = 0;
        }

        return statistics;
    }

    public Statistics CalcStatsHitTo(IntervalType intervalType) {
        long ticksOffset = lastNow.Ticks - lastTimeStamp.Ticks;
        DateTime nowTimeStamp = new DateTime(DateTime.Now.Ticks - ticksOffset);

        DateTime from = nowTimeStamp;
        DateTime to = nowTimeStamp;

        if (intervalType == IntervalType._10sec) from = from.AddSeconds(-10);
        if (intervalType == IntervalType._60sec) from = from.AddSeconds(-60);
        if (intervalType == IntervalType._3600sec) from = from.AddSeconds(-3600);
        if (intervalType == IntervalType._start) from = startTimeStamp;

        if (intervalType == IntervalType._sinceUndock) {
            if (undocks.Count > 0) from = undocks[undocks.Count - 1].timestamp;
        }

        if (intervalType == IntervalType._sinceUndockJump) {
            if (actionBreaker.Count > 0) from = actionBreaker[actionBreaker.Count - 1].timestamp;
        }

        if (intervalType == IntervalType._activeSinceUndock) {
            var lastUndock = startTimeStamp;
            if (actionBreaker.Count > 0) lastUndock = actionBreaker[actionBreaker.Count - 1].timestamp;

            to = lastUndock;
            for (int i = hitsTo.Count - 1; i >= 0; i--) {
                if (hitsTo[i].timestamp < lastUndock) break;
                from = Min(from, hitsTo[i].timestamp);
                to = Max(to, hitsTo[i].timestamp);
            }
        }

        from = Max(from, startTimeStamp);
        to = Max(from, to);

        Statistics statistics = new Statistics { EventCount = 0, Total = 0 };

        for (int i = hitsTo.Count - 1; i >= 0; i--) {
            if (hitsTo[i].timestamp > to) continue;
            if (hitsTo[i].timestamp < from) break;
            statistics.Total += hitsTo[i].qty;
            statistics.EventCount++;
        }

        statistics.IntervalLength = Max(0, TimeSpan.FromTicks(to.Ticks - from.Ticks).TotalSeconds);

        if (statistics.IntervalLength > 1.0) {
            statistics.Avg = statistics.Total / statistics.IntervalLength;
        }
        else {
            statistics.Avg = 0;
        }

        return statistics;
    }

    public Statistics CalcStatsBounty(IntervalType intervalType) {
        long ticksOffset = lastNow.Ticks - lastTimeStamp.Ticks;
        DateTime nowTimeStamp = new DateTime(DateTime.Now.Ticks - ticksOffset);

        DateTime from = nowTimeStamp;
        DateTime to = nowTimeStamp;

        if (intervalType == IntervalType._10sec) from = from.AddSeconds(-10);
        if (intervalType == IntervalType._60sec) from = from.AddSeconds(-60);
        if (intervalType == IntervalType._3600sec) from = from.AddSeconds(-3600);
        if (intervalType == IntervalType._start) from = startTimeStamp;

        if (intervalType == IntervalType._sinceUndock) {
            if (undocks.Count > 0) from = undocks[undocks.Count - 1].timestamp;
        }

        if (intervalType == IntervalType._sinceUndockJump) {
            if (actionBreaker.Count > 0) from = actionBreaker[actionBreaker.Count - 1].timestamp;
        }

        if (intervalType == IntervalType._activeSinceUndock) {
            var lastActionBreak = startTimeStamp;
            if (actionBreaker.Count > 0) lastActionBreak = actionBreaker[actionBreaker.Count - 1].timestamp;

            to = lastActionBreak;
            for (int i = bounties.Count - 1; i >= 0; i--) {
                if (bounties[i].timestamp < lastActionBreak) break;
                from = Min(from, bounties[i].timestamp);
                to = Max(to, bounties[i].timestamp);
            }
        }

        from = Max(from, startTimeStamp);
        to = Max(from, to);

        Statistics statistics = new Statistics { EventCount = 0, Total = 0 };

        for (int i = bounties.Count - 1; i >= 0; i--) {
            if (bounties[i].timestamp > to) continue;
            if (bounties[i].timestamp < from) break;
            statistics.Total += bounties[i].qty;
            statistics.EventCount++;
        }

        statistics.IntervalLength = Max(0, TimeSpan.FromTicks(to.Ticks - from.Ticks).TotalSeconds);

        if (statistics.IntervalLength > 10.0) {
            statistics.Avg = (3600 * statistics.Total / statistics.IntervalLength) / 1000000;
        }
        else {
            statistics.Avg = 0;
        }

        return statistics;
    }
}
