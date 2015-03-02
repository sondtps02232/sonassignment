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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<clshoadon> dsnv = new List<clshoadon>();

        private void btnTHEM_Click(object sender, EventArgs e)
        {
              bool kt = KT();
            if (kt == true)
            {
                SQLConnection.themhd(txtMHD.Text,txtTKH.Text,dtpNgaylap.Value);

                clear();

                MessageBox.Show("Nhập hoàn thành", "Thông báo");
            }
        }
       
        private bool KT()
        {
            if (txtMHD.Text == "" || txtTKH.Text == "" )
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }



            return true;


        }
        private void clear()
        {
            txtMHD.Text = "";
            
            txtTKH.Text = "";
         

           
        }

        private void btnHTHI_Click(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            lvwhoadon.Items.Clear();
            DataTable dt = SQLConnection.loadhd();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {

            ListViewItem items = new ListViewItem((lvwhoadon.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[0].ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
            items.SubItems.Add(row.ItemArray[2].ToString());
            
            lvwhoadon.Items.Add(items);
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
             if (lvwhoadon.SelectedIndices.Count == 0)
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
                        int dem = lvwhoadon.SelectedIndices.Count;
                        for (int i = dem - 1; i >= 0; i--)
                        {
                            int index = lvwhoadon.SelectedIndices[i];
                            string id_hd = lvwhoadon.Items[index].SubItems[1].Text;
                            SQLConnection.xoahd(id_hd);
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
            for (int i = 0; i < lvwhoadon.SelectedIndices.Count; i++)
            {
                int index = lvwhoadon.SelectedIndices[i];
                SQLConnection.suaHD(txtMHD.Text, txtTKH.Text, dtpNgaylap.Value);

            }
            List();
            clear();
        
        }

        private void lvwhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvwhoadon.SelectedIndices.Count == 1)
            {
                int it = lvwhoadon.SelectedIndices[0];
                txtMHD.Text = lvwhoadon.Items[it].SubItems[1].Text;
                txtTKH.Text = lvwhoadon.Items[it].SubItems[2].Text;

                dtpNgaylap.Text = lvwhoadon.Items[it].SubItems[3].Text;
               




            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        }

        }
    
