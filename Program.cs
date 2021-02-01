using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// predej funkci pole a funkce pricte ke kazde bunce 10 a vrati pole
// pozn je treba deklarovat funkci s polovovu deklaraci - to me dojebalo
namespace FunctionArrayInArrayOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };
            int pocetPrvkuPole = array1.Length;
            int[] array2 = new int[pocetPrvkuPole];

            array2 = Navyseni(array1);

            // vypis navyseneho pole
            for (int i = 0; i < pocetPrvkuPole; i++)
            {
                Console.WriteLine(array2[i]);
            }
            // vypis puvodniho pole - nic se nedojebalo
            for (int j = 0; j < pocetPrvkuPole; j++)
            {
                Console.WriteLine(array1[j]);
            }
            Console.ReadLine();        
        }
        static int[] Navyseni(int[] array1F)
        {
            int pocetPrvkuPoleF = array1F.Length;
            int[] array2F = new int[pocetPrvkuPoleF];

            for (int a = 0; a < (pocetPrvkuPoleF); a++)
            {
                array2F[a] = array1F[a] + 10;
            }
            return array2F;
        }       
    }
}
