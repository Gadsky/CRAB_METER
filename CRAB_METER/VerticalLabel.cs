using System.Drawing;

namespace ELO {
    class VerticalLabel : System.Windows.Forms.Label {
        public int RotateAngle { get; set; } 
        public string NewText { get; set; }  

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(this.RotateAngle);
            Brush b = new SolidBrush(base.ForeColor);
            e.Graphics.DrawString(this.NewText, this.Font, b, -this.Height / 2, -this.Width / 2);
        }
    }
}