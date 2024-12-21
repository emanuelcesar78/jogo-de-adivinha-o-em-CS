using System;



namespace ache_o_numero
{
    class Numero
    {
        private static Random numeroAleatorio = new Random();
        public int GeranumeroAleatorio(){
            
            return numeroAleatorio.Next(0,10);
        }

        
    }

    class Jogador
    {
        public int Jogada()
        {
            int numero_jogador;
            Console.Write("Digite sua Jogada: ");
            numero_jogador = Convert.ToInt32(Console.ReadLine());

            return numero_jogador;
        }
    } 

    class Jogo 
    {
        public static void jogo()
        {
            Jogador jogador = new Jogador();
            Numero numero = new Numero();

            int tentativas = 1;
            while (true)
            {
               int maquina = numero.GeranumeroAleatorio();
               int Jogador = jogador.Jogada();
                
                if (Jogador < maquina){
                    Console.WriteLine("\nNumero errado:"+jogador+"\nmuito abaixo do esperado");
                    tentativas++;
                }
                
                else if(Jogador > maquina)
                {
                    Console.WriteLine("\nNumero errado: "+Jogador+"\nmuito acima do desejado ");
                    tentativas++;
                }
                
                else 
                {
                    Console.WriteLine("\nNumero certo!:"+jogador+"\nTentativas:"+tentativas);
                    break;
                }
            }
             Console.ReadKey();
            
        }

    }
    class Reproduzir_codigo:Jogo
    {
        static void Main()
        {
            jogo();
        }
    }
}