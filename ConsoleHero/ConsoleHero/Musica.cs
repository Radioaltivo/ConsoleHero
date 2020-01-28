using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHero
{
    class Musica
    {
        public string nome;
        public Nota[] arrayDeNotas;
        public int tempo;

        static int 
            A1=55, As1=58, B1=62, C1=33, Cs1=35, D1=37, Ds1=39, E1=41, F1=11, Fs1=46, G1=49, Gs1=52,
            A2=110, As2=117, B2=123, C2=65, Cs2=69, D2=73, Ds2=39, E2=82, F2=87, Fs2=93, G2=98, Gs2=104,
            A3=220, As3=233, B3=247, C3=131, Cs3=139, D3=147, Ds3=156, E3=165, F3=175, Fs3=185, G3=196, Gs3=208,
            A4=440, As4=466, B4=494, C4=262, Cs4=277, D4=294, Ds4=311, E4=330, F4=349, Fs4=370, G4=392, Gs4=415,
            A5=880, As5=932, B5=988, C5=523, Cs5=554, D5=587, Ds5=622, E5=659, F5=698, Fs5=740, G5=784, Gs5=831,
            A6=1760, As6=1865, B6=1976, C6=1046, Cs6=1109, D6=1175, Ds6=1245, E6=1319, F6=1397, Fs6=1480, G6=1568, Gs6=1661,
            A7=3520, As7=3729, B7=3951, C7=2093, Cs7=2217, D7=2349, Ds7=2489, E7=2637, F7=2794, Fs7=2960, G7=3136, Gs7=3322,
            A8=7040, As8=7459, B8=7902, C8=4186, Cs8=4435, D8=4699, Ds8=4978, E8=5274, F8=5588, Fs8=5920, G8=6272, Gs8=6645;

        public Musica(int novotempo, Nota[] novoArrayDeNotas, string novoNome)
        {
            nome = novoNome;
            tempo = novotempo;
            arrayDeNotas = novoArrayDeNotas;
        }

       public static Nota[] arraySweetChild = new Nota[]
           {


             new Nota(Cs5, 266,1, 'g'),new Nota(Cs6, 266, 1, 'h'), new Nota(Gs6, 266, 1, 'y'),
             new Nota(Fs6, 266, 1, 'g'), new Nota(Fs7, 266, 0, 'h'), new Nota(Gs6, 266, 2, 'y'),
             new Nota(F7, 266, 2, 'g'), new Nota(Gs6, 266, 1, 'h'), new Nota(Cs5, 266,1, 'g'),new Nota(Cs6, 266, 1, 'h'), new Nota(Gs6, 266, 1, 'y'),
            new Nota(Fs6, 266, 1, 'g'), new Nota(Fs7, 266, 0, 'h'), new Nota(Gs6, 266, 2, 'y'),
             new Nota(F7, 266, 2, 'g'), new Nota(Gs6, 266, 1, 'h'), new Nota(Cs5, 266,1, 'g'),new Nota(Cs6, 266, 1, 'h'), new Nota(Gs6, 266, 1, 'y'),
             new Nota(Fs6, 266, 1, 'g'), new Nota(Fs7, 266, 0, 'h'), new Nota(Gs6, 266, 2, 'y'),
             new Nota(F7, 266, 2, 'g'), new Nota(Gs6, 266, 1, 'h'), new Nota(Cs5, 266,1, 'g'),new Nota(Cs6, 266, 1, 'h'), new Nota(Gs6, 266, 1, 'y'),
             new Nota(Fs6, 266, 1, 'g'), new Nota(Fs7, 266, 0, 'h'), new Nota(Gs6, 266, 2, 'y'),
             new Nota(F7, 266, 2, 'g'), new Nota(Gs6, 266, 1, 'h'), new Nota(Cs5, 266,1, 'g'),new Nota(Cs6, 266, 1, 'h'), new Nota(Gs6, 266, 1, 'y'),
             new Nota(Fs6, 266, 1, 'g'), new Nota(Fs7, 266, 0, 'h'), new Nota(Gs6, 266, 2, 'y'),
             new Nota(F7, 266, 2, 'g'), new Nota(Gs6, 266, 1, 'h'), new Nota(Cs5, 266,1, 'g'),new Nota(Cs6, 266, 1, 'h'), new Nota(Gs6, 266, 1, 'y'),
             new Nota(Fs6, 266, 1, 'g'), new Nota(Fs7, 266, 0, 'h'), new Nota(Gs6, 266, 2, 'y'),
             new Nota(F7, 266, 2, 'g'), new Nota(Gs6, 266, 1, 'h') };

        public static Nota[] arrayPsychoKiller = new Nota[]
        {
            new Nota(A5, 125, 1, 'b'), new Nota(A5, 125, 1, '|'), new Nota(A5, 125, 1, 'b'), new Nota(A5, 125, 1, '|'),
            new Nota(A5, 125, 1, 'b'), new Nota(A5, 125, 1, '|'), new Nota(A5, 125, 1, 'b'), new Nota(A5, 125, 1, '|'),
            new Nota(A5, 125, 1, 'b'), new Nota(A5, 125, 1, '|'), new Nota(A5, 125, 1, 'b'),new Nota(A5, 125, 1, '|'),
            new Nota(E4, 125, 1, 'b'), new Nota (F4, 125, 0, 'v'), new Nota(G4
                , 250, 1, 'g'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'),new Nota(A4, 125, 1, '|'),
            new Nota(E3, 125, 1, 'b'), new Nota (F3, 125, 0, 'v'), new Nota(G3, 250, 1, 'g'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'),new Nota(A4, 125, 1, '|'),
            new Nota(E3, 125, 1, 'b'), new Nota (F3, 125, 0, 'v'), new Nota(G3, 250, 1, 'g'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'),
            new Nota(A4, 125, 1, 'b'), new Nota(A4, 125, 1, '|'), new Nota(A4, 125, 1, 'b'),new Nota(A4, 125, 1, '|'),
            new Nota(E3, 125, 1, 'b'), new Nota (F3, 125, 0, 'v'), new Nota(G3, 250, 1, 'g')
        };

        public static Nota[] array7Element = new Nota[]
       {
            new Nota(C7,266,1, 'g'),new Nota(As6, 266, 1, 'h'), new Nota(C7,266,1, 'h'),new Nota(As6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(As6, 266, 1, 'h'),
            new Nota(Gs6,266,1, 'h'),new Nota(G6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(F6, 266, 1, 'h'), new Nota(Ds6,266,1, 'g'),new Nota(F6, 266, 1, 'h'),
            new Nota(F7,266,1, 'g'),new Nota(C7, 266, 1, 'h'), new Nota(As6,266,1, 'h'),new Nota(C7, 266, 1, 'h'),new Nota(C7,266,1, 'g'),new Nota(As6, 266, 1, 'h'),
           new Nota(C7,266,1, 'h'),new Nota(As6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(As6, 266, 1, 'h'),
            new Nota(Gs6,266,1, 'h'),new Nota(G6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(F6, 266, 1, 'h'), new Nota(Ds6,266,1, 'g'),new Nota(F6, 266, 1, 'h'),
            new Nota(F7,266,1, 'g'),new Nota(C7, 266, 1, 'h'), new Nota(As6,266,1, 'h'),new Nota(C7, 266, 1, 'h'), new Nota(C7,266,1, 'g'),new Nota(As6, 266, 1, 'h'),
           new Nota(C7,266,1, 'h'),new Nota(As6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(As6, 266, 1, 'h'),
            new Nota(Gs6,266,1, 'h'),new Nota(G6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(F6, 266, 1, 'h'), new Nota(Ds6,266,1, 'g'),new Nota(F6, 266, 1, 'h'),
            new Nota(F7,266,1, 'g'),new Nota(C7, 266, 1, 'h'), new Nota(As6,266,1, 'h'),new Nota(C7, 266, 1, 'h'), new Nota(C7,266,1, 'g'),new Nota(As6, 266, 1, 'h'),
           new Nota(C7,266,1, 'h'),new Nota(As6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(As6, 266, 1, 'h'),
            new Nota(Gs6,266,1, 'h'),new Nota(G6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(F6, 266, 1, 'h'), new Nota(Ds6,266,1, 'g'),new Nota(F6, 266, 1, 'h'),
            new Nota(F7,266,1, 'g'),new Nota(C7, 266, 1, 'h'), new Nota(As6,266,1, 'h'),new Nota(C7, 266, 1, 'h'), new Nota(C7,266,1, 'g'),new Nota(As6, 266, 1, 'h'),
           new Nota(C7,266,1, 'h'),new Nota(As6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(As6, 266, 1, 'h'),
            new Nota(Gs6,266,1, 'h'),new Nota(G6, 266, 1, 'h'), new Nota(Gs6,266,1, 'h'),new Nota(F6, 266, 1, 'h'), new Nota(Ds6,266,1, 'g'),new Nota(F6, 266, 1, 'h'),
            new Nota(F7,266,1, 'g'),new Nota(C7, 266, 1, 'h'), new Nota(As6,266,1, 'h'),new Nota(C7, 266, 1, 'h')
       };




    }
}

