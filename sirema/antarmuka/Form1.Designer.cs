namespace sirema
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
            this.kodetxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namatxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.jurusandgv = new System.Windows.Forms.DataGridView();
            this.c_kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caritxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jurusandgv)).BeginInit();
            this.SuspendLayout();
            // 
            // kodetxt
            // 
            this.kodetxt.Enabled = false;
            this.kodetxt.Location = new System.Drawing.Point(205, 23);
            this.kodetxt.Name = "kodetxt";
            this.kodetxt.Size = new System.Drawing.Size(216, 26);
            this.kodetxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "CEK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "KODE_JURUSAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama_Jurusan";
            // 
            // namatxt
            // 
            this.namatxt.Location = new System.Drawing.Point(205, 79);
            this.namatxt.Name = "namatxt";
            this.namatxt.Size = new System.Drawing.Size(515, 26);
            this.namatxt.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "SIMPAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(205, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "UBAH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(376, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "HAPUS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(534, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 39);
            this.button5.TabIndex = 8;
            this.button5.Text = "BATAL";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(695, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 39);
            this.button6.TabIndex = 9;
            this.button6.Text = "TUTUP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // jurusandgv
            // 
            this.jurusandgv.AllowUserToAddRows = false;
            this.jurusandgv.AllowUserToDeleteRows = false;
            this.jurusandgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jurusandgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jurusandgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_kode,
            this.c_nama});
            this.jurusandgv.Location = new System.Drawing.Point(37, 267);
            this.jurusandgv.Name = "jurusandgv";
            this.jurusandgv.ReadOnly = true;
            this.jurusandgv.RowHeadersWidth = 62;
            this.jurusandgv.RowTemplate.Height = 28;
            this.jurusandgv.Size = new System.Drawing.Size(827, 318);
            this.jurusandgv.TabIndex = 10;
            this.jurusandgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusandgv_CellClick);
            // 
            // c_kode
            // 
            this.c_kode.DataPropertyName = "kode_jurusan";
            this.c_kode.HeaderText = "KODE JURUSAN";
            this.c_kode.MinimumWidth = 8;
            this.c_kode.Name = "c_kode";
            this.c_kode.ReadOnly = true;
            this.c_kode.Width = 150;
            // 
            // c_nama
            // 
            this.c_nama.DataPropertyName = "nama_jurusan";
            this.c_nama.HeaderText = "NAMA JURUSAN";
            this.c_nama.MinimumWidth = 8;
            this.c_nama.Name = "c_nama";
            this.c_nama.ReadOnly = true;
            this.c_nama.Width = 350;
            // 
            // caritxt
            // 
            this.caritxt.Location = new System.Drawing.Point(37, 233);
            this.caritxt.Name = "caritxt";
            this.caritxt.Size = new System.Drawing.Size(827, 26);
            this.caritxt.TabIndex = 11;
            this.caritxt.TextChanged += new System.EventHandler(this.caritxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cari Dengan Nama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caritxt);
            this.Controls.Add(this.jurusandgv);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namatxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kodetxt);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jurusandgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namatxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView jurusandgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nama;
        private System.Windows.Forms.TextBox caritxt;
        private System.Windows.Forms.Label label3;
    }
}

