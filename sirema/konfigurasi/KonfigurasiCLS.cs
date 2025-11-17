using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.konfigurasi
{
    abstract class KonfigurasiCLS
    {
        //method untuk menampilkan instruksi INSERT, UPDATE, DElETE
        public abstract int eksekusiNonQuey(string query);
        //method untuk menampilkan instruksi Select
        public abstract DataTable eksekusiQuery(string query);
    }
}
