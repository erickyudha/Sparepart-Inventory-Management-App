
namespace UTS_PV
{
    partial class MainForm
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
            this.mainListView = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nama_barang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.hargaAddBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stokAddBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.namaAddBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kodeAddBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.hargaEditBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stokEditBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.namaEditBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kodeEditBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.dbSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainListView
            // 
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.kode,
            this.nama_barang,
            this.stok,
            this.harga});
            this.mainListView.FullRowSelect = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(12, 39);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(526, 399);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.SelectedIndexChanged += new System.EventHandler(this.mainListView_SelectedIndexChanged);
            // 
            // num
            // 
            this.num.Text = "No";
            this.num.Width = 40;
            // 
            // kode
            // 
            this.kode.Text = "Kode";
            // 
            // nama_barang
            // 
            this.nama_barang.Text = "Nama Barang";
            this.nama_barang.Width = 271;
            // 
            // stok
            // 
            this.stok.Text = "Stok";
            this.stok.Width = 45;
            // 
            // harga
            // 
            this.harga.Text = "Harga";
            this.harga.Width = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manajemen Inventori Sparepart - PT.AUTOMOTIF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.hargaAddBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.stokAddBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.namaAddBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.kodeAddBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(545, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Item";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(162, 165);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Tambah";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // hargaAddBox
            // 
            this.hargaAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.hargaAddBox.Location = new System.Drawing.Point(83, 137);
            this.hargaAddBox.Name = "hargaAddBox";
            this.hargaAddBox.Size = new System.Drawing.Size(154, 20);
            this.hargaAddBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Harga";
            // 
            // stokAddBox
            // 
            this.stokAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.stokAddBox.Location = new System.Drawing.Point(83, 109);
            this.stokAddBox.Name = "stokAddBox";
            this.stokAddBox.Size = new System.Drawing.Size(154, 20);
            this.stokAddBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok";
            // 
            // namaAddBox
            // 
            this.namaAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.namaAddBox.Location = new System.Drawing.Point(83, 59);
            this.namaAddBox.Multiline = true;
            this.namaAddBox.Name = "namaAddBox";
            this.namaAddBox.Size = new System.Drawing.Size(154, 44);
            this.namaAddBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama\r\nbarang";
            // 
            // kodeAddBox
            // 
            this.kodeAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodeAddBox.Location = new System.Drawing.Point(83, 31);
            this.kodeAddBox.Name = "kodeAddBox";
            this.kodeAddBox.Size = new System.Drawing.Size(154, 20);
            this.kodeAddBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plusBtn);
            this.groupBox2.Controls.Add(this.minBtn);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Controls.Add(this.hargaEditBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stokEditBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.namaEditBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.kodeEditBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(545, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Item";
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(211, 109);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(26, 23);
            this.plusBtn.TabIndex = 11;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.Location = new System.Drawing.Point(179, 109);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(26, 23);
            this.minBtn.TabIndex = 10;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(81, 165);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Hapus";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(162, 165);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // hargaEditBox
            // 
            this.hargaEditBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.hargaEditBox.Location = new System.Drawing.Point(83, 137);
            this.hargaEditBox.Name = "hargaEditBox";
            this.hargaEditBox.Size = new System.Drawing.Size(154, 20);
            this.hargaEditBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // stokEditBox
            // 
            this.stokEditBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.stokEditBox.Location = new System.Drawing.Point(83, 109);
            this.stokEditBox.Name = "stokEditBox";
            this.stokEditBox.Size = new System.Drawing.Size(90, 20);
            this.stokEditBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stok";
            // 
            // namaEditBox
            // 
            this.namaEditBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.namaEditBox.Location = new System.Drawing.Point(83, 59);
            this.namaEditBox.Multiline = true;
            this.namaEditBox.Name = "namaEditBox";
            this.namaEditBox.Size = new System.Drawing.Size(154, 44);
            this.namaEditBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nama\r\nbarang";
            // 
            // kodeEditBox
            // 
            this.kodeEditBox.Enabled = false;
            this.kodeEditBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kodeEditBox.Location = new System.Drawing.Point(83, 31);
            this.kodeEditBox.Name = "kodeEditBox";
            this.kodeEditBox.Size = new System.Drawing.Size(154, 20);
            this.kodeEditBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kode";
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(707, 7);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(81, 27);
            this.reportBtn.TabIndex = 10;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // dbSettings
            // 
            this.dbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbSettings.Location = new System.Drawing.Point(614, 7);
            this.dbSettings.Name = "dbSettings";
            this.dbSettings.Size = new System.Drawing.Size(87, 27);
            this.dbSettings.TabIndex = 11;
            this.dbSettings.Text = "DB Settings";
            this.dbSettings.UseVisualStyleBackColor = true;
            this.dbSettings.Click += new System.EventHandler(this.dbSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbSettings);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainListView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventori Sparepart - PT. AUTOMOTIF";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader kode;
        private System.Windows.Forms.ColumnHeader nama_barang;
        private System.Windows.Forms.ColumnHeader stok;
        private System.Windows.Forms.ColumnHeader harga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox hargaAddBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stokAddBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namaAddBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kodeAddBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox hargaEditBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stokEditBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox namaEditBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kodeEditBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button dbSettings;
    }
}

