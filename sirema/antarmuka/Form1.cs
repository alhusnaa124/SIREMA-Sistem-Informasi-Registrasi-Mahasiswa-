using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirema
{
    using model;
    public partial class Form1 : Form
    {
        JurusanCls jurusan = new JurusanCls();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kodetxt.Text))
            {
                MessageBox.Show("Kode sudah Ada");
            }else
            {
                MessageBox.Show("kode belum ada");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!jurusan.apakahAda(kodetxt.Text))
            {
                jurusan.Kode_jurusan= kodetxt.Text;
                jurusan.Nama_jurusan= namatxt.Text;

                if (jurusan.simpanData()>=0)
                {
                    MessageBox.Show("Data berhasil di simpan. ",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    namatxt.Focus();
                    tampilGrid();
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data tidak valid. ",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    namatxt.Focus();
                }
            }
            else
            {
                if(MessageBox.Show("Yakin data akan di ubah?", "KONFIRMASI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    jurusan.Nama_jurusan= namatxt.Text;
                {
                    if (jurusan.ubahData(kodetxt.Text) >= 0)
                    {
                        MessageBox.Show("Data berhasil di ubah. ",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        namatxt.Focus();
                        tampilGrid();
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak valid. ",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        namatxt.Focus();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kodetxt.Text))
            {
                jurusan.Nama_jurusan = namatxt.Text;

                if (jurusan.ubahData(kodetxt.Text) >= 0)
                {
                    MessageBox.Show("Data berhasil di ubah. ",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    namatxt.Focus();
                    tampilGrid();
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data tidak valid. ",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    namatxt.Focus();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kodetxt.Text))
            {
                if (MessageBox.Show("Yakin data akan di hapus?", "KONFIRMASI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    jurusan.Nama_jurusan = namatxt.Text;
                {
                    if (jurusan.hapusData(kodetxt.Text) >= 0)
                    {
                        MessageBox.Show("Data berhasil di hapus. ",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        namatxt.Focus();
                        tampilGrid();
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak valid. ",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        namatxt.Focus();
                    }
                }

            }
        }

        void tampilGrid()
        {
            if (caritxt.Text == "")
            {
                jurusandgv.DataSource = jurusan.tampilkanSemua();
            }else
            {
                jurusandgv.DataSource= jurusan.CariDgNama(caritxt.Text);
            }
            //jurusandgv.DataSource = jurusan.tampilkanSemua();
            belangBelang(jurusandgv);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tampilGrid();
            bersihkan();
        }

        void bersihkan()
        {
            kodetxt.Text = jurusan.buatKode();
            namatxt.Clear();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void jurusandgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = jurusandgv.Rows[e.RowIndex];
                kodetxt.Text = baris.Cells[0].Value.ToString();
                namatxt.Text = baris.Cells[1].Value.ToString();
                namatxt.SelectAll();
                namatxt.Focus();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                button2.PerformClick();
            }
        }

        void belangBelang(DataGridView grd)
        {
            foreach (DataGridViewRow row in grd.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Index % 2 == 0)
                    {
                        cell.Style.BackColor = Color.LightGray;
                    }else
                    {
                        cell.Style.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        private void caritxt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }
    }
}
