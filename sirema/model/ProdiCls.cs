using sirema.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.model
{
    internal class ProdiCls
    {
        //atribut
        private string _kode_prodi;
        private string _nama_prodi;
        private string _nama_jurusan;

        KoneksiCls koneksi;
        DataTable temp;
        string Query;

        //constructor
        public ProdiCls()
        {
            _kode_prodi = "";
            _nama_prodi = "";
            _nama_jurusan = "";

            koneksi = new KoneksiCls();
            temp = new DataTable();
            Query = "";
        }

        //properti
        public string setKode_prodi
        {
            set { _kode_prodi = value; }

        }
        public string setNama_prodi
        {
            set { _nama_prodi = value; }
        }

        public string setNama_jurusan
        {
            set { _nama_jurusan = value; }
        }

        //method untuk cek apakah kodenya sudah pernah ada atau belum
        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "select * from prodi where kode_prodi='" + kode + "'";

            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public int simpanData()
        {
            int result = -1;


            string kodeJurusan = GetKodeJurusan(_nama_jurusan);


            if (string.IsNullOrEmpty(kodeJurusan))
            {

                throw new Exception("Kode Jurusan not found for selected nama_jurusan.");
            }

            Query = "INSERT INTO prodi (kode_prodi, nama_prodi, kode_jurusan) VALUES ('" + _kode_prodi + "', '" + _nama_prodi + "', '" + kodeJurusan + "')";

            try
            {
                result = koneksi.eksekusiNonQuey(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan.");
                }
            }
            catch (Exception e)
            {

            }
            return result;
        }
        private string GetKodeJurusan(string namaJurusan)
        {
            string kodeJurusan = string.Empty;

            string query = "SELECT kode_jurusan FROM jurusan WHERE nama_jurusan = '" + namaJurusan + "'";
            DataTable result = koneksi.eksekusiQuery(query);

            if (result.Rows.Count > 0)
            {
                kodeJurusan = result.Rows[0]["kode_jurusan"].ToString();
            }

            return kodeJurusan;
        }
        public int ubahData(string kode)
        {
            int result = -1;

            string kodeJurusan = GetKodeJurusan(_nama_jurusan);

            try
            {
                if (string.IsNullOrEmpty(kodeJurusan))
                {
                    throw new Exception("Kode Jurusan Tidak Ditemukan.");
                }

                Query = "UPDATE prodi SET nama_prodi = '" + _nama_prodi + "', kode_jurusan = '" + kodeJurusan + "' WHERE kode_prodi = '" + kode + "'";

                result = koneksi.eksekusiNonQuey(Query);

                if (result < 0)
                {
                    throw new Exception("Gagal Mengubah.");
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }
        public int hapusData(string kode)
        {
            int result = -1;
            Query = "delete from prodi where kode_prodi='" +
                kode + "'";

            try
            {
                result = koneksi.eksekusiNonQuey(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data.");
                }
            }
            catch (Exception e) { }
            return result;
        }

        public DataTable tampilkanSemua()
        {
            Query = "select a.kode_prodi, a.nama_prodi, b.nama_jurusan from prodi a, jurusan b where a.kode_jurusan = b.kode_jurusan";
            return koneksi.eksekusiQuery(Query);
        }

        public string buatKode()
        {
            string kode = "";
            int nilai = 0;
            Query = "SELECT IFNULL (MAX(kode_prodi),0)+1 AS kode FROM prodi";
            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nilai = Convert.ToInt32(data[0]);
                }
                if (nilai > 0 && nilai < 10)
                {
                    kode = "0" + nilai.ToString();
                }
                else if (nilai >= 10 && nilai < 100)
                {
                    kode = nilai.ToString();
                }
            }
            return kode;
        }

        public DataTable CariDgNama(string nama)
        {
            Query = "SELECT a.kode_prodi, a.nama_prodi, b.nama_jurusan FROM prodi a JOIN jurusan b ON a.kode_jurusan = b.kode_jurusan WHERE a.nama_prodi LIKE '%" + nama + "%' OR b.nama_jurusan LIKE '%" + nama + "%'";

            return koneksi.eksekusiQuery(Query);
        }
        public string ambilKodeDgNama(string nama)
        {
            string kode = "";
            Query = "select kode_prodi from prodi where nama_prodi ='" + nama + "'";
            temp = koneksi.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    kode = data[0].ToString();

                }
            }
            return kode;

        }
        public DataTable isicombo()
        {
            Query = "SELECT nama_jurusan FROM jurusan";
            return koneksi.eksekusiQuery(Query);
        }
    }
}
