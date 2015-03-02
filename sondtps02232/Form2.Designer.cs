namespace sondtps02232
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnHTHI = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.lbNTHD = new System.Windows.Forms.Label();
            this.txtTKH = new System.Windows.Forms.TextBox();
            this.lbTKH = new System.Windows.Forms.Label();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.lbMHD = new System.Windows.Forms.Label();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.lvwhoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnHTHI
            // 
            this.btnHTHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTHI.Location = new System.Drawing.Point(525, 129);
            this.btnHTHI.Name = "btnHTHI";
            this.btnHTHI.Size = new System.Drawing.Size(120, 36);
            this.btnHTHI.TabIndex = 29;
            this.btnHTHI.Text = "Hiển thị";
            this.btnHTHI.UseVisualStyleBackColor = true;
            this.btnHTHI.Click += new System.EventHandler(this.btnHTHI_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(353, 129);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(120, 36);
            this.btnSUA.TabIndex = 28;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(184, 129);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(120, 36);
            this.btnXOA.TabIndex = 27;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // lbNTHD
            // 
            this.lbNTHD.AutoSize = true;
            this.lbNTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNTHD.Location = new System.Drawing.Point(332, 55);
            this.lbNTHD.Name = "lbNTHD";
            this.lbNTHD.Size = new System.Drawing.Size(118, 16);
            this.lbNTHD.TabIndex = 22;
            this.lbNTHD.Text = "Ngày tạo hóa đơn:";
            // 
            // txtTKH
            // 
            this.txtTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKH.Location = new System.Drawing.Point(112, 52);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(133, 22);
            this.txtTKH.TabIndex = 20;
            // 
            // lbTKH
            // 
            this.lbTKH.AutoSize = true;
            this.lbTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKH.Location = new System.Drawing.Point(9, 55);
            this.lbTKH.Name = "lbTKH";
            this.lbTKH.Size = new System.Drawing.Size(107, 16);
            this.lbTKH.TabIndex = 19;
            this.lbTKH.Text = "Tên khách hàng:";
            // 
            // txtMHD
            // 
            this.txtMHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMHD.Location = new System.Drawing.Point(112, 17);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(133, 22);
            this.txtMHD.TabIndex = 18;
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMHD.Location = new System.Drawing.Point(9, 20);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(82, 16);
            this.lbMHD.TabIndex = 17;
            this.lbMHD.Text = "Mã hóa đơn:";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHEM.Location = new System.Drawing.Point(12, 129);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(120, 36);
            this.btnTHEM.TabIndex = 16;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // lvwhoadon
            // 
            this.lvwhoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwhoadon.FullRowSelect = true;
            this.lvwhoadon.GridLines = true;
            this.lvwhoadon.Location = new System.Drawing.Point(45, 205);
            this.lvwhoadon.Name = "lvwhoadon";
            this.lvwhoadon.Size = new System.Drawing.Size(581, 174);
            this.lvwhoadon.TabIndex = 135;
            this.lvwhoadon.UseCompatibleStateImageBehavior = false;
            this.lvwhoadon.View = System.Windows.Forms.View.Details;
            this.lvwhoadon.SelectedIndexChanged += new System.EventHandler(this.lvwhoadon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã hóa đơn";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Khách hàng";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày tạo hóa đơn";
            this.columnHeader5.Width = 166;
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaylap.Location = new System.Drawing.Point(466, 55);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(142, 22);
            this.dtpNgaylap.TabIndex = 136;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 391);
            this.Controls.Add(this.dtpNgaylap);
            this.Controls.Add(this.lvwhoadon);
            this.Controls.Add(this.btnHTHI);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.lbNTHD);
            this.Controls.Add(this.txtTKH);
            this.Controls.Add(this.lbTKH);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.lbMHD);
            this.Controls.Add(this.btnTHEM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHTHI;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Label lbNTHD;
        private System.Windows.Forms.TextBox txtTKH;
        private System.Windows.Forms.Label lbTKH;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.ListView lvwhoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
    }
}