namespace 仓库温控系统
{
    partial class FormModBusTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.hostCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portCb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.slaveTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addrTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lenTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataTypeCb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.subscribedCb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTb = new System.Windows.Forms.TextBox();
            this.uTb = new System.Windows.Forms.TextBox();
            this.fTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bsTb = new System.Windows.Forms.TextBox();
            this.usTb = new System.Windows.Forms.TextBox();
            this.fsTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机地址:";
            // 
            // hostCb
            // 
            this.hostCb.Font = new System.Drawing.Font("宋体", 12F);
            this.hostCb.FormattingEnabled = true;
            this.hostCb.Location = new System.Drawing.Point(97, 17);
            this.hostCb.Name = "hostCb";
            this.hostCb.Size = new System.Drawing.Size(164, 24);
            this.hostCb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(267, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口:";
            // 
            // portCb
            // 
            this.portCb.Font = new System.Drawing.Font("宋体", 12F);
            this.portCb.Location = new System.Drawing.Point(315, 17);
            this.portCb.Name = "portCb";
            this.portCb.Size = new System.Drawing.Size(182, 26);
            this.portCb.TabIndex = 2;
            this.portCb.Text = "502";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(503, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "同步读取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "从站地址:";
            // 
            // slaveTb
            // 
            this.slaveTb.Font = new System.Drawing.Font("宋体", 12F);
            this.slaveTb.Location = new System.Drawing.Point(145, 64);
            this.slaveTb.Name = "slaveTb";
            this.slaveTb.Size = new System.Drawing.Size(100, 26);
            this.slaveTb.TabIndex = 2;
            this.slaveTb.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "寄存器起始地址:";
            // 
            // addrTb
            // 
            this.addrTb.Font = new System.Drawing.Font("宋体", 12F);
            this.addrTb.Location = new System.Drawing.Point(145, 109);
            this.addrTb.Name = "addrTb";
            this.addrTb.Size = new System.Drawing.Size(100, 26);
            this.addrTb.TabIndex = 2;
            this.addrTb.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(275, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "数据长度:";
            // 
            // lenTb
            // 
            this.lenTb.Font = new System.Drawing.Font("宋体", 12F);
            this.lenTb.Location = new System.Drawing.Point(360, 64);
            this.lenTb.Name = "lenTb";
            this.lenTb.Size = new System.Drawing.Size(137, 26);
            this.lenTb.TabIndex = 2;
            this.lenTb.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(275, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "数据类型:";
            // 
            // dataTypeCb
            // 
            this.dataTypeCb.Font = new System.Drawing.Font("宋体", 12F);
            this.dataTypeCb.FormattingEnabled = true;
            this.dataTypeCb.Location = new System.Drawing.Point(360, 110);
            this.dataTypeCb.Name = "dataTypeCb";
            this.dataTypeCb.Size = new System.Drawing.Size(137, 24);
            this.dataTypeCb.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.Location = new System.Drawing.Point(503, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "异步读取";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F);
            this.button3.Location = new System.Drawing.Point(503, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "订阅";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F);
            this.button4.Location = new System.Drawing.Point(503, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "连接";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // subscribedCb
            // 
            this.subscribedCb.AutoSize = true;
            this.subscribedCb.Font = new System.Drawing.Font("宋体", 12F);
            this.subscribedCb.Location = new System.Drawing.Point(437, 26);
            this.subscribedCb.Name = "subscribedCb";
            this.subscribedCb.Size = new System.Drawing.Size(90, 20);
            this.subscribedCb.TabIndex = 4;
            this.subscribedCb.Text = "开启订阅";
            this.subscribedCb.UseVisualStyleBackColor = true;
            this.subscribedCb.CheckedChanged += new System.EventHandler(this.subscribedCb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bTb);
            this.groupBox1.Controls.Add(this.uTb);
            this.groupBox1.Controls.Add(this.fTb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单值";
            // 
            // bTb
            // 
            this.bTb.Font = new System.Drawing.Font("宋体", 12F);
            this.bTb.Location = new System.Drawing.Point(437, 26);
            this.bTb.Name = "bTb";
            this.bTb.Size = new System.Drawing.Size(100, 26);
            this.bTb.TabIndex = 6;
            // 
            // uTb
            // 
            this.uTb.Font = new System.Drawing.Font("宋体", 12F);
            this.uTb.Location = new System.Drawing.Point(273, 26);
            this.uTb.Name = "uTb";
            this.uTb.Size = new System.Drawing.Size(100, 26);
            this.uTb.TabIndex = 7;
            // 
            // fTb
            // 
            this.fTb.Font = new System.Drawing.Font("宋体", 12F);
            this.fTb.Location = new System.Drawing.Point(85, 26);
            this.fTb.Name = "fTb";
            this.fTb.Size = new System.Drawing.Size(100, 26);
            this.fTb.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(378, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "bool:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(204, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "ushort:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(24, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Float:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bsTb);
            this.groupBox2.Controls.Add(this.usTb);
            this.groupBox2.Controls.Add(this.fsTb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "多值";
            // 
            // bsTb
            // 
            this.bsTb.Font = new System.Drawing.Font("宋体", 12F);
            this.bsTb.Location = new System.Drawing.Point(437, 26);
            this.bsTb.Name = "bsTb";
            this.bsTb.Size = new System.Drawing.Size(100, 26);
            this.bsTb.TabIndex = 6;
            // 
            // usTb
            // 
            this.usTb.Font = new System.Drawing.Font("宋体", 12F);
            this.usTb.Location = new System.Drawing.Point(273, 26);
            this.usTb.Name = "usTb";
            this.usTb.Size = new System.Drawing.Size(100, 26);
            this.usTb.TabIndex = 7;
            // 
            // fsTb
            // 
            this.fsTb.Font = new System.Drawing.Font("宋体", 12F);
            this.fsTb.Location = new System.Drawing.Point(85, 26);
            this.fsTb.Name = "fsTb";
            this.fsTb.Size = new System.Drawing.Size(100, 26);
            this.fsTb.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(378, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "bool:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(204, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "ushort:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(24, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Float:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.subscribedCb);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 69);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "订阅";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(9, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "扫描间隔:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.Location = new System.Drawing.Point(94, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(270, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "毫秒";
            // 
            // FormModBusTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 370);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lenTb);
            this.Controls.Add(this.addrTb);
            this.Controls.Add(this.slaveTb);
            this.Controls.Add(this.portCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataTypeCb);
            this.Controls.Add(this.hostCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormModBusTest";
            this.Text = "Modbus测试工具";
            this.Load += new System.EventHandler(this.FormModBusTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hostCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portCb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox slaveTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addrTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lenTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dataTypeCb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox subscribedCb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bTb;
        private System.Windows.Forms.TextBox uTb;
        private System.Windows.Forms.TextBox fTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bsTb;
        private System.Windows.Forms.TextBox usTb;
        private System.Windows.Forms.TextBox fsTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}