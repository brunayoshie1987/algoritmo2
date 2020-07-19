using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo_2
{

    class ControleAcesso
    {

        public string login = "bruna";
        public string senha ="123";

        public bool EfetuarLogin()


        {
            bool retorno = false;
            Console.WriteLine("digite seu login");
            string loginDigitado = Console.ReadLine();

            if (loginDigitado == loginDigitado)

            {
                int count = 0;
                while (count <3)
                {
                    Console.WriteLine("Digite a senha");
                    string senhaDigitada = Console.ReadLine();

                    if(senhaDigitada ==senha)

                    {
                        retorno = true;
                        break;
                    }

                    count++;

                }
            }

            return retorno;
        }
    }
}
