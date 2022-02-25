namespace Assignment1
{
    partial class Gmap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lbl_Lat = new System.Windows.Forms.Label();
            this.lbl_long = new System.Windows.Forms.Label();
            this.lbl_lat_value = new System.Windows.Forms.Label();
            this.lbl_long_Value = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calender = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.calender.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(16, 15);
            this.map.Margin = new System.Windows.Forms.Padding(4);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1411, 643);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click);
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapMouseMove);
            // 
            // lbl_Lat
            // 
            this.lbl_Lat.AutoSize = true;
            this.lbl_Lat.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Lat.Location = new System.Drawing.Point(23, 31);
            this.lbl_Lat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lat.Name = "lbl_Lat";
            this.lbl_Lat.Size = new System.Drawing.Size(79, 20);
            this.lbl_Lat.TabIndex = 7;
            this.lbl_Lat.Text = "Lattitude:";
            this.lbl_Lat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Lat.Click += new System.EventHandler(this.lbl_Lat_Click);
            // 
            // lbl_long
            // 
            this.lbl_long.AutoSize = true;
            this.lbl_long.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_long.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_long.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_long.Location = new System.Drawing.Point(15, 72);
            this.lbl_long.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_long.Name = "lbl_long";
            this.lbl_long.Size = new System.Drawing.Size(87, 20);
            this.lbl_long.TabIndex = 9;
            this.lbl_long.Text = "Longitude:";
            this.lbl_long.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_lat_value
            // 
            this.lbl_lat_value.AutoSize = true;
            this.lbl_lat_value.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_lat_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lat_value.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_lat_value.Location = new System.Drawing.Point(130, 31);
            this.lbl_lat_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lat_value.Name = "lbl_lat_value";
            this.lbl_lat_value.Size = new System.Drawing.Size(15, 20);
            this.lbl_lat_value.TabIndex = 10;
            this.lbl_lat_value.Text = "-";
            this.lbl_lat_value.Click += new System.EventHandler(this.lbl_lat_value_Click);
            // 
            // lbl_long_Value
            // 
            this.lbl_long_Value.AutoSize = true;
            this.lbl_long_Value.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_long_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_long_Value.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_long_Value.Location = new System.Drawing.Point(130, 72);
            this.lbl_long_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_long_Value.Name = "lbl_long_Value";
            this.lbl_long_Value.Size = new System.Drawing.Size(15, 20);
            this.lbl_long_Value.TabIndex = 11;
            this.lbl_long_Value.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1166, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calender
            // 
            this.calender.Controls.Add(this.btnExit);
            this.calender.Controls.Add(this.btnHide);
            this.calender.Controls.Add(this.monthCalendar1);
            this.calender.Location = new System.Drawing.Point(1156, 15);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(271, 275);
            this.calender.TabIndex = 13;
            this.calender.TabStop = false;
            this.calender.Text = "Calendar";
            this.calender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(34, 246);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1353, 296);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(430, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "CLICK ON ANY LOCATION TO ADD AN EVENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_long_Value);
            this.Controls.Add(this.lbl_lat_value);
            this.Controls.Add(this.lbl_long);
            this.Controls.Add(this.lbl_Lat);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gmap";
            this.Text = "Gmap";
            this.Load += new System.EventHandler(this.Gmap_Load);
            this.calender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label lbl_Lat;
        private System.Windows.Forms.Label lbl_long;
        public System.Windows.Forms.Label lbl_lat_value;
        public System.Windows.Forms.Label lbl_long_Value;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox calender;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
    }
}

