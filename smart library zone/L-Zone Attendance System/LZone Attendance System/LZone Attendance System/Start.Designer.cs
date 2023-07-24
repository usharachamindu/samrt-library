namespace LZone_Attendance_System
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.cmbBranchId = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_passcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBranchId
            // 
            this.cmbBranchId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.cmbBranchId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranchId.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbBranchId.FormattingEnabled = true;
            this.cmbBranchId.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006"});
            this.cmbBranchId.Location = new System.Drawing.Point(431, 127);
            this.cmbBranchId.Name = "cmbBranchId";
            this.cmbBranchId.Size = new System.Drawing.Size(253, 24);
            this.cmbBranchId.TabIndex = 10;
            this.cmbBranchId.Text = "- select branch id -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(428, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "PassCode";
            // 
            // btnStart
            // 
            this.btnStart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderRadius = -20;
            this.btnStart.ButtonText = "START";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledColor = System.Drawing.Color.Gray;
            this.btnStart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStart.Iconimage = null;
            this.btnStart.Iconimage_right = null;
            this.btnStart.Iconimage_right_Selected = null;
            this.btnStart.Iconimage_Selected = null;
            this.btnStart.IconMarginLeft = 0;
            this.btnStart.IconMarginRight = 0;
            this.btnStart.IconRightVisible = true;
            this.btnStart.IconRightZoom = 0D;
            this.btnStart.IconVisible = true;
            this.btnStart.IconZoom = 90D;
            this.btnStart.IsTab = false;
            this.btnStart.Location = new System.Drawing.Point(481, 254);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(82)))));
            this.btnStart.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(153, 32);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "START";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tb_passcode
            // 
            this.tb_passcode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(82)))));
            this.tb_passcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_passcode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(82)))));
            this.tb_passcode.BorderThickness = 3;
            this.tb_passcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_passcode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.tb_passcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_passcode.isPassword = true;
            this.tb_passcode.Location = new System.Drawing.Point(512, 176);
            this.tb_passcode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_passcode.Name = "tb_passcode";
            this.tb_passcode.Size = new System.Drawing.Size(172, 26);
            this.tb_passcode.TabIndex = 15;
            this.tb_passcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 412);
            this.Controls.Add(this.tb_passcode);
            this.Controls.Add(this.cmbBranchId);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        public System.Windows.Forms.ComboBox cmbBranchId;
        public Bunifu.Framework.UI.BunifuMetroTextbox tb_passcode;
    }
}

