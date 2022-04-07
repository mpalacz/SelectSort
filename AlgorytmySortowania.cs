using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    class AlgorytmySortowania
    {
        // deklaracja metody SelectSort
        public void SelectSort(ref float[] T)
        {
            int k;
            float ElementPomocniczy;
            // logiczny "podział" tablicy do sortowania
            for (int i = 0; i < T.Length; i++)
            {
                /* 
                 * tutaj jest prawdziwy niezmiennik obliczeń
                 * T[0] <= ... <= T[i-1]
                 * ustalenie indeksu dla pierwszego elementu w tablicy nieuporządkowanej
                 */
                k = i;
                for (int j = i + 1; j < T.Length; j++)
                    // sprawdzenie, czy T[k] jest większy od elementu T[j]
                    if (T[k] > T[j])
                        k = j; // okazało się, że j-ty element jest mniejszy od k
                               // tutaj "pod indeksem" k będzie najmniejszy element z tablicy nieuporządkowanej
                               // wymieniamy k-ty element z elementem i-tym
                ElementPomocniczy = T[i];
                T[i] = T[k];
                T[k] = ElementPomocniczy;
            }
            // tutaj będzie spełniony niezmiennik obliczeń: T[0] <= T[1] <= ... <= T[T.Lenght - 1]
        }
        public int SelectSort(ref float[] T, int n)
        {
            int k;
            float ElementPomocniczy;
            int LicznikOperacjiDominujących = 0;
            // logiczny "podział" tablicy do sortowania
            for (int i = 0; i < n; i++)
            {
                /* 
                 * tutaj jest prawdziwy niezmiennik obliczeń
                 * T[0] <= ... <= T[i-1]
                 * ustalenie indeksu dla pierwszego elementu w tablicy nieuporządkowanej
                 */
                k = i;
                for (int j = i + 1; j < n; j++)
                {
                    LicznikOperacjiDominujących++;
                    // sprawdzenie, czy T[k] jest większy od elementu T[j]
                    if (T[k] > T[j]) // operacja dominująca, która decyduje o czasie sortowania
                        k = j; // okazało się, że j-ty element jest mniejszy od k
                }
                // tutaj "pod indeksem" k będzie najmniejszy element z tablicy nieuporządkowanej
                // wymieniamy k-ty element z elementem i-tym
                ElementPomocniczy = T[i];
                T[i] = T[k];
                T[k] = ElementPomocniczy;
            }
            // tutaj będzie spełniony niezmiennik obliczeń: T[0] <= T[1] <= ... <= T[T.Lenght - 1]
            // zwrócenie licznika opercji dominujących
            return LicznikOperacjiDominujących;
        }
        // deklaracja metody QuickSort
        static public ushort QuickSort(ref float[] T, ushort d, ushort g)
        {
            // deklaracje lokalne
            ushort licznik = 0;
            ushort i = d;
            ushort j = g;
            float PrzestawianyElement;
            // wylosowanie elementu przedziału tablicy na dwie części
            float x = T[(d + g) / 2];
            // indeks "wylosowanego" elementu
            int s = (d + g) / 2;
            // "przestawianie porządkujące" elementów tablicy względem elementu X
            do
            {
                // uruchomienie lewego analizatora
                while (T[i] < X)
                {
                    i++;
                    licznik++;
                }
                while (T[j] > X)
                {
                    j--;
                    licznik++;
                }
                // oba analizatory skończyły swoją pracę
                // czyli musimy wymienić elementy tablicy z pozycji i oraz j
                if (i <= j)
                {
                    PrzestawianyElement = T[i];
                    T[i] = T[j];
                    T[j] = PrzestawianyElement;
                    // musimy przesunąć indeksy dla obydwu analizatorów
                    i++;
                    j--;
                }
            } while (i < j);
            // rekurencyjne wywołanie algorytmu QuickSort z sumowanych operacji
            if (d < j)
                licznik += QuickSort(ref T, d, j);
            if (i < g)
                licznik += QuickSort(ref T, i, g);
            return licznik;
        }
    }
}
