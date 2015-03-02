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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        List<clskhachhang> dsnv = new List<clskhachhang>();

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            try
            {

                bool kt = KT();
                if (kt == true)
                {
                    SQLConnection.themkhachhang(txtMKH.Text, txtTKH.Text, txtDC.Text, txtSDT.Text,txtGT.Text,dtpNgaylap.Value);

                    clear();

                    MessageBox.Show("Nhập hoàn thành", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }
        private bool KT()
        {
            if (txtMKH.Text == "" || txtTKH.Text == "" || txtDC.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }




            return true;


        }
        private void clear()
        {
            txtMKH.Text = "";
            txtTKH.Text = "";

            txtDC.Text = "";
            txtSDT.Text = "";

        }

        private void btnHTHI_Click(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            lvwkhachhang.Items.Clear();
            DataTable dt = SQLConnection.loadkhachhang();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {



            ListViewItem items = new ListViewItem((lvwkhachhang.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[0].ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
            items.SubItems.Add(row.ItemArray[4].ToString());
            items.SubItems.Add(row.ItemArray[5].ToString());
            items.SubItems.Add(row.ItemArray[3].ToString());
            items.SubItems.Add(row.ItemArray[2].ToString());


            lvwkhachhang.Items.Add(items);

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (lvwkhachhang.SelectedIndices.Count == 0)
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
                        int dem = lvwkhachhang.SelectedIndices.Count;
                        for (int i = dem - 1; i >= 0; i--)
                        {
                            int index = lvwkhachhang.SelectedIndices[i];
                            string makh = lvwkhachhang.Items[index].SubItems[1].Text;
                            SQLConnection.xoakhachhang(makh);
                        }
                        List();
                        clear();
                    }
                }
                catch
                {
                    MessageBox.Show("loi xay ra");
                }

            }
        }

        private void lvwkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvwkhachhang.SelectedIndices.Count == 1)
            {
                int it = lvwkhachhang.SelectedIndices[0];
                txtMKH.Text = lvwkhachhang.Items[it].SubItems[1].Text;
                txtTKH.Text = lvwkhachhang.Items[it].SubItems[2].Text;

                txtDC.Text = lvwkhachhang.Items[it].SubItems[3].Text;
                txtSDT.Text = lvwkhachhang.Items[it].SubItems[4].Text;
                txtGT.Text = lvwkhachhang.Items[it].SubItems[5].Text;
                dtpNgaylap.Text = lvwkhachhang.Items[it].SubItems[6].Text;

            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lvwkhachhang.SelectedIndices.Count; i++)
            {
                int index = lvwkhachhang.SelectedIndices[i];
                SQLConnection.suakh(txtMKH.Text, txtTKH.Text, txtDC.Text, txtSDT.Text, txtGT.Text, dtpNgaylap.Value);

            }
            List();
            clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

                
        
        

        }
    }
