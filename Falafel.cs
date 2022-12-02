using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_2022
{
    internal class Falafel
    {
        public Falafel(int ID)
        {
            _Id = ID;
        }
        private readonly int _Id;

        public int Id
        {
            get { return _Id; }

        }

        public int numfalafelballs { get; set; }

    }
}
