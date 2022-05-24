using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class HeapDugumu
    {
        public Kelime kelime;
        public HeapDugumu sol;
        public HeapDugumu sag;
        public HeapDugumu(Kelime kelime)
        {
            this.kelime = kelime;
            sol = null;
            sag = null;
        }
    }
}
