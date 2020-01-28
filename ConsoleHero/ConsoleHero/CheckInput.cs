using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleHero
{
    class CheckInput
    {
        static char teclaDigitada;
        public Musica musicaAtual;
        public static int acertos = 0;

        public CheckInput(Musica novaMusica)
        {
            musicaAtual = novaMusica;
        }

        public void verTecla()
        {

            while (true)
            {
                if (Program.guitarra[Program.guitarra.GetLength(0) - 1, 0] != '|' || Program.guitarra[Program.guitarra.GetLength(0) - 1, 1] != '|' || Program.guitarra[Program.guitarra.GetLength(0) - 1, 2] != '|')
                {
                    Console.Beep(musicaAtual.arrayDeNotas[Program.notaAtual].frequencia, musicaAtual.arrayDeNotas[Program.notaAtual].duracao);
                    if (Console.KeyAvailable == true)
                    {
                        teclaDigitada = Console.ReadKey(true).KeyChar;
                        if (teclaDigitada == musicaAtual.arrayDeNotas[Program.notaAtual].tecla)
                        {
                            Console.SetCursorPosition(20, 20);
                            Console.Write("PERFECT!");
                            acertos++;
                        }
                        else
                        {
                            Console.SetCursorPosition(20, 20);
                            Console.Write("MISS!");
                        }
                        teclaDigitada = '\0';
                    }

                }

            }




        }


    }
}


