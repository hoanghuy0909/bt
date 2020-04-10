namespace baitapnhom
{
    partial class frmchitiettrasach
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
            this.lblmatra = new System.Windows.Forms.Label();
            this.txtmatra = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lblmasach = new System.Windows.Forms.Label();
            this.txtmavipham = new System.Windows.Forms.TextBox();
            this.lblmavipham = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mavipham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmatra
            // 
            this.lblmatra.AutoSize = true;
            this.lblmatra.Location = new System.Drawing.Point(12, 12);
            this.lblmatra.Name = "lblmatra";
            this.lblmatra.Size = new System.Drawing.Size(41, 13);
            this.lblmatra.TabIndex = 0;
            this.lblmatra.Text = "Mã Trả";
            // 
            // txtmatra
            // 
            this.txtmatra.Location = new System.Drawing.Point(61, 12);
            this.txtmatra.Name = "txtmatra";
            this.txtmatra.Size = new System.Drawing.Size(147, 20);
            this.txtmatra.TabIndex = 1;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(61, 52);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(147, 20);
            this.txtmasach.TabIndex = 3;
            // 
            // lblmasach
            // 
            this.lblmasach.AutoSize = true;
            this.lblmasach.Location = new System.Drawing.Point(7, 55);
            this.lblmasach.Name = "lblmasach";
            this.lblmasach.Size = new System.Drawing.Size(48, 13);
            this.lblmasach.TabIndex = 2;
            this.lblmasach.Text = "Mã sách";
            // 
            // txtmavipham
            // 
            this.txtmavipham.Location = new System.Drawing.Point(279, 12);
            this.txtmavipham.Name = "txtmavipham";
            this.txtmavipham.Size = new System.Drawing.Size(172, 20);
            this.txtmavipham.TabIndex = 5;
            // 
            // lblmavipham
            // 
            this.lblmavipham.AutoSize = true;
            this.lblmavipham.Location = new System.Drawing.Point(210, 15);
            this.lblmavipham.Name = "lblmavipham";
            this.lblmavipham.Size = new System.Drawing.Size(62, 13);
            this.lblmavipham.TabIndex = 4;
            this.lblmavipham.Text = "Mã vi phạm";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(279, 52);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(172, 20);
            this.txtthanhtien.TabIndex = 7;
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Location = new System.Drawing.Point(214, 55);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(58, 13);
            this.lblthanhtien.TabIndex = 6;
            this.lblthanhtien.Text = "Thành tiền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matra,
            this.masach,
            this.mavipham,
            this.thanhtien});
            this.dataGridView1.Location = new System.Drawing.Point(10, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 231);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // matra
            // 
            this.matra.DataPropertyName = "matra";
            this.matra.HeaderText = "Mã trả";
            this.matra.Name = "matra";
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // mavipham
            // 
            this.mavipham.DataPropertyName = "mavipham";
            this.mavipham.HeaderText = "Mã vi phạm";
            this.mavipham.Name = "mavipham";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(473, 199);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 66);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(473, 291);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(582, 242);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(582, 199);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 12;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(582, 291);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmchitiettrasach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 339);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.lblthanhtien);
            this.Controls.Add(this.txtmavipham);
            this.Controls.Add(this.lblmavipham);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.lblmasach);
            this.Controls.Add(this.txtmatra);
            this.Controls.Add(this.lblmatra);
            this.Name = "frmchitiettrasach";
            this.Text = "Chi tiết trả sách";
            this.Load += new System.EventHandler(this.frmchitiettrasach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmatra;
        private System.Windows.Forms.TextBox txtmatra;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label lblmasach;
        private System.Windows.Forms.TextBox txtmavipham;
        private System.Windows.Forms.Label lblmavipham;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matra;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavipham;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnthoat;
    }
}