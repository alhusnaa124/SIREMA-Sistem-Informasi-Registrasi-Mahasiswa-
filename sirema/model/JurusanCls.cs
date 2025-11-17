using sirema.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.model
{
    internal class JurusanCls
    {
        //atribut
        private string _kode_jurusan;
        private string _nama_jurusan;

        KoneksiCls koneksi;
        DataTable temp;
        string Query;

        //constructor
        public JurusanCls() {
            _kode_jurusan = "";
            _nama_jurusan = "";

            koneksi = new KoneksiCls();
            temp = new DataTable();
            Query = "";
        }

        //properti
        public string Kode_jurusan
        {
            set {_kode_jurusan = value;}
            //get hanya untuk menampilkan
            //get {  return _kode_jurusan;}
        }

        public string Nama_jurusan
        {
            set { _nama_jurusan = value; }
        }

        //method untuk cek apakah kodenya sudah pernah ada atau belum
        public bool apakahAda(string kode)
        {
            bool cek =false;
            Query = "select * from jurusan where kode_jurusan='"+kode+"'";

            temp = koneksi.eksekusiQuery(Query);
            if(temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public int simpanData()
        {
            int result = -1;

            Query="insert into jurusan values('"+_kode_jurusan+"', '"+
                _nama_jurusan+"')";

            try
            {
                result=koneksi.eksekusiNonQuey(Query);
                if (result < 0)
                {
                    throw new Exception("Data GAgal Di simpan");
                }
            }catch(Exception ex) { }

            return result;
        }
        public int ubahData( string kode)
        {
            int result = -1;

            Query = "update jurusan set nama_jurusan ='" + _nama_jurusan + "' " +
                "where kode_jurusan ='" + kode + "'";

            try
            {
                result = koneksi.eksekusiNonQuey(Query);
                if (result < 0)
                {
                    throw new Exception("Data GAgal Di ubah");
                }
            }
            catch (Exception ex) { }

            return result;
        }
        public int hapusData(string kode)
        {
            int result = -1;

            Query = "delete from jurusan where kode_jurusan ='"+kode+"'";

            try
            {
                result = koneksi.eksekusiNonQuey(Query);
                if (result < 0)
                {
                    throw new Exception("Data Gagal Di hapus");
                }
            }
            catch (Exception ex) { }

            return result;
        }

        public DataTable tampilkanSemua()
        {
            Query = "select * from jurusan";

            return koneksi.eksekusiQuery(Query);
        }

        public string buatKode()
        {
            string kode = "";
            int result = -1;
            Query = "SELECT IFNULL(MAX(kode_jurusan),0) +1 AS kode FROM jurusan";
            temp=koneksi.eksekusiQuery(Query);
            if(temp.Rows.Count > 0)
            {
                foreach(DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }
                if (result > 0 && result < 10)
                {
                    kode="0"+result.ToString();
                }else if (result >= 10 && result < 100)
                {
                    kode=result.ToString();
                }
            }
            return kode;
        }

        public DataTable CariDgNama(string nama)
        {
            Query = " select * from jurusan where nama_jurusan like '" + nama + "%'";

            return koneksi.eksekusiQuery(Query);
        }
    }
}
