using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class Heap
    {
        public int currentSize { get; set; }
        public HeapDugumu[] heapKelimeler = new HeapDugumu[100];

        public void YukariTasi(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapKelimeler[index];
            while (index > 0 && heapKelimeler[parent].kelime.Frekans < bottom.kelime.Frekans)
            {
                heapKelimeler[index] = heapKelimeler[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapKelimeler[index] = bottom;
        }
        public bool Insert(Kelime kelime)
        {
            HeapDugumu yeniDugum = new HeapDugumu(kelime);
            heapKelimeler[currentSize] = yeniDugum;
            YukariTasi(currentSize++);
            return true;
        }
        public HeapDugumu RemoveMax()
        {
            HeapDugumu root = heapKelimeler[0];
            heapKelimeler[0] = heapKelimeler[--currentSize];
            AsagiTasi(0);
            return root;
        }
        public void AsagiTasi(int index)
        {
            int buyukCocuk;
            HeapDugumu top = heapKelimeler[index];
            while (index < currentSize / 2)
            {
                int solCocuk = 2 * index + 1;
                int sagcocuk = solCocuk + 1;
                if (sagcocuk < currentSize && heapKelimeler[solCocuk].kelime.Frekans < heapKelimeler[sagcocuk].kelime.Frekans)
                {
                    buyukCocuk = sagcocuk;
                }
                else
                {
                    buyukCocuk = solCocuk;
                }
                if (top.kelime.Frekans >= heapKelimeler[buyukCocuk].kelime.Frekans)
                    break;
                heapKelimeler[index] = heapKelimeler[buyukCocuk];
                index = buyukCocuk;
            }
            heapKelimeler[index] = top;
        }

        public bool IsEmpty()
        {
            return currentSize == 0;
        }

        public Kelime[] Sort(Kelime[] kelimes)
        {
            Heap h = new Heap();
            Kelime[] sorted = new Kelime[kelimes.Length];
            foreach (var item in kelimes)
            {
                h.Insert(item);
            }
            int i = 0;
            while (!h.IsEmpty())
            {
                sorted[i++] = h.RemoveMax().kelime;
            }
            return sorted;
        }
    }
}
