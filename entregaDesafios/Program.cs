using System;

namespace entregaDesafios
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        /*/ 
        Tipo de entradada 4 -8.
        Saida e a soma dos dois valores.
        /*/
        public void Desafio1(){
            string[] valores = Console.ReadLine().Split();
            int a, b, x;
            a = Convert.ToInt32(valores[0]);
            b = Convert.ToInt32(valores[1]);

            x = a+b; //complete o código de acordo com o cálculo esperado
 
            Console.WriteLine("X = {0}",x);
        }   
        /*/
        Verificar com o operador if e o metodo de string Legnth
        o tamanho do texto e compara com se existe menos ou mais
        de 140 caracteres.
        /*/
        public void Desafio2(){
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
         

            if(v.Length <= 140){
            Console.WriteLine("TWEET");
            }
            else{
            Console.WriteLine("MUTE");
            }
        }
        /*/
        Entra com duas notas referente a uma avaliação
        Entrada do tipo Double de 0 a 10
        verificar media das duas notas dividindo por 2
        /*/
        public void Desafio3(){
            double nota = 0;
            int qtdIgual = 0;
            double soma = 0;
            Console.WriteLine();
            while (qtdIgual != 2) 
            {               
                nota = Convert.ToDouble(Console.ReadLine());
                if (  (nota >= 0) && (nota <= 10) )   //complete a condicional
                {
                    qtdIgual ++;
                    soma = soma + nota ;
                }else
                {
                    Console.WriteLine("nota invalida");
                }
                
            }
            Console.WriteLine("media = {0:0.00}", (  soma /2)); //insira a variavel correta
            
        }


    }
}
