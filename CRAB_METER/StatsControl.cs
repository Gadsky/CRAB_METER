﻿
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

        private void timer_Tick(object sender, System.EventArgs e) {
            if (character == null) return;

            this.vetricalLabel1.NewText = character.Name;
            horizontalL.Text = character.Name;

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

            bountyPSTB.Text = statsBounty.Avg.ToString("N1");
            bountyTotalTB.Text = statsBounty.Total.ToString("N0");
            bountyTimeTB.Text = Seconds2String((int)statsBounty.IntervalLength);

            vetricalLabel1.Refresh();
        }

        string Seconds2String(int seconds) {
            int s = seconds % 60;
            int m = (seconds / 60) % 60;
            int h = (seconds / 60) / 60;

            return
                (h == 0 ? "" : h.ToString() + ":") +
                (h == 0 && m == 0 ? "" : (h == 0 ? m.ToString() : m.ToString("D2")) + ":") +
                (m == 0 && h == 0 ? s.ToString() : s.ToString("D2"));
        }

        private void StatsControl_Load(object sender, System.EventArgs e) {

        }

        private void vetricalLabel1_Click(object sender, System.EventArgs e) {
            for (var i = 0; i < this.Controls.Count; i++) {
                Controls[i].Visible = !Controls[i].Visible;
            }
        }

        private void label1_Click(object sender, System.EventArgs e) {
            character.SimulateUndocking();
        }
    }
}
