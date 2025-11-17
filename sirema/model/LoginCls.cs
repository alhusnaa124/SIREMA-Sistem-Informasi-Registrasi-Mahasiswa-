using sirema.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.model
{
    internal class LoginCls
    {
        //atribut
        private string _userid;
        private string _password;
        //private string _nama_pengguna;
        //private string _status;

        KoneksiCls koneksi;
        DataTable temp;
        string Query;

        //constructor
        public LoginCls()
        {
            _userid = "";
            _password = "";
            //_nama_pengguna = "";
            //_status = "";

            koneksi = new KoneksiCls();
            temp = new DataTable();
            Query = "";
        }

        //properti
        public string Userid
        {
            set { _userid = value; }
            //get hanya untuk menampilkan
            //get {  return _kode_jurusan;}
        }

        public string Password
        {
            set { _password = value; }
        }
        //method
        public bool apakahAda(string id, string password)
        {
            bool cek = false;
            Query = "SELECT * FROM pengguna WHERE user_id = '" + id + 
                "' AND password = '" + password + "'";

            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public string ambilnamaPengguna(string id, string pass)
        {
            string nama = "";
            Query = "select nama_pengguna from pengguna " +
                "where user_id='" + id + "' and password = '" + pass + "'";
            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    nama = row[0].ToString();
                }
            }
            return nama;
        }

    }
}
