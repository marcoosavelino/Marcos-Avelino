using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Array_String
{
    class Program
    {
        public void ExibirArrayString (string[] pArrayString)
        {
            for (int i = 0; i < pArrayString.Length; i++)
            {
                Console.WriteLine("{0}ª String = {1}", i + 1, pArrayString[i]);
            }
        }
        public void ExibirArrayBool (bool[] pArrayString)
        {
            for (int i = 0; i < pArrayString.Length; i++)
            {
                Console.WriteLine("{0}ª Bool = {1}", i + 1, pArrayString[i]);
            }
        }
        public bool[] TestePalindrome (string[] pArrayString)
        {
            bool[] arrayPalindrome = new bool[pArrayString.Length];
            for (int i = 0; i < pArrayString.Length; i++)
            {
                char[] arrayChar = pArrayString[i].ToLower().ToArray();
                Array.Reverse(arrayChar);
                string palavraReverse = new string(arrayChar);
                arrayPalindrome[i] = palavraReverse.Equals(pArrayString[i].ToLower()) ? true : false;
            }

            return arrayPalindrome;
        }
        static void Main(string[] args)
        {
            string[] palavrasArray = { "Teste", "Arara", "Aula", "Ovo", "SOs" };
            Program MeusMetodos = new Program();
            MeusMetodos.ExibirArrayString(palavrasArray);
            MeusMetodos.ExibirArrayBool(MeusMetodos.TestePalindrome(palavrasArray));


            Console.ReadKey();

        }
    }
}
