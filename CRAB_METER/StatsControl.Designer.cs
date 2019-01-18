namespace ELO {
    partial class StatsControl {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.bountyTimeTB = new System.Windows.Forms.TextBox();
            this.bountyTotalTB = new System.Windows.Forms.TextBox();
            this.styleCBBounty = new System.Windows.Forms.ComboBox();
            this.bountyPSTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDPSTimeTB = new System.Windows.Forms.TextBox();
            this.fromDPSTotalTB = new System.Windows.Forms.TextBox();
            this.toDPSTimeTB = new System.Windows.Forms.TextBox();
            this.toDPSTotalTB = new System.Windows.Forms.TextBox();
            this.styleCBTo = new System.Windows.Forms.ComboBox();
            this.styleCBFrom = new System.Windows.Forms.ComboBox();
            this.fromDPSTB = new System.Windows.Forms.TextBox();
            this.toDPSTB = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.horizontalTagL = new System.Windows.Forms.Label();
            this.toDPSTime2TB = new System.Windows.Forms.TextBox();
            this.fromDPS2TB = new System.Windows.Forms.TextBox();
            this.verticalTagL = new ELO.VerticalLabel();
            this.SuspendLayout();
            // 
            // bountyTimeTB
            // 
            this.bountyTimeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.bountyTimeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bountyTimeTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bountyTimeTB.ForeColor = System.Drawing.Color.Gold;
            this.bountyTimeTB.Location = new System.Drawing.Point(118, 48);
            this.bountyTimeTB.Name = "bountyTimeTB";
            this.bountyTimeTB.ReadOnly = true;
            this.bountyTimeTB.Size = new System.Drawing.Size(64, 20);
            this.bountyTimeTB.TabIndex = 30;
            this.bountyTimeTB.Text = "?";
            this.bountyTimeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bountyTotalTB
            // 
            this.bountyTotalTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.bountyTotalTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bountyTotalTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bountyTotalTB.ForeColor = System.Drawing.Color.Gold;
            this.bountyTotalTB.Location = new System.Drawing.Point(17, 48);
            this.bountyTotalTB.Name = "bountyTotalTB";
            this.bountyTotalTB.ReadOnly = true;
            this.bountyTotalTB.Size = new System.Drawing.Size(99, 20);
            this.bountyTotalTB.TabIndex = 29;
            this.bountyTotalTB.Text = "?";
            this.bountyTotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // styleCBBounty
            // 
            this.styleCBBounty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.styleCBBounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleCBBounty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styleCBBounty.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.styleCBBounty.ForeColor = System.Drawing.Color.White;
            this.styleCBBounty.FormattingEnabled = true;
            this.styleCBBounty.Location = new System.Drawing.Point(232, 46);
            this.styleCBBounty.Name = "styleCBBounty";
            this.styleCBBounty.Size = new System.Drawing.Size(69, 23);
            this.styleCBBounty.TabIndex = 28;
            // 
            // bountyPSTB
            // 
            this.bountyPSTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.bountyPSTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bountyPSTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bountyPSTB.ForeColor = System.Drawing.Color.Gold;
            this.bountyPSTB.Location = new System.Drawing.Point(184, 48);
            this.bountyPSTB.Name = "bountyPSTB";
            this.bountyPSTB.ReadOnly = true;
            this.bountyPSTB.Size = new System.Drawing.Size(45, 20);
            this.bountyPSTB.TabIndex = 27;
            this.bountyPSTB.Text = "?";
            this.bountyPSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "R";
            this.label1.Click += new System.EventHandler(this.OnResetActionClick);
            // 
            // fromDPSTimeTB
            // 
            this.fromDPSTimeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.fromDPSTimeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromDPSTimeTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDPSTimeTB.ForeColor = System.Drawing.Color.Red;
            this.fromDPSTimeTB.Location = new System.Drawing.Point(118, 26);
            this.fromDPSTimeTB.Name = "fromDPSTimeTB";
            this.fromDPSTimeTB.ReadOnly = true;
            this.fromDPSTimeTB.Size = new System.Drawing.Size(64, 20);
            this.fromDPSTimeTB.TabIndex = 25;
            this.fromDPSTimeTB.Text = "?";
            this.fromDPSTimeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fromDPSTotalTB
            // 
            this.fromDPSTotalTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.fromDPSTotalTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromDPSTotalTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDPSTotalTB.ForeColor = System.Drawing.Color.Red;
            this.fromDPSTotalTB.Location = new System.Drawing.Point(17, 26);
            this.fromDPSTotalTB.Name = "fromDPSTotalTB";
            this.fromDPSTotalTB.ReadOnly = true;
            this.fromDPSTotalTB.Size = new System.Drawing.Size(99, 20);
            this.fromDPSTotalTB.TabIndex = 24;
            this.fromDPSTotalTB.Text = "?";
            this.fromDPSTotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toDPSTimeTB
            // 
            this.toDPSTimeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.toDPSTimeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toDPSTimeTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDPSTimeTB.ForeColor = System.Drawing.Color.Lime;
            this.toDPSTimeTB.Location = new System.Drawing.Point(118, 4);
            this.toDPSTimeTB.Name = "toDPSTimeTB";
            this.toDPSTimeTB.ReadOnly = true;
            this.toDPSTimeTB.Size = new System.Drawing.Size(64, 20);
            this.toDPSTimeTB.TabIndex = 23;
            this.toDPSTimeTB.Text = "?";
            this.toDPSTimeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toDPSTotalTB
            // 
            this.toDPSTotalTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.toDPSTotalTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toDPSTotalTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDPSTotalTB.ForeColor = System.Drawing.Color.Lime;
            this.toDPSTotalTB.Location = new System.Drawing.Point(17, 4);
            this.toDPSTotalTB.Name = "toDPSTotalTB";
            this.toDPSTotalTB.ReadOnly = true;
            this.toDPSTotalTB.Size = new System.Drawing.Size(99, 20);
            this.toDPSTotalTB.TabIndex = 22;
            this.toDPSTotalTB.Text = "?";
            this.toDPSTotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // styleCBTo
            // 
            this.styleCBTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.styleCBTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleCBTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styleCBTo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.styleCBTo.ForeColor = System.Drawing.Color.White;
            this.styleCBTo.FormattingEnabled = true;
            this.styleCBTo.Location = new System.Drawing.Point(232, 2);
            this.styleCBTo.Name = "styleCBTo";
            this.styleCBTo.Size = new System.Drawing.Size(69, 23);
            this.styleCBTo.TabIndex = 21;
            // 
            // styleCBFrom
            // 
            this.styleCBFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.styleCBFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleCBFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styleCBFrom.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.styleCBFrom.ForeColor = System.Drawing.Color.White;
            this.styleCBFrom.FormattingEnabled = true;
            this.styleCBFrom.Location = new System.Drawing.Point(232, 24);
            this.styleCBFrom.Name = "styleCBFrom";
            this.styleCBFrom.Size = new System.Drawing.Size(69, 23);
            this.styleCBFrom.TabIndex = 20;
            // 
            // fromDPSTB
            // 
            this.fromDPSTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.fromDPSTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromDPSTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDPSTB.ForeColor = System.Drawing.Color.Red;
            this.fromDPSTB.Location = new System.Drawing.Point(184, 26);
            this.fromDPSTB.Name = "fromDPSTB";
            this.fromDPSTB.ReadOnly = true;
            this.fromDPSTB.Size = new System.Drawing.Size(45, 20);
            this.fromDPSTB.TabIndex = 19;
            this.fromDPSTB.Text = "?";
            this.fromDPSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toDPSTB
            // 
            this.toDPSTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.toDPSTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toDPSTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDPSTB.ForeColor = System.Drawing.Color.Lime;
            this.toDPSTB.Location = new System.Drawing.Point(184, 4);
            this.toDPSTB.Name = "toDPSTB";
            this.toDPSTB.ReadOnly = true;
            this.toDPSTB.Size = new System.Drawing.Size(45, 20);
            this.toDPSTB.TabIndex = 18;
            this.toDPSTB.Text = "?";
            this.toDPSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // horizontalTagL
            // 
            this.horizontalTagL.AutoSize = true;
            this.horizontalTagL.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.horizontalTagL.ForeColor = System.Drawing.Color.White;
            this.horizontalTagL.Location = new System.Drawing.Point(3, 3);
            this.horizontalTagL.Name = "horizontalTagL";
            this.horizontalTagL.Size = new System.Drawing.Size(28, 16);
            this.horizontalTagL.TabIndex = 31;
            this.horizontalTagL.Text = "????";
            this.horizontalTagL.Visible = false;
            this.horizontalTagL.Click += new System.EventHandler(this.OnTagClick);
            // 
            // toDPSTime2TB
            // 
            this.toDPSTime2TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.toDPSTime2TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toDPSTime2TB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDPSTime2TB.ForeColor = System.Drawing.Color.Lime;
            this.toDPSTime2TB.Location = new System.Drawing.Point(118, 3);
            this.toDPSTime2TB.Name = "toDPSTime2TB";
            this.toDPSTime2TB.ReadOnly = true;
            this.toDPSTime2TB.Size = new System.Drawing.Size(64, 14);
            this.toDPSTime2TB.TabIndex = 32;
            this.toDPSTime2TB.Text = "?";
            this.toDPSTime2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toDPSTime2TB.Visible = false;
            // 
            // fromDPS2TB
            // 
            this.fromDPS2TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.fromDPS2TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromDPS2TB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDPS2TB.ForeColor = System.Drawing.Color.Red;
            this.fromDPS2TB.Location = new System.Drawing.Point(184, 3);
            this.fromDPS2TB.Name = "fromDPS2TB";
            this.fromDPS2TB.ReadOnly = true;
            this.fromDPS2TB.Size = new System.Drawing.Size(45, 14);
            this.fromDPS2TB.TabIndex = 33;
            this.fromDPS2TB.Text = "?";
            this.fromDPS2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fromDPS2TB.Visible = false;
            // 
            // verticalTagL
            // 
            this.verticalTagL.Dock = System.Windows.Forms.DockStyle.Left;
            this.verticalTagL.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verticalTagL.ForeColor = System.Drawing.Color.White;
            this.verticalTagL.Location = new System.Drawing.Point(0, 0);
            this.verticalTagL.Name = "verticalTagL";
            this.verticalTagL.NewText = "????";
            this.verticalTagL.RotateAngle = -90;
            this.verticalTagL.Size = new System.Drawing.Size(18, 72);
            this.verticalTagL.TabIndex = 0;
            this.verticalTagL.Click += new System.EventHandler(this.OnTagClick);
            // 
            // StatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.horizontalTagL);
            this.Controls.Add(this.bountyTimeTB);
            this.Controls.Add(this.bountyTotalTB);
            this.Controls.Add(this.styleCBBounty);
            this.Controls.Add(this.bountyPSTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDPSTimeTB);
            this.Controls.Add(this.fromDPSTotalTB);
            this.Controls.Add(this.toDPSTimeTB);
            this.Controls.Add(this.toDPSTotalTB);
            this.Controls.Add(this.styleCBTo);
            this.Controls.Add(this.styleCBFrom);
            this.Controls.Add(this.fromDPSTB);
            this.Controls.Add(this.toDPSTB);
            this.Controls.Add(this.verticalTagL);
            this.Controls.Add(this.toDPSTime2TB);
            this.Controls.Add(this.fromDPS2TB);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StatsControl";
            this.Size = new System.Drawing.Size(323, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bountyTimeTB;
        private System.Windows.Forms.TextBox bountyTotalTB;
        private System.Windows.Forms.ComboBox styleCBBounty;
        private System.Windows.Forms.TextBox bountyPSTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromDPSTimeTB;
        private System.Windows.Forms.TextBox fromDPSTotalTB;
        private System.Windows.Forms.TextBox toDPSTimeTB;
        private System.Windows.Forms.TextBox toDPSTotalTB;
        private System.Windows.Forms.ComboBox styleCBTo;
        private System.Windows.Forms.ComboBox styleCBFrom;
        private System.Windows.Forms.TextBox fromDPSTB;
        private System.Windows.Forms.TextBox toDPSTB;
        private System.Windows.Forms.Timer timer;
        private VerticalLabel verticalTagL;
        private System.Windows.Forms.Label horizontalTagL;
        private System.Windows.Forms.TextBox toDPSTime2TB;
        private System.Windows.Forms.TextBox fromDPS2TB;
    }
}
