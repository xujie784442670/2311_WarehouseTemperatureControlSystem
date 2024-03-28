using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 仓库温控系统
{
    public partial class FormMain : UIForm
    {
        public StoreManagement store;
        public ProductManagement product;
        public TemperatureControl temperature;
        

        public FormMain()
        {
            InitializeComponent();
            store = new StoreManagement();
            product = new ProductManagement();
            temperature = new TemperatureControl();
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            StoreManagement store = new StoreManagement();
            
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            
            store.Show();
            showPanel.Controls.Clear();
            showPanel.Controls.Add(store);
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            product.Show();
            showPanel.Controls.Clear();
            showPanel.Controls.Add(product);
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            temperature.Show();
            showPanel.Controls.Clear();
            showPanel.Controls.Add(temperature);
        }
    }
}
