namespace 仓库温控系统
{
    partial class StoreRegionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uPanel2 = new WinCustControls.UPanel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uPanel1 = new WinCustControls.UPanel();
            this.cboState = new Sunny.UI.UIComboBox();
            this.cboStore = new Sunny.UI.UIComboBox();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.btnDelete = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.dgvStoreList = new Sunny.UI.UIDataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SRegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowLowTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowHighTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperStateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.recover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uPanel2.SuspendLayout();
            this.uPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // uPanel2
            // 
            this.uPanel2.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel2.Controls.Add(this.uiButton1);
            this.uPanel2.Controls.Add(this.label1);
            this.uPanel2.Location = new System.Drawing.Point(0, 0);
            this.uPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Size = new System.Drawing.Size(1133, 75);
            this.uPanel2.TabIndex = 3;
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.SeaGreen;
            this.uiButton1.FillColor2 = System.Drawing.Color.Firebrick;
            this.uiButton1.FillPressColor = System.Drawing.Color.Empty;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(955, 9);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 20;
            this.uiButton1.Size = new System.Drawing.Size(131, 52);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "刷新";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库分区管理页面";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uPanel1
            // 
            this.uPanel1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel1.Controls.Add(this.cboState);
            this.uPanel1.Controls.Add(this.cboStore);
            this.uPanel1.Controls.Add(this.uiCheckBox1);
            this.uPanel1.Controls.Add(this.btnDelete);
            this.uPanel1.Controls.Add(this.uiButton3);
            this.uPanel1.Controls.Add(this.uiTextBox1);
            this.uPanel1.Controls.Add(this.uiLabel3);
            this.uPanel1.Controls.Add(this.uiLabel2);
            this.uPanel1.Controls.Add(this.uiLabel1);
            this.uPanel1.Controls.Add(this.uiButton2);
            this.uPanel1.Location = new System.Drawing.Point(3, 72);
            this.uPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Size = new System.Drawing.Size(1128, 68);
            this.uPanel1.TabIndex = 4;
            this.uPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.uPanel1_Paint);
            // 
            // cboState
            // 
            this.cboState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboState.DataSource = null;
            this.cboState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboState.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboState.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboState.Location = new System.Drawing.Point(393, 20);
            this.cboState.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboState.MinimumSize = new System.Drawing.Size(84, 0);
            this.cboState.Name = "cboState";
            this.cboState.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.cboState.Size = new System.Drawing.Size(156, 30);
            this.cboState.SymbolSize = 24;
            this.cboState.TabIndex = 6;
            this.cboState.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboState.Watermark = "";
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // cboStore
            // 
            this.cboStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboStore.DataSource = null;
            this.cboStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboStore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStore.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboStore.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboStore.Location = new System.Drawing.Point(159, 20);
            this.cboStore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboStore.MinimumSize = new System.Drawing.Size(84, 0);
            this.cboStore.Name = "cboStore";
            this.cboStore.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.cboStore.Size = new System.Drawing.Size(156, 30);
            this.cboStore.SymbolSize = 24;
            this.cboStore.TabIndex = 6;
            this.cboStore.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboStore.Watermark = "";
            this.cboStore.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uiCheckBox1.CheckBoxColor = System.Drawing.Color.Turquoise;
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.uiCheckBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.uiCheckBox1.Location = new System.Drawing.Point(1023, 18);
            this.uiCheckBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Size = new System.Drawing.Size(103, 36);
            this.uiCheckBox1.TabIndex = 5;
            this.uiCheckBox1.Text = "已删除";
            this.uiCheckBox1.CheckedChanged += new System.EventHandler(this.uiCheckBox1_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.Salmon;
            this.btnDelete.FillColor2 = System.Drawing.Color.GreenYellow;
            this.btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(931, 20);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(87, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.DodgerBlue;
            this.uiButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(836, 21);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(89, 29);
            this.uiButton3.TabIndex = 3;
            this.uiButton3.Text = "查询";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uiTextBox1.ButtonForeColor = System.Drawing.Color.WhiteSmoke;
            this.uiTextBox1.ButtonStyleInherited = false;
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(644, 20);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uiTextBox1.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(176, 30);
            this.uiTextBox1.TabIndex = 2;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.uiLabel3.Location = new System.Drawing.Point(336, 24);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(73, 24);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "状态：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Click += new System.EventHandler(this.uiLabel3_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.uiLabel2.Location = new System.Drawing.Point(100, 24);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(112, 24);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "仓库：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.uiLabel1.Location = new System.Drawing.Point(568, 24);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(97, 24);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "关键词：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(246)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(5, 21);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(85, 28);
            this.uiButton2.TabIndex = 0;
            this.uiButton2.Text = "新增";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // dgvStoreList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvStoreList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreList.BackgroundColor = System.Drawing.Color.White;
            this.dgvStoreList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStoreList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStoreList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStoreList.ColumnHeadersHeight = 30;
            this.dgvStoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.SRegionId,
            this.SRegionName,
            this.StoreName,
            this.SRegionNo,
            this.SRTemperature,
            this.AllowLowTemperature,
            this.AllowHighTemperature,
            this.TemperStateText,
            this.update,
            this.delete,
            this.recover,
            this.remove});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStoreList.EnableHeadersVisualStyles = false;
            this.dgvStoreList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvStoreList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.dgvStoreList.Location = new System.Drawing.Point(3, 152);
            this.dgvStoreList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStoreList.Name = "dgvStoreList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStoreList.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvStoreList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStoreList.RowTemplate.Height = 23;
            this.dgvStoreList.SelectedIndex = -1;
            this.dgvStoreList.Size = new System.Drawing.Size(1128, 418);
            this.dgvStoreList.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvStoreList.TabIndex = 5;
            this.dgvStoreList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreList_CellContentClick);
            // 
            // colChk
            // 
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // SRegionId
            // 
            this.SRegionId.DataPropertyName = "SRegionId";
            this.SRegionId.FillWeight = 60F;
            this.SRegionId.HeaderText = "编号";
            this.SRegionId.MinimumWidth = 6;
            this.SRegionId.Name = "SRegionId";
            this.SRegionId.ReadOnly = true;
            // 
            // SRegionName
            // 
            this.SRegionName.DataPropertyName = "SRegionName";
            this.SRegionName.FillWeight = 102.6831F;
            this.SRegionName.HeaderText = "分区名";
            this.SRegionName.MinimumWidth = 6;
            this.SRegionName.Name = "SRegionName";
            this.SRegionName.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.FillWeight = 102.6831F;
            this.StoreName.HeaderText = "仓库";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // SRegionNo
            // 
            this.SRegionNo.DataPropertyName = "SRegionNo";
            this.SRegionNo.FillWeight = 102.6831F;
            this.SRegionNo.HeaderText = "编码";
            this.SRegionNo.MinimumWidth = 6;
            this.SRegionNo.Name = "SRegionNo";
            this.SRegionNo.ReadOnly = true;
            // 
            // SRTemperature
            // 
            this.SRTemperature.DataPropertyName = "SRTemperature";
            this.SRTemperature.HeaderText = "室内温度";
            this.SRTemperature.MinimumWidth = 6;
            this.SRTemperature.Name = "SRTemperature";
            this.SRTemperature.ReadOnly = true;
            // 
            // AllowLowTemperature
            // 
            this.AllowLowTemperature.DataPropertyName = "AllowLowTemperature";
            this.AllowLowTemperature.HeaderText = "低温";
            this.AllowLowTemperature.MinimumWidth = 6;
            this.AllowLowTemperature.Name = "AllowLowTemperature";
            this.AllowLowTemperature.ReadOnly = true;
            // 
            // AllowHighTemperature
            // 
            this.AllowHighTemperature.DataPropertyName = "AllowHighTemperature";
            this.AllowHighTemperature.HeaderText = "高温";
            this.AllowHighTemperature.MinimumWidth = 6;
            this.AllowHighTemperature.Name = "AllowHighTemperature";
            // 
            // TemperStateText
            // 
            this.TemperStateText.HeaderText = "状态";
            this.TemperStateText.MinimumWidth = 6;
            this.TemperStateText.Name = "TemperStateText";
            this.TemperStateText.ReadOnly = true;
            // 
            // update
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.NullValue = "修改";
            this.update.DefaultCellStyle = dataGridViewCellStyle3;
            this.update.FillWeight = 102.6831F;
            this.update.HeaderText = "修改";
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.NullValue = "删除";
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.FillWeight = 102.6831F;
            this.delete.HeaderText = "删除";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Width = 67;
            // 
            // recover
            // 
            dataGridViewCellStyle5.NullValue = "恢复";
            this.recover.DefaultCellStyle = dataGridViewCellStyle5;
            this.recover.FillWeight = 102.6831F;
            this.recover.HeaderText = "恢复";
            this.recover.MinimumWidth = 6;
            this.recover.Name = "recover";
            this.recover.Text = "恢复";
            // 
            // remove
            // 
            dataGridViewCellStyle6.NullValue = "移除";
            this.remove.DefaultCellStyle = dataGridViewCellStyle6;
            this.remove.HeaderText = "移除";
            this.remove.MinimumWidth = 6;
            this.remove.Name = "remove";
            this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // StoreRegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1133, 585);
            this.Controls.Add(this.dgvStoreList);
            this.Controls.Add(this.uPanel1);
            this.Controls.Add(this.uPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StoreRegionForm";
            this.Text = "StoreRegionForm";
            this.Load += new System.EventHandler(this.StoreRegionForm_Load);
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            this.uPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinCustControls.UPanel uPanel2;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.Label label1;
        private WinCustControls.UPanel uPanel1;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cboStore;
        private Sunny.UI.UIComboBox cboState;
        private Sunny.UI.UIDataGridView dgvStoreList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowLowTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowHighTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperStateText;
        private System.Windows.Forms.DataGridViewLinkColumn update;
        private System.Windows.Forms.DataGridViewLinkColumn delete;
        private System.Windows.Forms.DataGridViewLinkColumn recover;
        private System.Windows.Forms.DataGridViewLinkColumn remove;
    }
}