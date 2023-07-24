namespace LZone_Employee_Attendance_System
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.brnArrive = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.arriveDataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tb_branchId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_QRcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.leave1 = new LZone_Employee_Attendance_System.Leave();
            ((System.ComponentModel.ISupportInitialize)(this.arriveDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // brnArrive
            // 
            this.brnArrive.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brnArrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.brnArrive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnArrive.BorderRadius = -20;
            this.brnArrive.ButtonText = "ARRIVE PAGE";
            this.brnArrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnArrive.DisabledColor = System.Drawing.Color.Gray;
            this.brnArrive.Iconcolor = System.Drawing.Color.Transparent;
            this.brnArrive.Iconimage = null;
            this.brnArrive.Iconimage_right = null;
            this.brnArrive.Iconimage_right_Selected = null;
            this.brnArrive.Iconimage_Selected = null;
            this.brnArrive.IconMarginLeft = 0;
            this.brnArrive.IconMarginRight = 0;
            this.brnArrive.IconRightVisible = true;
            this.brnArrive.IconRightZoom = 0D;
            this.brnArrive.IconVisible = true;
            this.brnArrive.IconZoom = 90D;
            this.brnArrive.IsTab = false;
            this.brnArrive.Location = new System.Drawing.Point(1111, 687);
            this.brnArrive.Name = "brnArrive";
            this.brnArrive.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.brnArrive.OnHovercolor = System.Drawing.Color.White;
            this.brnArrive.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.brnArrive.selected = false;
            this.brnArrive.Size = new System.Drawing.Size(153, 32);
            this.brnArrive.TabIndex = 208;
            this.brnArrive.Text = "ARRIVE PAGE";
            this.brnArrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brnArrive.Textcolor = System.Drawing.Color.White;
            this.brnArrive.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnArrive.Click += new System.EventHandler(this.brnArrive_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblTime.Location = new System.Drawing.Point(955, 371);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(234, 23);
            this.lblTime.TabIndex = 207;
            this.lblTime.Text = "Time";
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = -20;
            this.btnReset.ButtonText = "RESET";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = null;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(406, 686);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReset.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(131, 31);
            this.btnReset.TabIndex = 206;
            this.btnReset.Text = "RESET";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = -20;
            this.btnExit.ButtonText = "EXIT";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(136, 687);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(131, 31);
            this.btnExit.TabIndex = 205;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(579, 368);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel5.TabIndex = 203;
            this.bunifuCustomLabel5.Text = "Branch Id";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // arriveDataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.arriveDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.arriveDataTable.BackgroundColor = System.Drawing.Color.White;
            this.arriveDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arriveDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.arriveDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.arriveDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arriveDataTable.DoubleBuffered = true;
            this.arriveDataTable.EnableHeadersVisualStyles = false;
            this.arriveDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.arriveDataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.arriveDataTable.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.arriveDataTable.Location = new System.Drawing.Point(582, 493);
            this.arriveDataTable.Name = "arriveDataTable";
            this.arriveDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.arriveDataTable.Size = new System.Drawing.Size(540, 113);
            this.arriveDataTable.TabIndex = 201;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BorderRadius = -20;
            this.btnSubmit.ButtonText = "ARRIVE";
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
            this.btnSubmit.Location = new System.Drawing.Point(843, 444);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnSubmit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(131, 31);
            this.btnSubmit.TabIndex = 200;
            this.btnSubmit.Text = "ARRIVE";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblDate.Location = new System.Drawing.Point(955, 291);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(234, 23);
            this.lblDate.TabIndex = 199;
            this.lblDate.Text = "Date";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(579, 291);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel2.TabIndex = 198;
            this.bunifuCustomLabel2.Text = "User Name";
            // 
            // cmbDevice
            // 
            this.cmbDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevice.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(225, 249);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(199, 24);
            this.cmbDevice.TabIndex = 196;
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(164, 291);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(253, 147);
            this.pbCamera.TabIndex = 195;
            this.pbCamera.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tb_branchId
            // 
            this.tb_branchId.BackColor = System.Drawing.SystemColors.Control;
            this.tb_branchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_branchId.Enabled = false;
            this.tb_branchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_branchId.Location = new System.Drawing.Point(686, 369);
            this.tb_branchId.Name = "tb_branchId";
            this.tb_branchId.ReadOnly = true;
            this.tb_branchId.Size = new System.Drawing.Size(202, 23);
            this.tb_branchId.TabIndex = 204;
            this.tb_branchId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(9, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 2);
            this.label2.TabIndex = 202;
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
            this.btnStart.Location = new System.Drawing.Point(225, 444);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(131, 31);
            this.btnStart.TabIndex = 197;
            this.btnStart.Text = "SCAN";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.tb_QRcode.Location = new System.Drawing.Point(686, 286);
            this.tb_QRcode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_QRcode.Name = "tb_QRcode";
            this.tb_QRcode.Size = new System.Drawing.Size(202, 28);
            this.tb_QRcode.TabIndex = 194;
            this.tb_QRcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(146, 252);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(97, 23);
            this.bunifuCustomLabel4.TabIndex = 193;
            this.bunifuCustomLabel4.Text = "Camera";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(245, 184);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(228, 54);
            this.bunifuCustomLabel1.TabIndex = 192;
            this.bunifuCustomLabel1.Text = "Arriving";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-31, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1428, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 189;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeave
            // 
            this.btnLeave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeave.BorderRadius = -20;
            this.btnLeave.ButtonText = "LEAVE PAGE";
            this.btnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeave.DisabledColor = System.Drawing.Color.Gray;
            this.btnLeave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLeave.Iconimage = null;
            this.btnLeave.Iconimage_right = null;
            this.btnLeave.Iconimage_right_Selected = null;
            this.btnLeave.Iconimage_Selected = null;
            this.btnLeave.IconMarginLeft = 0;
            this.btnLeave.IconMarginRight = 0;
            this.btnLeave.IconRightVisible = true;
            this.btnLeave.IconRightZoom = 0D;
            this.btnLeave.IconVisible = true;
            this.btnLeave.IconZoom = 90D;
            this.btnLeave.IsTab = false;
            this.btnLeave.Location = new System.Drawing.Point(735, 686);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnLeave.OnHovercolor = System.Drawing.Color.White;
            this.btnLeave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnLeave.selected = false;
            this.btnLeave.Size = new System.Drawing.Size(153, 32);
            this.btnLeave.TabIndex = 191;
            this.btnLeave.Text = "LEAVE PAGE";
            this.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLeave.Textcolor = System.Drawing.Color.White;
            this.btnLeave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(-1, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1367, 55);
            this.label1.TabIndex = 190;
            // 
            // leave1
            // 
            this.leave1.BackColor = System.Drawing.Color.White;
            this.leave1.Location = new System.Drawing.Point(0, 164);
            this.leave1.Name = "leave1";
            this.leave1.Size = new System.Drawing.Size(1366, 506);
            this.leave1.TabIndex = 209;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.leave1);
            this.Controls.Add(this.brnArrive);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.arriveDataTable);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.tb_branchId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tb_QRcode);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arriveDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton brnArrive;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTime;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid arriveDataTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tb_branchId;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_QRcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLeave;
        private System.Windows.Forms.Label label1;
        private Leave leave1;
    }
}