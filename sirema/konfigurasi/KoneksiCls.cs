using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sirema.konfigurasi
{
    internal class KoneksiCls:KonfigurasiCLS
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        string link = "server=localhost;port=3306;database=sirema;uid=root;pwd=";

        public KoneksiCls()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex) { }
        }
        void tutupKoneksi()
        {
            conn.Close();
        }

        public override int eksekusiNonQuey(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                result=cmd.ExecuteNonQuery();
            }catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
                
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }
    }
}
