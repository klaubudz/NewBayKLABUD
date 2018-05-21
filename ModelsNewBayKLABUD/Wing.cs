using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsNewBayKLABUD
{
    public class Wing
    {
        public Wing(int power, int shield, string name)
        {
            Power = power;
            Shield = shield;
            Name = name;
        }

        public int Id { get; set; }
        public int Power { get; set; }
        public int Shield { get; set; }
        public string Name { get; set; }
    }
}
