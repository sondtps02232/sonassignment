using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sondtps02232
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<clshanghoa> dsnv = new List<clshanghoa>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            lvwsanpham.Items.Clear();
            DataTable dt = SQLConnection.loadsp();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {

            ListViewItem items = new ListViewItem((lvwsanpham.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[0].ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
            items.SubItems.Add(row.ItemArray[2].ToString());
            items.SubItems.Add(row.ItemArray[3].ToString());
            lvwsanpham.Items.Add(items);
        }


        private void btnTHEM_Click(object sender, EventArgs e)
        {
            bool kt = KT();
            if (kt == true)
            {
                SQLConnection.themsp(txtMSP.Text, txtTS.Text,txtGSP.Text, txtMT.Text);

                clear();

                MessageBox.Show("Nhập hoàn thành", "Thông báo");
            }
        }
       
        private bool KT()
        {
            if (txtMSP.Text == "" || txtTS.Text == "" || txtGSP.Text == "" || txtMT.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }



            return true;


        }
        private void clear()
        {
            txtMSP.Text = "";
            txtTS.Text = "";
            txtGSP.Text = "";
            txtMT.Text = "";

           
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            
            if (lvwsanpham.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
            }
            else
            {
                try
                {
                    DialogResult dialogResuit = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResuit == DialogResult.Yes)
                    {
                        int dem = lvwsanpham.SelectedIndices.Count;
                        for (int i = dem - 1; i >= 0; i--)
                        {
                            int index = lvwsanpham.SelectedIndices[i];
                            string masp = lvwsanpham.Items[index].SubItems[1].Text;
                            SQLConnection.xoasp(masp);
                        }
                        List();
                        clear();
                    }
                }
                catch
                {
                    MessageBox.Show("lỗi");
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwsanpham.SelectedIndices.Count; i++)
            {
                int index = lvwsanpham.SelectedIndices[i];
                SQLConnection.suasp(txtMSP.Text, txtTS.Text, txtGSP.Text, txtMT.Text);

            }
            List();
            clear();
        }

        private void lvwsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwsanpham.SelectedIndices.Count == 1)
            {
                int it = lvwsanpham.SelectedIndices[0];
                txtMSP.Text = lvwsanpham.Items[it].SubItems[1].Text;
                txtTS.Text = lvwsanpham.Items[it].SubItems[2].Text;

                txtGSP .Text = lvwsanpham.Items[it].SubItems[3].Text;
                txtMT.Text = lvwsanpham.Items[it].SubItems[4].Text;
             



            }
        }
        

    }
}
