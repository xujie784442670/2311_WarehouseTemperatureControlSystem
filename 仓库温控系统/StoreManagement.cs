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
using WtcsService;

namespace 仓库温控系统
{
    public partial class StoreManagement : UIPage
    {
        public StoreManagement()
        {
            InitializeComponent();
        }

        private void StoreManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DataSet ds = StoreService.SelectAll();
            this.dataGridView1.DataSource = ds.Tables[0];
        }


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取选择的第几行第几列
            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //选择的内容
            string headText = cell.FormattedValue.ToString();
            int row = e.RowIndex;
            
            switch (headText)
            {

                case "添加分区":
                    break;

                case "修改":
                    break;

                case "删除":
                    Delete(row);
                    break;
            }
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton4_Click(object sender, EventArgs e)
        {
            var text = this.uiTextBox1.Text;
           
            DataSet ds = StoreService.SelectLike(text);
            this.dataGridView1.DataSource = ds.Tables[0];

        }

        public void Delete(int row)
        {

            var storeId = Convert.ToInt32(this.dataGridView1.Rows[row].Cells["Column2"].Value);
            int v = StoreService.DeleteOne(storeId);
            if (v > 0)
            {
                MessageBox.Show("删除成功");
                DataSet ds = StoreService.SelectAll();
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            var count = this.dataGridView1.SelectedRows.Count;
            Debug.WriteLine(count);
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                var text = Convert.ToInt32(this.dataGridView1.Rows[i].Cells["Column2"].Value);
                list.Add(text);
            }

            int v = StoreService.Delete(list,count);
            if (v > 0)
            {
                MessageBox.Show("删除成功");
                DataSet ds = StoreService.SelectAll();
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
