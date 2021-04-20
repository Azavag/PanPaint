using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;

namespace Laba1
{
    [Serializable]
    class InfoForSave
    {
        public List<Figure> ListOfFigures { get; set; }
        public Size SizeOfForm { get; set; }
        public InfoForSave()
        {
                        
        }     
    }
}
