using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5laba
{
    class Programm
    {
        static void Main(string[] args)
        {
            TVProgramm[] programms = new TVProgramm[3];

            programms[0] = new News();
            programms[1] = new Cartoon();
            programms[2] = new FeatureFilm();

            programms[0].Duration = 15;

            programms[1].Duration = 90;
            programms[1].Rating = 8;

            programms[2].Duration = 145;
            programms[2].Rating = 6;

            bool a = programms[0] is Film;
            bool b = programms[1] is TVProgramm;
            bool c = programms[2] is Film;

            Console.WriteLine("Элемент массива programms 'News' принадлежит классу Film - " + a);
            Console.WriteLine("Элемент массива programms 'Cartoon' принадлежит классу TVProgramm - " + b);
            Console.WriteLine("Элемент массива programms 'FeatureFilm' принадлежит классу Film - " + c);

            foreach (TVProgramm programm in programms)
            {
                Printer.iAmPrinting(programm);
                programm.ShowProgram();
            }
        }
    }
}
