using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_Lista_01_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = ((nota1 + nota2) / 2);

            if (media >= 6)
            {
                Console.WriteLine("Aluno APROVADO");
            }
            else
            {
                Console.WriteLine("Aluno REPROVADO");
            }
            Console.ReadKey();
        }
        
        
	

	


     
}
}
