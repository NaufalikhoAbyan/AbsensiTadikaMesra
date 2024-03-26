using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsensiTadikaMesraProd
{
    public class Kelas
    {
        public int id { get; set; }
        public string name { get; set; }

        public Kelas(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
