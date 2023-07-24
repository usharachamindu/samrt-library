namespace LZone_Attendance_System
{
    partial class Leave
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.tb_QRcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.leaveDataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(-3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 2);
            this.label1.TabIndex = 176;
            // 
            // btnDone
            // 
            this.btnDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.BorderRadius = -20;
            this.btnDone.ButtonText = "DONE";
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.DisabledColor = System.Drawing.Color.Gray;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDone.Iconimage = null;
            this.btnDone.Iconimage_right = null;
            this.btnDone.Iconimage_right_Selected = null;
            this.btnDone.Iconimage_Selected = null;
            this.btnDone.IconMarginLeft = 0;
            this.btnDone.IconMarginRight = 0;
            this.btnDone.IconRightVisible = true;
            this.btnDone.IconRightZoom = 0D;
            this.btnDone.IconVisible = true;
            this.btnDone.IconZoom = 90D;
            this.btnDone.IsTab = false;
            this.btnDone.Location = new System.Drawing.Point(943, 424);
            this.btnDone.Name = "btnDone";
            this.btnDone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnDone.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDone.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnDone.selected = false;
            this.btnDone.Size = new System.Drawing.Size(131, 31);
            this.btnDone.TabIndex = 174;
            this.btnDone.Text = "DONE";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDone.Textcolor = System.Drawing.Color.White;
            this.btnDone.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BorderRadius = -20;
            this.btnSubmit.ButtonText = "LEAVE";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.Iconimage = null;
            this.btnSubmit.Iconimage_right = null;
            this.btnSubmit.Iconimage_right_Selected = null;
            this.btnSubmit.Iconimage_Selected = null;
            this.btnSubmit.IconMarginLeft = 0;
            this.btnSubmit.IconMarginRight = 0;
            this.btnSubmit.IconRightVisible = true;
            this.btnSubmit.IconRightZoom = 0D;
            this.btnSubmit.IconVisible = true;
            this.btnSubmit.IconZoom = 90D;
            this.btnSubmit.IsTab = false;
            this.btnSubmit.Location = new System.Drawing.Point(943, 165);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnSubmit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(131, 31);
            this.btnSubmit.TabIndex = 173;
            this.btnSubmit.Text = "LEAVE";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(675, 125);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel2.TabIndex = 169;
            this.bunifuCustomLabel2.Text = "User Name";
            // 
            // btnStart
            // 
            this.btnStart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderRadius = -20;
            this.btnStart.ButtonText = "SCAN";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledColor = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnStart.Location = new System.Drawing.Point(213, 424);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(131, 31);
            this.btnStart.TabIndex = 164;
            this.btnStart.Text = "SCAN";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevice.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(213, 124);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(199, 24);
            this.cmbDevice.TabIndex = 163;
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(159, 219);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(253, 147);
            this.pbCamera.TabIndex = 162;
            this.pbCamera.TabStop = false;
            // 
            // tb_QRcode
            // 
            this.tb_QRcode.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_QRcode.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_QRcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_QRcode.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_QRcode.BorderThickness = 2;
            this.tb_QRcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_QRcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_QRcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_QRcode.isPassword = false;
            this.tb_QRcode.Location = new System.Drawing.Point(782, 120);
            this.tb_QRcode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_QRcode.Name = "tb_QRcode";
            this.tb_QRcode.Size = new System.Drawing.Size(202, 28);
            this.tb_QRcode.TabIndex = 161;
            this.tb_QRcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(134, 127);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(97, 23);
            this.bunifuCustomLabel4.TabIndex = 160;
            this.bunifuCustomLabel4.Text = "Camera";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(233, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(228, 54);
            this.bunifuCustomLabel1.TabIndex = 159;
            this.bunifuCustomLabel1.Text = "Leaving";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(1038, 125);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel6.TabIndex = 171;
            this.bunifuCustomLabel6.Text = "Leave Time";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblTime.Location = new System.Drawing.Point(1142, 125);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(202, 28);
            this.lblTime.TabIndex = 188;
            this.lblTime.Text = "Time";
            // 
            // leaveDataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.leaveDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.leaveDataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.leaveDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaveDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leaveDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.leaveDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveDataTable.DoubleBuffered = true;
            this.leaveDataTable.EnableHeadersVisualStyles = false;
            this.leaveDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.leaveDataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.leaveDataTable.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.leaveDataTable.Location = new System.Drawing.Point(678, 219);
            this.leaveDataTable.Name = "leaveDataTable";
            this.leaveDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.leaveDataTable.Size = new System.Drawing.Size(576, 186);
            this.leaveDataTable.TabIndex = 191;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.leaveDataTable);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.tb_QRcode);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "Leave";
            this.Size = new System.Drawing.Size(1366, 506);
            this.Load += new System.EventHandler(this.Leave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDone;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.PictureBox pbCamera;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_QRcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTime;
        private Bunifu.Framework.UI.BunifuCustomDataGrid leaveDataTable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
