namespace 仓库温控系统
{
    partial class TemperatureControl
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiLight3 = new Sunny.UI.UILight();
            this.uiLight2 = new Sunny.UI.UILight();
            this.uiLight1 = new Sunny.UI.UILight();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uiFlowLayoutPanel1 = new Sunny.UI.UIFlowLayoutPanel();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.FillColor = System.Drawing.Color.DarkBlue;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(3, 2);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(1143, 29);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(21, 4);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(82, 20);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "仓库";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiButton2);
            this.uiPanel2.Controls.Add(this.uiButton1);
            this.uiPanel2.Controls.Add(this.uiComboBox1);
            this.uiPanel2.Controls.Add(this.uiLabel3);
            this.uiPanel2.Controls.Add(this.uiLabel2);
            this.uiPanel2.FillColor = System.Drawing.Color.DarkBlue;
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(3, 31);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(1143, 54);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(764, 20);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 30;
            this.uiButton2.Size = new System.Drawing.Size(59, 35);
            this.uiButton2.TabIndex = 2;
            this.uiButton2.Text = "刷新";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(341, 20);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "手动检测";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiComboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.ForeColor = System.Drawing.Color.White;
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(140, 23);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(171, 29);
            this.uiComboBox1.TabIndex = 1;
            this.uiComboBox1.Text = "----请选择----";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 10F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(491, 26);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "检测完成";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 14F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(10, 26);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(123, 23);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "仓库选择:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackColor = System.Drawing.Color.DarkBlue;
            this.uiPanel3.Controls.Add(this.uiLight3);
            this.uiPanel3.Controls.Add(this.uiLight2);
            this.uiPanel3.Controls.Add(this.uiLight1);
            this.uiPanel3.Controls.Add(this.uiLabel7);
            this.uiPanel3.Controls.Add(this.uiLabel6);
            this.uiPanel3.Controls.Add(this.uiLabel5);
            this.uiPanel3.Controls.Add(this.uiLabel4);
            this.uiPanel3.FillColor = System.Drawing.Color.DarkBlue;
            this.uiPanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(3, 94);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1143, 43);
            this.uiPanel3.TabIndex = 2;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLight3
            // 
            this.uiLight3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight3.Location = new System.Drawing.Point(960, 3);
            this.uiLight3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight3.Name = "uiLight3";
            this.uiLight3.OnColor = System.Drawing.Color.Cyan;
            this.uiLight3.Radius = 29;
            this.uiLight3.Size = new System.Drawing.Size(29, 29);
            this.uiLight3.TabIndex = 3;
            this.uiLight3.Text = "uiLight1";
            // 
            // uiLight2
            // 
            this.uiLight2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight2.Location = new System.Drawing.Point(865, 3);
            this.uiLight2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight2.Name = "uiLight2";
            this.uiLight2.OnColor = System.Drawing.Color.Red;
            this.uiLight2.Radius = 29;
            this.uiLight2.Size = new System.Drawing.Size(29, 29);
            this.uiLight2.TabIndex = 3;
            this.uiLight2.Text = "uiLight1";
            // 
            // uiLight1
            // 
            this.uiLight1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight1.Location = new System.Drawing.Point(771, 3);
            this.uiLight1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight1.Name = "uiLight1";
            this.uiLight1.Radius = 29;
            this.uiLight1.Size = new System.Drawing.Size(29, 29);
            this.uiLight1.TabIndex = 3;
            this.uiLight1.Text = "uiLight1";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 10F);
            this.uiLabel7.ForeColor = System.Drawing.Color.White;
            this.uiLabel7.Location = new System.Drawing.Point(995, 9);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(46, 23);
            this.uiLabel7.TabIndex = 0;
            this.uiLabel7.Text = "正常";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 10F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(900, 9);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(46, 23);
            this.uiLabel6.TabIndex = 0;
            this.uiLabel6.Text = "高温";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 10F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(806, 9);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(46, 23);
            this.uiLabel5.TabIndex = 0;
            this.uiLabel5.Text = "低温";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 10F);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(10, 9);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(123, 23);
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "仓库分区列表";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiFlowLayoutPanel1
            // 
            this.uiFlowLayoutPanel1.FillColor = System.Drawing.Color.DarkBlue;
            this.uiFlowLayoutPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiFlowLayoutPanel1.Location = new System.Drawing.Point(3, 147);
            this.uiFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiFlowLayoutPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiFlowLayoutPanel1.Name = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.uiFlowLayoutPanel1.ShowText = false;
            this.uiFlowLayoutPanel1.Size = new System.Drawing.Size(1143, 373);
            this.uiFlowLayoutPanel1.TabIndex = 3;
            this.uiFlowLayoutPanel1.Text = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1145, 521);
            this.Controls.Add(this.uiFlowLayoutPanel1);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "TemperatureControl";
            this.PageIndex = 2;
            this.RectColor = System.Drawing.Color.Transparent;
            this.Text = "仓库温管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(17, 17, 800, 450);
            this.Load += new System.EventHandler(this.TemperatureControl_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILight uiLight3;
        private Sunny.UI.UILight uiLight2;
        private Sunny.UI.UILight uiLight1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Sunny.UI.UIFlowLayoutPanel uiFlowLayoutPanel1;
    }
}