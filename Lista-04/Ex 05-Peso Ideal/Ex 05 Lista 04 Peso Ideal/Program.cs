using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05_Lista_04_Peso_Ideal
{
    class Program
    {
        static void Main(string[] args)
        {   int sexo;
            double altura;

            Console.WriteLine("Informe o sexo do usuário: 1) Masculino 2)Feminino");
            sexo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a altura do usuário:");
            altura = Convert.ToDouble(Console.ReadLine());

            if (sexo == 1)
            {
                Console.WriteLine("Peso ideal:{0}", (altura*72.7) - 58);
            }

            if (sexo == 2)
            {
                Console.WriteLine("Peso Ideal: {0}", (altura*62.1) - 44.7);
            }

            Console.ReadKey();
        }
    }
}
