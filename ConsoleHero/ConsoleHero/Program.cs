using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleHero
{
    class Program
    {
        public static int notaAtual;
        static Musica[] arrayDeMusicas = new Musica[] {
            new Musica(2128, Musica.arraySweetChild, "Guns n' Roses - Sweet Child O' Mine"),
            new Musica(2000, Musica.arrayPsychoKiller, "Talking Heads - Psycho Killer"),
            new Musica(2128, Musica.array7Element, "Vitas - 7, the Element")};


        public static char[,] guitarra = new char[8, 3];
        static List<int> listaDePontos = new List<int>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("BEM VINDO A CONSOLE HERO!!!!!!\nVOCÊ ESTÁ PRONTO PARA SER UM ROCK STAR?");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Digite o número da música que deseja tocar:");
                for (int i = 0; i < arrayDeMusicas.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + arrayDeMusicas[i].nome);
                }
                try
                {
                    Jogar(arrayDeMusicas[Int32.Parse(Console.ReadLine()) - 1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite Um número válido!");
                }
                Console.ReadLine();
                Console.Clear();
                MostrarPlacar();
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Jogar Novamente?<s/n>");
                if (Console.ReadLine().ToLower()=="n")
                {
                    break;
                }
            }
        }

        public static void Jogar(Musica musicaEscolhida)
        {
            Console.WriteLine("VOCÊ ESCOLHEU " + musicaEscolhida.nome + "! ESTÁ PREPARADO?");
            Console.ReadLine();
            Console.Clear();
            CheckInput check = new CheckInput(musicaEscolhida);
            Thread paralelo = new Thread(new ThreadStart(check.verTecla));
            paralelo.Start();

            ResetarGuitarra();
            for (int i = 0; i < musicaEscolhida.arrayDeNotas.Length; i++)
            {
                for (int coluna = 0; coluna < guitarra.GetLength(0); coluna++)
                {

                    if (i - coluna >= 0)
                    {
                        guitarra[coluna, musicaEscolhida.arrayDeNotas[i - coluna].corda] = musicaEscolhida.arrayDeNotas[i - coluna].tecla;
                        DesenharGuitarra();
                    }

                }
                System.Threading.Thread.Sleep(musicaEscolhida.tempo / 8);
                ResetarGuitarra();
                Console.Clear();
                DesenharGuitarra();
                notaAtual++;
            }
            paralelo.Abort();
            Console.SetCursorPosition(0, 18);
            int score = (CheckInput.acertos) * 100 / (musicaEscolhida.arrayDeNotas.Length);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("SCORE: " + score + "%");
            listaDePontos.Add(score);
            notaAtual = 0;
        }


        public static void DesenharGuitarra()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < guitarra.GetLength(0); i++)
            {

                for (int j = 0; j < guitarra.GetLength(1); j++)
                {
                    Console.Write(guitarra[i, j]);
                }
                Console.Write("\n");
            }

        }

        public static void ResetarGuitarra()
        {
            Console.SetCursorPosition(20, 20);
            Console.Write("                      ");
            Console.SetCursorPosition(21, 21);
            Console.Write("                      ");
            for (int i = 0; i < guitarra.GetLength(0); i++)
            {
                for (int j = 0; j < guitarra.GetLength(1); j++)
                {
                    guitarra[i, j] = '|';
                }
            }
        }

        public static void MostrarPlacar()
        {
            Console.WriteLine("LEADERBOARD:");
            for (int i = 0; i < listaDePontos.Count; i++)
            {
                Console.WriteLine("Jogador " + (i + 1) + "------------" + listaDePontos[i] + "%");
            }
        }
    }

}





