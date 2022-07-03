using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioPoker.Entities
{
    public class Cards
    {
        public string Pareja { get; set; } = string.Empty;
        public BlindsEnum Blinds { get; set; }
        public PositionEnum Postion { get; set; }
        public VersusEnum Versus { get; set; }
        public ActionEnum HeroAction { get; set; }
        public bool Suited { get; set; }

    }
}
