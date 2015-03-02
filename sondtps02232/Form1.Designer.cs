namespace sondtps02232
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTHEM = new System.Windows.Forms.Button();
            this.lbMSP = new System.Windows.Forms.Label();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.lbTSP = new System.Windows.Forms.Label();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.lbGSP = new System.Windows.Forms.Label();
            this.lbMT = new System.Windows.Forms.Label();
            this.txtGSP = new System.Windows.Forms.TextBox();
            this.txtMT = new System.Windows.Forms.TextBox();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnHTHI = new System.Windows.Forms.Button();
            this.lvwsanpham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnTHEM
            // 
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHEM.Location = new System.Drawing.Point(15, 134);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(120, 36);
            this.btnTHEM.TabIndex = 1;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // lbMSP
            // 
            this.lbMSP.AutoSize = true;
            this.lbMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSP.Location = new System.Drawing.Point(12, 25);
            this.lbMSP.Name = "lbMSP";
            this.lbMSP.Size = new System.Drawing.Size(92, 16);
            this.lbMSP.TabIndex = 2;
            this.lbMSP.Text = "Mã sản phẩm:";
            this.lbMSP.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMSP
            // 
            this.txtMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSP.Location = new System.Drawing.Point(115, 22);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(133, 22);
            this.txtMSP.TabIndex = 3;
            // 
            // lbTSP
            // 
            this.lbTSP.AutoSize = true;
            this.lbTSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTSP.Location = new System.Drawing.Point(12, 60);
            this.lbTSP.Name = "lbTSP";
            this.lbTSP.Size = new System.Drawing.Size(97, 16);
            this.lbTSP.TabIndex = 4;
            this.lbTSP.Text = "Tên sản phẩm:";
            // 
            // txtTS
            // 
            this.txtTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS.Location = new System.Drawing.Point(115, 57);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(133, 22);
            this.txtTS.TabIndex = 5;
            // 
            // lbGSP
            // 
            this.lbGSP.AutoSize = true;
            this.lbGSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGSP.Location = new System.Drawing.Point(309, 25);
            this.lbGSP.Name = "lbGSP";
            this.lbGSP.Size = new System.Drawing.Size(94, 16);
            this.lbGSP.TabIndex = 7;
            this.lbGSP.Text = "Giá sản phẩm:";
            // 
            // lbMT
            // 
            this.lbMT.AutoSize = true;
            this.lbMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMT.Location = new System.Drawing.Point(309, 63);
            this.lbMT.Name = "lbMT";
            this.lbMT.Size = new System.Drawing.Size(44, 16);
            this.lbMT.TabIndex = 8;
            this.lbMT.Text = "Mô tả:";
            // 
            // txtGSP
            // 
            this.txtGSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSP.Location = new System.Drawing.Point(431, 25);
            this.txtGSP.Name = "txtGSP";
            this.txtGSP.Size = new System.Drawing.Size(127, 22);
            this.txtGSP.TabIndex = 10;
            // 
            // txtMT
            // 
            this.txtMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMT.Location = new System.Drawing.Point(431, 63);
            this.txtMT.Name = "txtMT";
            this.txtMT.Size = new System.Drawing.Size(127, 22);
            this.txtMT.TabIndex = 11;
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(187, 134);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(120, 36);
            this.btnXOA.TabIndex = 12;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(356, 134);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(120, 36);
            this.btnSUA.TabIndex = 13;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnHTHI
            // 
            this.btnHTHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTHI.Location = new System.Drawing.Point(528, 134);
            this.btnHTHI.Name = "btnHTHI";
            this.btnHTHI.Size = new System.Drawing.Size(120, 36);
            this.btnHTHI.TabIndex = 14;
            this.btnHTHI.Text = "Hiển thị";
            this.btnHTHI.UseVisualStyleBackColor = true;
            this.btnHTHI.Click += new System.EventHandler(this.button4_Click);
            // 
            // lvwsanpham
            // 
            this.lvwsanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwsanpham.FullRowSelect = true;
            this.lvwsanpham.GridLines = true;
            this.lvwsanpham.Location = new System.Drawing.Point(15, 207);
            this.lvwsanpham.Margin = new System.Windows.Forms.Padding(4);
            this.lvwsanpham.Name = "lvwsanpham";
            this.lvwsanpham.Size = new System.Drawing.Size(670, 218);
            this.lvwsanpham.TabIndex = 144;
            this.lvwsanpham.UseCompatibleStateImageBehavior = false;
            this.lvwsanpham.View = System.Windows.Forms.View.Details;
            this.lvwsanpham.SelectedIndexChanged += new System.EventHandler(this.lvwsanpham_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Sản Phẩm";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Sản Phẩm";
            this.columnHeader3.Width = 189;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá Bán";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mô tả";
            this.columnHeader5.Width = 219;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(697, 439);
            this.Controls.Add(this.lvwsanpham);
            this.Controls.Add(this.btnHTHI);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.txtMT);
            this.Controls.Add(this.txtGSP);
            this.Controls.Add(this.lbMT);
            this.Controls.Add(this.lbGSP);
            this.Controls.Add(this.txtTS);
            this.Controls.Add(this.lbTSP);
            this.Controls.Add(this.txtMSP);
            this.Controls.Add(this.lbMSP);
            this.Controls.Add(this.btnTHEM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản lý hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Label lbMSP;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.Label lbTSP;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.Label lbGSP;
        private System.Windows.Forms.Label lbMT;
        private System.Windows.Forms.TextBox txtGSP;
        private System.Windows.Forms.TextBox txtMT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnHTHI;
        private System.Windows.Forms.ListView lvwsanpham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

