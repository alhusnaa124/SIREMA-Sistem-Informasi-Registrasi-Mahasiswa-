using sirema.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirema.antarmuka
{
    public partial class Prodi : Form
    {
        ProdiCls prodi = new ProdiCls();
        public Prodi()
        {
            InitializeComponent();
        }
        void tampilGrid()
        {
            if (cariproditxt.Text == "")
            {
                prodidgv.DataSource = prodi.tampilkanSemua();
            }
            else
            {
                prodidgv.DataSource = prodi.CariDgNama(cariproditxt.Text);
            }

            belangBelang(prodidgv);
        }
        
        void combo()
        {
            
            cbjurusan.Items.Clear();
            DataTable jurusandata = prodi.isicombo();
            cbjurusan.DataSource = jurusandata;

            cbjurusan.DisplayMember = "nama_jurusan";
            cbjurusan.ValueMember = "nama_jurusan";
        }
        

        
        void bersihkan()
        {
            kodetxt.Text = prodi.buatKode();
            namatxt.Clear();
            namatxt.Focus();
            cbjurusan.SelectedIndex = -1;

        }

        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 1)
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                    else
                        kolom.Style.BackColor = Color.LightGray;
                }
            }
        }



        private void Prodi_Load(object sender, EventArgs e)
        {
            bersihkan();
            tampilGrid();
            combo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!prodi.apakahAda(kodetxt.Text))
            {
                prodi.setKode_prodi = kodetxt.Text;
                prodi.setNama_prodi = namatxt.Text;
                prodi.setNama_jurusan = cbjurusan.Text;

                if (prodi.simpanData() > 0)
                {
                    MessageBox.Show("Data Berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                    namatxt.Focus();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Apakah Data akan diubah?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prodi.setKode_prodi = kodetxt.Text; // Set the kode_prodi for update
                    prodi.setNama_prodi = namatxt.Text; // Set the updated nama_prodi
                    prodi.setNama_jurusan = cbjurusan.Text;

                    if (prodi.ubahData(kodetxt.Text) > 0) // Pass the kode_prodi for update
                    {
                        MessageBox.Show("Data Berhasil diubah.",
                            "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilGrid();
                        namatxt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah data.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void prodidgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.prodidgv.Rows[e.RowIndex];
            kodetxt.Text = baris.Cells[0].Value.ToString();
            namatxt.Text = baris.Cells[1].Value.ToString();
            cbjurusan.Text = baris.Cells[2].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
            namatxt.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(kodetxt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus>",
                    "KONFIRMAASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (prodi.hapusData(kodetxt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        bersihkan();
                        namatxt.Focus();
                        tampilGrid();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Data akan diubah?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prodi.setKode_prodi = kodetxt.Text; // Set the kode_prodi for update
                prodi.setNama_prodi = namatxt.Text; // Set the updated nama_prodi
                prodi.setNama_jurusan = cbjurusan.Text;

                if (prodi.ubahData(kodetxt.Text) > 0) // Pass the kode_prodi for update
                {
                    MessageBox.Show("Data Berhasil diubah.",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                    namatxt.Focus();
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cariproditxt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }
    }
}
