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
            ProgrammList programmlist = new ProgrammList();
            News news = new News(25, 7, 2019);
            news.Author = "Andrey";
            Film film = new Film(130, 6,2012);
            film.Author = "Tarantino";
            Cartoon cartoon = new Cartoon(90, 8, 2016);
            cartoon.Author = "Koffin";
            FeatureFilm featurefilm = new FeatureFilm(120, 9, 2012);
            featurefilm.Author = "Asimov";


            programmlist.Add(news);
            programmlist.Add(film);
            programmlist.Add(cartoon);
            programmlist.Add(featurefilm);
            Console.WriteLine();
            programmlist.show();
            Controller.FindFilm(programmlist);
            Controller.Time(programmlist);
        }


            
    }
}
