using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Ghost
    {
        public bool isVulnerable { get; set; }
        public int BonusFactor { get; set; } = 200;

        public void MultipleBonus()
        {
            BonusFactor *= 2;
        }
    }
}
