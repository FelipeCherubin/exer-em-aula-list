using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exerlist
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int mut=1;
            List<int> num = new List<int>();
            List<int> resul = new List<int>();
            string b;
            Console.WriteLine("digite SAIR para sair do programa");
            Console.WriteLine("digite s para pesquisar o resultado das multiplicaçoes");
            do
            {
                b = Console.ReadLine();

                if (b != "*" && b != "sair" && b != "s")
                {
                    num.Add(Convert.ToInt32(b));
                }
                else if (b == "*" )
                {
                    Console.WriteLine("resultado das multiplicaçoes:");
                    foreach (int q in num)
                    {
                        mut *= q;
                    }
                    resul.Add(mut);
                    foreach (int r in resul)
                    {
                            Console.WriteLine(r);
                    }
                    mut = 1;
                    num.Clear();
                    Console.WriteLine("digite os numeros: ");
                }
                else if (b == "s")
                {
                    Console.WriteLine("digite o resultado que voce quer verificar");
                    int c = int.Parse(Console.ReadLine());
                    int f = resul.Find(delegate(int i)
                    {
                        if (i == c)
                        {   
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                        );
                    Console.WriteLine("resultado: {0}", f+" encontrado");
                }                 
            } while (b != "sair");
        }
    }
}
