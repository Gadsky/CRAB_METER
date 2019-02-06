
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ELO {
    public partial class StatsControl : UserControl {
        private EVECharacter character;

        const string _10_sec = "10 sec";
        const string _60_sec = "60 sec";
        const string _3600_sec = "1 hr";
        const string _sinceUndocked = "Undock";
        const string _sinceUndockedJumped = "Undock/Jump";
        const string _activeSinceUndock = "Action";
        const string _start = "Whole";

        public StatsControl() {
            InitializeComponent();
        }

        public StatsControl(EVECharacter _character) {
            InitializeComponent();
            character = _character;

            styleCBFrom.Items.Clear();
            styleCBFrom.Items.Add(_10_sec);
            styleCBFrom.Items.Add(_60_sec);
            styleCBFrom.Items.Add(_3600_sec);
            styleCBFrom.Items.Add(_sinceUndocked);
            styleCBFrom.Items.Add(_sinceUndockedJumped);
            styleCBFrom.Items.Add(_activeSinceUndock);
            styleCBFrom.Items.Add(_start);
            styleCBFrom.SelectedIndex = 1;

            styleCBTo.Items.Clear();
            styleCBTo.Items.Add(_10_sec);
            styleCBTo.Items.Add(_60_sec);
            styleCBTo.Items.Add(_3600_sec);
            styleCBTo.Items.Add(_sinceUndocked);
            styleCBTo.Items.Add(_sinceUndockedJumped);
            styleCBTo.Items.Add(_activeSinceUndock);
            styleCBTo.Items.Add(_start);
            styleCBTo.SelectedIndex = 5;

            styleCBBounty.Items.Clear();
            styleCBBounty.Items.Add(_10_sec);
            styleCBBounty.Items.Add(_60_sec);
            styleCBBounty.Items.Add(_3600_sec);
            styleCBBounty.Items.Add(_sinceUndocked);
            styleCBBounty.Items.Add(_sinceUndockedJumped);
            styleCBBounty.Items.Add(_activeSinceUndock);
            styleCBBounty.Items.Add(_start);
            styleCBBounty.SelectedIndex = 6;
        }

        private void OnTimerTick(object sender, System.EventArgs e) {
            if (character == null) return;

            verticalTagL.NewText = character.Name;
            horizontalTagL.Text = character.Name;

            EVECharacter.IntervalType type = EVECharacter.IntervalType._10sec;
            if (styleCBFrom.SelectedItem.ToString().Equals(_10_sec)) type = EVECharacter.IntervalType._10sec;
            if (styleCBFrom.SelectedItem.ToString().Equals(_60_sec)) type = EVECharacter.IntervalType._60sec;
            if (styleCBFrom.SelectedItem.ToString().Equals(_3600_sec)) type = EVECharacter.IntervalType._3600sec;
            if (styleCBFrom.SelectedItem.ToString().Equals(_sinceUndocked)) type = EVECharacter.IntervalType._sinceUndock;
            if (styleCBFrom.SelectedItem.ToString().Equals(_sinceUndockedJumped)) type = EVECharacter.IntervalType._sinceUndockJump;
            if (styleCBFrom.SelectedItem.ToString().Equals(_activeSinceUndock)) type = EVECharacter.IntervalType._activeSinceUndock;
            if (styleCBFrom.SelectedItem.ToString().Equals(_start)) type = EVECharacter.IntervalType._start;
            var statsFrom = character.CalcStatsHitFrom(type);

            if (styleCBTo.SelectedItem.ToString().Equals(_10_sec)) type = EVECharacter.IntervalType._10sec;
            if (styleCBTo.SelectedItem.ToString().Equals(_60_sec)) type = EVECharacter.IntervalType._60sec;
            if (styleCBTo.SelectedItem.ToString().Equals(_3600_sec)) type = EVECharacter.IntervalType._3600sec;
            if (styleCBTo.SelectedItem.ToString().Equals(_sinceUndocked)) type = EVECharacter.IntervalType._sinceUndock;
            if (styleCBTo.SelectedItem.ToString().Equals(_sinceUndockedJumped)) type = EVECharacter.IntervalType._sinceUndockJump;
            if (styleCBTo.SelectedItem.ToString().Equals(_activeSinceUndock)) type = EVECharacter.IntervalType._activeSinceUndock;
            if (styleCBTo.SelectedItem.ToString().Equals(_start)) type = EVECharacter.IntervalType._start;
            var statsTo = character.CalcStatsHitTo(type);

            if (styleCBBounty.SelectedItem.ToString().Equals(_10_sec)) type = EVECharacter.IntervalType._10sec;
            if (styleCBBounty.SelectedItem.ToString().Equals(_60_sec)) type = EVECharacter.IntervalType._60sec;
            if (styleCBBounty.SelectedItem.ToString().Equals(_3600_sec)) type = EVECharacter.IntervalType._3600sec;
            if (styleCBBounty.SelectedItem.ToString().Equals(_sinceUndocked)) type = EVECharacter.IntervalType._sinceUndock;
            if (styleCBBounty.SelectedItem.ToString().Equals(_sinceUndockedJumped)) type = EVECharacter.IntervalType._sinceUndockJump;
            if (styleCBBounty.SelectedItem.ToString().Equals(_activeSinceUndock)) type = EVECharacter.IntervalType._activeSinceUndock;
            if (styleCBBounty.SelectedItem.ToString().Equals(_start)) type = EVECharacter.IntervalType._start;
            var statsBounty = character.CalcStatsBounty(type);

            fromDPSTB.Text = statsFrom.Avg.ToString("N0");
            fromDPS2TB.Text = statsFrom.Avg.ToString("N0");
            fromDPSTotalTB.Text = statsFrom.Total.ToString("N0");
            fromDPSTimeTB.Text = Seconds2String((int)statsFrom.IntervalLength);

            toDPSTB.Text = statsTo.Avg.ToString("N0");
            toDPSTotalTB.Text = statsTo.Total.ToString("N0");
            toDPSTimeTB.Text = Seconds2String((int)statsTo.IntervalLength);
            toDPSTime2TB.Text = Seconds2String((int)statsTo.IntervalLength);

            if (statsTo.WeaponStatistics != null) {
                var toDPSWeapon = statsTo.WeaponStatistics.Select(wse => GetToWeaponLine(wse));
                toDPSWeaponTB.Lines = toDPSWeapon.ToArray();
                toDPSWeaponTB.Visible = true;
            }
            else {
                toDPSWeaponTB.Text = "";
                toDPSWeaponTB.Visible = false;
            }

            bountyPSTB.Text = statsBounty.Avg.ToString("N1");
            bountyTotalTB.Text = statsBounty.Total.ToString("N0");
            bountyTimeTB.Text = Seconds2String((int)statsBounty.IntervalLength);

            verticalTagL.Refresh();
        }

        private static string GetToWeaponLine(EVECharacter.WeaponStatistics wse) {
            return string.Format("{0, -30}  {1, 7:N0}  {2, 5:N1}", Trim(wse.Weapon, 30), wse.Total, 100 * wse.Percentage);
        }

        private static string Trim(string value, int length) {
            return value.Length > 30 ? value.Substring(0, 30) : value;
        }


        string Seconds2String(int seconds) {
            int s = seconds % 60;
            int m = (seconds / 60) % 60;
            int h = (seconds / 60) / 60;

            return
                (h == 0 ? "" : h.ToString() + ":") +
                (h == 0 && m == 0 ? "" : (h == 0 ? m.ToString() : m.ToString("D2")) + ":") +
                (h == 0 && m == 0 ? s.ToString() : s.ToString("D2"));
        }

        private void OnTagClick(object sender, System.EventArgs e) {
            for (var i = 0; i < Controls.Count; i++) {
                Controls[i].Visible = !Controls[i].Visible;
            }
        }

        private void OnResetActionClick(object sender, System.EventArgs e) {
            character.SimulateUndocking();
        }

        private void toDPSWeaponTB_TextChanged(object sender, System.EventArgs e) {
            Size sz = new Size(toDPSWeaponTB.ClientSize.Width, int.MaxValue);
            TextFormatFlags flags = TextFormatFlags.WordBreak;
            int padding = 3;
            int borders = toDPSWeaponTB.Height - toDPSWeaponTB.ClientSize.Height;
            var text = (toDPSWeaponTB.Text == null || "".Equals(toDPSWeaponTB.Text)) ? "WWW" : toDPSWeaponTB.Text;
            sz = TextRenderer.MeasureText(text, toDPSWeaponTB.Font, sz, flags);
            int h = sz.Height + borders + padding;
            if (toDPSWeaponTB.Top + h > this.ClientSize.Height - 10) {
                h = this.ClientSize.Height - 10 - toDPSWeaponTB.Top;
            }
            toDPSWeaponTB.Height = h;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void StatsControl_Paint(object sender, PaintEventArgs e) {
        }
    }
}
