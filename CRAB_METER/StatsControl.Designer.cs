﻿namespace ELO {
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
            this.toDPSWeaponTB = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bountyTotal2TB = new System.Windows.Forms.TextBox();
            this.verticalTagL = new ELO.VerticalLabel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bountyTimeTB
            // 
            this.bountyTimeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.bountyTimeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bountyTimeTB.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bountyTimeTB.ForeColor = System.Drawing.Color.Gold;
            this.bountyTimeTB.Location = new System.Drawing.Point(102, 66);
            this.bountyTimeTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
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
            this.bountyTotalTB.Location = new System.Drawing.Point(1, 66);
            this.bountyTotalTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.bountyTotalTB.Name = "bountyTotalTB";
            this.bountyTotalTB.ReadOnly = true;
            this.bountyTotalTB.Size = new System.Drawing.Size(99, 20);
            this.bountyTotalTB.TabIndex = 29;
            this.bountyTotalTB.Text = "?";
            this.bountyTotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bountyTotalTB.TextChanged += new System.EventHandler(this.bountyTotalTB_TextChanged);
            // 
            // styleCBBounty
            // 
            this.styleCBBounty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.styleCBBounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleCBBounty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styleCBBounty.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.styleCBBounty.ForeColor = System.Drawing.Color.White;
            this.styleCBBounty.FormattingEnabled = true;
            this.styleCBBounty.Location = new System.Drawing.Point(216, 64);
            this.styleCBBounty.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
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
            this.bountyPSTB.Location = new System.Drawing.Point(168, 66);
            this.bountyPSTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
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
            this.fromDPSTimeTB.Location = new System.Drawing.Point(102, 43);
            this.fromDPSTimeTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
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
            this.fromDPSTotalTB.Location = new System.Drawing.Point(1, 43);
            this.fromDPSTotalTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
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
            this.toDPSTimeTB.Location = new System.Drawing.Point(102, 2);
            this.toDPSTimeTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
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
            this.toDPSTotalTB.Location = new System.Drawing.Point(1, 2);
            this.toDPSTotalTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
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
            this.styleCBTo.Location = new System.Drawing.Point(216, 0);
            this.styleCBTo.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
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
            this.styleCBFrom.Location = new System.Drawing.Point(216, 41);
            this.styleCBFrom.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
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
            this.fromDPSTB.Location = new System.Drawing.Point(168, 43);
            this.fromDPSTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
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
            this.toDPSTB.Location = new System.Drawing.Point(168, 2);
            this.toDPSTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
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
            this.horizontalTagL.Location = new System.Drawing.Point(3, 2);
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
            this.toDPSTime2TB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDPSTime2TB.ForeColor = System.Drawing.Color.Lime;
            this.toDPSTime2TB.Location = new System.Drawing.Point(131, 3);
            this.toDPSTime2TB.Name = "toDPSTime2TB";
            this.toDPSTime2TB.ReadOnly = true;
            this.toDPSTime2TB.Size = new System.Drawing.Size(48, 18);
            this.toDPSTime2TB.TabIndex = 32;
            this.toDPSTime2TB.Text = "?";
            this.toDPSTime2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toDPSTime2TB.Visible = false;
            // 
            // fromDPS2TB
            // 
            this.fromDPS2TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.fromDPS2TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromDPS2TB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDPS2TB.ForeColor = System.Drawing.Color.Red;
            this.fromDPS2TB.Location = new System.Drawing.Point(183, 3);
            this.fromDPS2TB.Name = "fromDPS2TB";
            this.fromDPS2TB.ReadOnly = true;
            this.fromDPS2TB.Size = new System.Drawing.Size(45, 18);
            this.fromDPS2TB.TabIndex = 33;
            this.fromDPS2TB.Text = "?";
            this.fromDPS2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fromDPS2TB.Visible = false;
            // 
            // toDPSWeaponTB
            // 
            this.toDPSWeaponTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.toDPSWeaponTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainPanel.SetColumnSpan(this.toDPSWeaponTB, 4);
            this.toDPSWeaponTB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDPSWeaponTB.ForeColor = System.Drawing.Color.Lime;
            this.toDPSWeaponTB.Location = new System.Drawing.Point(1, 24);
            this.toDPSWeaponTB.Margin = new System.Windows.Forms.Padding(1);
            this.toDPSWeaponTB.Multiline = true;
            this.toDPSWeaponTB.Name = "toDPSWeaponTB";
            this.toDPSWeaponTB.ReadOnly = true;
            this.toDPSWeaponTB.Size = new System.Drawing.Size(284, 16);
            this.toDPSWeaponTB.TabIndex = 34;
            this.toDPSWeaponTB.Visible = false;
            this.toDPSWeaponTB.WordWrap = false;
            this.toDPSWeaponTB.TextChanged += new System.EventHandler(this.toDPSWeaponTB_TextChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.ColumnCount = 4;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.Controls.Add(this.toDPSTotalTB, 0, 0);
            this.mainPanel.Controls.Add(this.toDPSWeaponTB, 0, 1);
            this.mainPanel.Controls.Add(this.styleCBBounty, 3, 3);
            this.mainPanel.Controls.Add(this.bountyTimeTB, 1, 3);
            this.mainPanel.Controls.Add(this.bountyPSTB, 2, 3);
            this.mainPanel.Controls.Add(this.toDPSTimeTB, 1, 0);
            this.mainPanel.Controls.Add(this.bountyTotalTB, 0, 3);
            this.mainPanel.Controls.Add(this.toDPSTB, 2, 0);
            this.mainPanel.Controls.Add(this.styleCBTo, 3, 0);
            this.mainPanel.Controls.Add(this.fromDPSTotalTB, 0, 2);
            this.mainPanel.Controls.Add(this.fromDPSTimeTB, 1, 2);
            this.mainPanel.Controls.Add(this.styleCBFrom, 3, 2);
            this.mainPanel.Controls.Add(this.fromDPSTB, 2, 2);
            this.mainPanel.Location = new System.Drawing.Point(15, 2);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.Size = new System.Drawing.Size(286, 90);
            this.mainPanel.TabIndex = 35;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // bountyTotal2TB
            // 
            this.bountyTotal2TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.bountyTotal2TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bountyTotal2TB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bountyTotal2TB.ForeColor = System.Drawing.Color.Yellow;
            this.bountyTotal2TB.Location = new System.Drawing.Point(73, 3);
            this.bountyTotal2TB.Name = "bountyTotal2TB";
            this.bountyTotal2TB.ReadOnly = true;
            this.bountyTotal2TB.Size = new System.Drawing.Size(54, 18);
            this.bountyTotal2TB.TabIndex = 36;
            this.bountyTotal2TB.Text = "?";
            this.bountyTotal2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bountyTotal2TB.Visible = false;
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
            this.verticalTagL.Size = new System.Drawing.Size(18, 93);
            this.verticalTagL.TabIndex = 0;
            this.verticalTagL.Click += new System.EventHandler(this.OnTagClick);
            // 
            // StatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bountyTotal2TB);
            this.Controls.Add(this.horizontalTagL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticalTagL);
            this.Controls.Add(this.toDPSTime2TB);
            this.Controls.Add(this.fromDPS2TB);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StatsControl";
            this.Size = new System.Drawing.Size(323, 93);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StatsControl_Paint);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox toDPSWeaponTB;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TextBox bountyTotal2TB;
    }
}
