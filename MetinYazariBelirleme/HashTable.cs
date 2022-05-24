using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class HashTable
    {
        public HashLinkedList[] hashTable;
        public HashTable(int size)
        {
            this.hashTable = new HashLinkedList[size];
            
        }
        public void TabloyaEkle(int key, Kelime kelime)
        {
            HashLinkedList eklenecek = new HashLinkedList();
            eklenecek.Data = kelime;
            eklenecek.Key = KeyOlustur(kelime.KelimeSiraNo, kelime.CumleSiraNo);
            
            int hash = (key % 10);
            if (hashTable[hash] == null)
            {

                eklenecek.Next = null;
                hashTable[hash] = eklenecek;
            }
            else
            {

                HashLinkedList temp  = hashTable[hash];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                
                temp.Next = eklenecek;
                eklenecek.Next = null;
            }
        }
        public Kelime KelimeArama(int key)
      {
            int hash = (key % 10);
            if (hashTable[hash] == null)
            {
                return null;
            }
            else
            {
                if (key == hashTable[hash].Key)
                {
                    return hashTable[hash].Data;
                }
                else
                {
                    while (key != hashTable[hash].Key)
                    {
                        if (hashTable[hash].Next != null)
                            hashTable[hash] = hashTable[hash].Next;
                        else
                            return null;
                    }
                    return hashTable[hash].Data;
                }
            }
        }
        public int KeyOlustur(int kelimeNo, int cumleNo)
        {
            string a = kelimeNo.ToString();
            string b = cumleNo.ToString();
            string strKey = b+a;
            int key = Convert.ToInt32(strKey);
            return key;

        }
    }
}
