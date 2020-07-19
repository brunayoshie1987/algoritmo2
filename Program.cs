using System;

namespace Algoritmo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleAcesso controleacesso = new ControleAcesso();
            bool logado= controleacesso.EfetuarLogin();

            if (logado)

                Console.WriteLine("login efetuado com sucesso");


            // Controle de acesso : usuario irá digitar login e senha:::
            //tera 3 tentativas para acertar a senha.

            string login = "Bruna";
            string senha = "123";

            Console.WriteLine("digite seu login");
            string loginDigitado = (Console.ReadLine());

            Console.WriteLine("digite a senha");
           string senhaDigitada = (Console.ReadLine());

            if (loginDigitado == login)
            {
                int count = 0;

                while (count < 3)
               
                {
                    
                    if (senhaDigitada == senha)

                    {
                        Console.WriteLine("digite a senha");
                        _ = (Console.ReadLine());


                        Console.WriteLine("Login efetuado com sucesso");
                        break;

                    }
                    count++;
                }
            }
        }
    }
}

            // Numeros Primos

            //Console.WriteLine("Digite um Limite");

            //int limite = Convert.ToInt32(Console.ReadLine());
            //int[] indices = new int[4];
            //indices[0] = 2;
            //indices[1] = 3;
            //indices[2] = 5;
            //indices[3] = 7;
            //{
            //    bool primo = true;

            //    for (int l = 1; l <= limite;l++)

            //    for (int i = 0; i < 4; i++)
            //    {
            //        int resto = l % indices[i];
            //        if (l != indices[i] && resto == 0)
            //        {
            //            primo = false;
            //            break;

            //        }
            //    }
            //    if (primo == true)
            //        Console.WriteLine("l");

            //else
            //    Console.WriteLine("não é primo");
//        }
//        }
//    }
//}


            

        





            // Calculo IMC

//            Console.WriteLine("digite o seu peso (kg): ");
//            int peso = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("digite a sua altura(m): ");
//          double altura = Convert.ToDouble(Console.ReadLine());

//            double imc = peso / (altura * altura);

//            string resultado = "";


//            if (imc < 17)
//                resultado = "Muito abaixo do peso";

//            if (imc >= 17 && imc <= 18.49)
//                resultado = "abaixo do peso";

//            if (imc >= 18.50 && imc <25)
//                resultado = "peso normal";

//            if (imc >= 25 && imc <= 30)
//                resultado = "acima do peso";

//            if (imc >= 30 && imc <= 35)
//                resultado = "obesidade 1";

//            if (imc >= 35 && imc <= 40)
//                resultado = "obesidade 2 (severa)";

//            if (imc >= 40)
//                resultado = "obesidade 3 (morbida)";

//            Console.WriteLine(resultado);

//        }
//    }
//}
