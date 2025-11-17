namespace sirema.antarmuka
{
    partial class Prodi
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
            this.label3 = new System.Windows.Forms.Label();
            this.cariproditxt = new System.Windows.Forms.TextBox();
            this.prodidgv = new System.Windows.Forms.DataGridView();
            this.c_kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nama_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nama_jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.namatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kodetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbjurusan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodidgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cari Dengan Nama";
            // 
            // cariproditxt
            // 
            this.cariproditxt.Location = new System.Drawing.Point(70, 207);
            this.cariproditxt.Name = "cariproditxt";
            this.cariproditxt.Size = new System.Drawing.Size(827, 26);
            this.cariproditxt.TabIndex = 24;
            this.cariproditxt.TextChanged += new System.EventHandler(this.cariproditxt_TextChanged);
            // 
            // prodidgv
            // 
            this.prodidgv.AllowUserToAddRows = false;
            this.prodidgv.AllowUserToDeleteRows = false;
            this.prodidgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodidgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_kode,
            this.c_nama_prodi,
            this.c_nama_jurusan});
            this.prodidgv.Location = new System.Drawing.Point(76, 239);
            this.prodidgv.Name = "prodidgv";
            this.prodidgv.ReadOnly = true;
            this.prodidgv.RowHeadersWidth = 62;
            this.prodidgv.RowTemplate.Height = 28;
            this.prodidgv.Size = new System.Drawing.Size(827, 354);
            this.prodidgv.TabIndex = 23;
            this.prodidgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodidgv_CellClick);
            // 
            // c_kode
            // 
            this.c_kode.DataPropertyName = "kode_prodi";
            this.c_kode.HeaderText = "KODE PRODI";
            this.c_kode.MinimumWidth = 8;
            this.c_kode.Name = "c_kode";
            this.c_kode.ReadOnly = true;
            this.c_kode.Width = 150;
            // 
            // c_nama_prodi
            // 
            this.c_nama_prodi.DataPropertyName = "nama_prodi";
            this.c_nama_prodi.HeaderText = "NAMA PRODI";
            this.c_nama_prodi.MinimumWidth = 8;
            this.c_nama_prodi.Name = "c_nama_prodi";
            this.c_nama_prodi.ReadOnly = true;
            this.c_nama_prodi.Width = 150;
            // 
            // c_nama_jurusan
            // 
            this.c_nama_jurusan.DataPropertyName = "nama_jurusan";
            this.c_nama_jurusan.HeaderText = "NAMA JURUSAN";
            this.c_nama_jurusan.MinimumWidth = 8;
            this.c_nama_jurusan.Name = "c_nama_jurusan";
            this.c_nama_jurusan.ReadOnly = true;
            this.c_nama_jurusan.Width = 150;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(731, 117);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 39);
            this.button6.TabIndex = 22;
            this.button6.Text = "TUTUP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(570, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 39);
            this.button5.TabIndex = 21;
            this.button5.Text = "BATAL";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(412, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "HAPUS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(241, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "UBAH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(67, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "SIMPAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "NAMA PRODI";
            // 
            // namatxt
            // 
            this.namatxt.Location = new System.Drawing.Point(244, 39);
            this.namatxt.Name = "namatxt";
            this.namatxt.Size = new System.Drawing.Size(515, 26);
            this.namatxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "KODE PRODI";
            // 
            // kodetxt
            // 
            this.kodetxt.Enabled = false;
            this.kodetxt.Location = new System.Drawing.Point(244, 7);
            this.kodetxt.Name = "kodetxt";
            this.kodetxt.Size = new System.Drawing.Size(216, 26);
            this.kodetxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "NAMA JURUSAN";
            // 
            // cbjurusan
            // 
            this.cbjurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbjurusan.FormattingEnabled = true;
            this.cbjurusan.Location = new System.Drawing.Point(246, 77);
            this.cbjurusan.Name = "cbjurusan";
            this.cbjurusan.Size = new System.Drawing.Size(512, 28);
            this.cbjurusan.TabIndex = 28;
            // 
            // Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 619);
            this.Controls.Add(this.cbjurusan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cariproditxt);
            this.Controls.Add(this.prodidgv);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namatxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodetxt);
            this.Name = "Prodi";
            this.Text = "Prodi";
            this.Load += new System.EventHandler(this.Prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodidgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cariproditxt;
        private System.Windows.Forms.DataGridView prodidgv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namatxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbjurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nama_prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nama_jurusan;
    }
}