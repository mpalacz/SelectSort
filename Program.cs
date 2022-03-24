using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    class Program
    {
        const int MaxRozmiarN = 100;
        const int PrzyrostRozmiaruTablic = 5;
        const int PróbaBadawcza = 100;
        const float DolnaGranicaPrzedziału = 50;
        const float GórnaGranicaPrzedziału = 500;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // schemat zapisu głównej części analizatora algorytmów sortowania
            for (int l = 1; l < MaxRozmiarN; l += PrzyrostRozmiaruTablic)
            {
                // powtarzanie badanie dla l-tego rozmiaru tablicy
                for(int k = 0; k < PróbaBadawcza;)
                {
                    // wypełnienie tablicy do sortowania wartościami losowymi
                    for (int i = 0; i <= l; i++)
                        T[i] = rnd.NextDouble() * (GórnaGranicaPrzedziału - DolnaGranicaPrzedziału) + DolnaGranicaPrzedziału;
                    // wybieramy algorytm i go wywołujemy, a uzyskane wyniki przechowujemy dla dalszych potrzeb
                    AlgorytmySortowania.selectSort(ref Task, l);
                }
            }
        }
    }
}
