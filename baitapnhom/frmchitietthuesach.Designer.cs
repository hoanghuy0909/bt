namespace baitapnhom
{
    partial class frmchitietthuesach
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
            this.lblmathue = new System.Windows.Forms.Label();
            this.txtmathue = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lblmasach = new System.Windows.Forms.Label();
            this.txtmatinhtrang = new System.Windows.Forms.TextBox();
            this.lblmatinhtrang = new System.Windows.Forms.Label();
            this.txtdatra = new System.Windows.Forms.TextBox();
            this.lbldatra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmathue
            // 
            this.lblmathue.AutoSize = true;
            this.lblmathue.Location = new System.Drawing.Point(41, 13);
            this.lblmathue.Name = "lblmathue";
            this.lblmathue.Size = new System.Drawing.Size(46, 13);
            this.lblmathue.TabIndex = 0;
            this.lblmathue.Text = "Mã thuê";
            // 
            // txtmathue
            // 
            this.txtmathue.Location = new System.Drawing.Point(98, 13);
            this.txtmathue.Name = "txtmathue";
            this.txtmathue.Size = new System.Drawing.Size(134, 20);
            this.txtmathue.TabIndex = 1;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(98, 51);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(134, 20);
            this.txtmasach.TabIndex = 3;
            // 
            // lblmasach
            // 
            this.lblmasach.AutoSize = true;
            this.lblmasach.Location = new System.Drawing.Point(41, 51);
            this.lblmasach.Name = "lblmasach";
            this.lblmasach.Size = new System.Drawing.Size(48, 13);
            this.lblmasach.TabIndex = 2;
            this.lblmasach.Text = "Mã sách";
            // 
            // txtmatinhtrang
            // 
            this.txtmatinhtrang.Location = new System.Drawing.Point(354, 13);
            this.txtmatinhtrang.Name = "txtmatinhtrang";
            this.txtmatinhtrang.Size = new System.Drawing.Size(130, 20);
            this.txtmatinhtrang.TabIndex = 5;
            // 
            // lblmatinhtrang
            // 
            this.lblmatinhtrang.AutoSize = true;
            this.lblmatinhtrang.Location = new System.Drawing.Point(279, 13);
            this.lblmatinhtrang.Name = "lblmatinhtrang";
            this.lblmatinhtrang.Size = new System.Drawing.Size(69, 13);
            this.lblmatinhtrang.TabIndex = 4;
            this.lblmatinhtrang.Text = "Mã tình trạng";
            // 
            // txtdatra
            // 
            this.txtdatra.Location = new System.Drawing.Point(354, 51);
            this.txtdatra.Name = "txtdatra";
            this.txtdatra.Size = new System.Drawing.Size(130, 20);
            this.txtdatra.TabIndex = 7;
            // 
            // lbldatra
            // 
            this.lbldatra.AutoSize = true;
            this.lbldatra.Location = new System.Drawing.Point(297, 51);
            this.lbldatra.Name = "lbldatra";
            this.lbldatra.Size = new System.Drawing.Size(36, 13);
            this.lbldatra.TabIndex = 6;
            this.lbldatra.Text = "Đã trả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathue,
            this.masach,
            this.matinhtrang,
            this.datra});
            this.dataGridView1.Location = new System.Drawing.Point(44, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 186);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mathue
            // 
            this.mathue.DataPropertyName = "mathue";
            this.mathue.HeaderText = "Mã thuê";
            this.mathue.Name = "mathue";
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // matinhtrang
            // 
            this.matinhtrang.DataPropertyName = "matinhtrang";
            this.matinhtrang.HeaderText = "Mã tình trạng";
            this.matinhtrang.Name = "matinhtrang";
            // 
            // datra
            // 
            this.datra.DataPropertyName = "datra";
            this.datra.HeaderText = "Đã trả";
            this.datra.Name = "datra";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(44, 309);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(128, 309);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(222, 309);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(313, 309);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 12;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(409, 309);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmchitietthuesach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 344);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdatra);
            this.Controls.Add(this.lbldatra);
            this.Controls.Add(this.txtmatinhtrang);
            this.Controls.Add(this.lblmatinhtrang);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.lblmasach);
            this.Controls.Add(this.txtmathue);
            this.Controls.Add(this.lblmathue);
            this.Name = "frmchitietthuesach";
            this.Text = "Chi tiết thuê sách";
            this.Load += new System.EventHandler(this.frmchitietthuesach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmathue;
        private System.Windows.Forms.TextBox txtmathue;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label lblmasach;
        private System.Windows.Forms.TextBox txtmatinhtrang;
        private System.Windows.Forms.Label lblmatinhtrang;
        private System.Windows.Forms.TextBox txtdatra;
        private System.Windows.Forms.Label lbldatra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn datra;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnthoat;
    }
}

