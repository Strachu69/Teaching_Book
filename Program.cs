using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Test
{
    static void Main()
    {
        int[] tab1 = { 6, 8, 4, 7, 2, 3, 0 };

        var intTablica = new Bable<int[]>(tab1);
    }

}
class Bable<T>
{
    
    public Bable(T value)//statik było
    {
        
        T tablica1 = value;
        int[] tablica=tablica1;



        for (int z = 0; z < tablica.Length; z++)
        {
            for (int i = 0; tablica.Length - 1 > i; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    int t1 = tablica[i];
                    int t2 = tablica[i + 1];
                    tablica[i] = t2;
                    tablica[i + 1] = t1;

                }
            }
        }
       
    }
    void Write(int[] tablica)// statik było
    {
        for (int n = 0; tablica.Length > n; n++)
        {
            string s = tablica[n].ToString();
            Console.WriteLine(s);

        }
        Console.ReadKey();
    }

}
