using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generics
{
    class MyBubleGeneric<T>
    {
        private T[] genericTable;
        public MyBubleGeneric(int size)//przyjmuje rozmiar tablicy
        {
            genericTable = new T[size];

        }
        public T genericItem(int index)//metoda pozwala zwrócić dowlny typ danych
        {
            return genericTable[index];
        }
        public void setGenericValue(int index, T value)
        {
            genericTable[index] = value;
        }
        public void BubleAlgorythm()
        {
            for (int z = 0; z < genericTable.Length; z++)
            {
                for (int i = 0; genericTable.Length - 1 > i; i++)
                {
                    if (genericTable[i] > genericTable[i + 1])
                    {
                        int t1 = (int)genericTable[i];
                        int t2 = genericTable[i + 1];
                        genericTable[i] = t2;
                        genericTable[i + 1] = t1;

                    }





                }
            }


        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainTable= { 6, 5, 4, 3, 2, 1, 0 };
            //int e=mainTable.Length;
            MyBubleGeneric<int> intTable = new MyBubleGeneric<int>(mainTable.Length);
            for(int i= 0;i< mainTable.Length; i++)
            {
                intTable.setGenericValue(i, mainTable[i]);
                intTable.

            }

        }
    }

}



