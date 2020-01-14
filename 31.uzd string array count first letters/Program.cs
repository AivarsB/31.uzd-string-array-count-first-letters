using System;
using System.Linq;

namespace _31.uzd_string_array_count_first_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Janis", "Juris", "Gatis", "Guntars", "Andris" };

            string[] firstLetters = new string[names.Length];

            int i = 0;

            foreach (var name in names)
            {
                firstLetters[i] = name.Substring(0, 1);
                ++i;
            }

            var resultLetters = firstLetters.Distinct();

            var y = 0;

            foreach (var item in resultLetters)
            {
                for (int x = 0; x < firstLetters.Length; x++)
                {
                    if (item == firstLetters[x])
                    {
                        y++;
                    }
                }

                Console.WriteLine($"{item}={y}");
                y = 0;
            }
        }
    }
}
// Izveidot console aplikāciju. Nodeklarēt string tipa masīvu ar (n) vārdiem. 
// Programmai ir jāsaskaita, cik vārdi sākas ar katru atrasto burtu. 
// Piemēram, mums ir saraksts ar vārdiem Jānis, Juris, Gatis, Gundars, Andris.
// Rezultātā mums ir jāiegūst J=2, G=2, A=1

// Var izmantot List<char>
// List ir metode contains
// Ar to var pārbaudīt vai tāds ir vai nav
// + Listam ir metode Add, kas palīdz dinamiski sarakstam pielikt elementus
// Ir iespēja pārbaudīt vai elements ir, ja tāda sarakstā vēl nav tad pielikt klāt









