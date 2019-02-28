using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pv03_1700964_Hasya_GP.Model
{
    class Mahasiswa
    {
        public Mahasiswa(int id, string nim, string nama)
        {
            Id = id;
            Nim = nim;
            Nama = nama; 
        }

        public Mahasiswa()
        {

        }

        public int Id { get; set; }
        public string Nim { get; set; }
        public string Nama { get; set; }
    }
}
