using System;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int cedulas, soma, centena, dezena, unidade, aux, aux2, cont_dez = 0, cont_vinte = 0,
                cont_cinquenta = 0, cont_um = 0,cont_dois= 0,cont_cinco = 0;
            Console.WriteLine("Valor do saque:");
            cedulas = int.Parse(Console.ReadLine());
            aux = cedulas;
            soma = cedulas / 100;
            
            centena = soma * 100;
            dezena = aux - centena;
           
            aux2 = dezena;
            aux = dezena/ 10;
            dezena = aux * 10;
            unidade= aux2 - dezena;
       

            cedulas = dezena;
        
  bloco:
            if (cedulas == 10)
                {
                    cont_dez = 1;

                }
                if (cedulas == 20)
                {
                    cont_vinte = 1;

                }
                if (cedulas == 30)
                {
                    cont_vinte = 1;
                    cont_dez = 1;


                }
                if (cedulas == 40)
                {
                    cont_vinte = 2;


                }
            
            if (cedulas >= 50)
            {
                cont_cinquenta = 1;
                cedulas = dezena - 50;
                goto bloco;

            }
            // divisão da unidade.
            bloco2:
            if (unidade == 1) { cont_um = 1; }
            if (unidade == 2) { cont_dois = 1; }
            if (unidade == 3) { cont_dois = 1; cont_um = 1; }
            if (unidade == 4) { cont_dois = 2; }
            if (unidade == 5) { cont_cinco = 1; }
            if (unidade > 5)
            {
                cont_cinco = 1;
                unidade = unidade-5;
                goto bloco2;
            }
            
            Console.WriteLine(soma + " nota(s) de R$ 100,00");
            Console.WriteLine(cont_cinquenta + " nota(s) de R$ 50,00 ");
            Console.WriteLine(cont_vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(cont_dez + " nota(s) de R$ 10,00 ");
            Console.WriteLine( cont_cinco+ " nota(s) de R$ 5,00 ");
            Console.WriteLine(cont_dois+" nota(s) de R$ 2,00 ");
            Console.WriteLine(cont_um+" nota(s) de R$ 1,00 ");
            Console.ReadKey();

        }
    }
}
