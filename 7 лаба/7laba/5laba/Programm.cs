using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _5laba
{
    class Programm
    {
        static void Main(string[] args)
        {
            try
            {
                ProgrammList programmlist = new ProgrammList();
                News news = new News(25, 1990);
                news.Rating = 7;
                news.Author = "Andrey";
                Film film = new Film(130, 2012);
                film.Author = "Tarantino";
                film.Rating = 6;
                Cartoon cartoon = new Cartoon(90, 2016);
                cartoon.Author = "Koffin";
                cartoon.Rating = 9;
                FeatureFilm featurefilm = new FeatureFilm(120, 2012);
                featurefilm.Author = "Asimov";
                featurefilm.Rating = 8;
                programmlist.Add(news);
                programmlist.Add(film);
                //programmlist.Del(news);
                //programmlist.Del(news);
                //programmlist.Add(cartoon);
                //programmlist.Add(cartoon);
                programmlist.Add(cartoon);
                programmlist.Add(featurefilm);
                Console.WriteLine();
                programmlist.show();
                Controller.FindFilm(programmlist);
                Controller.Time(programmlist);
                //Debug.Assert(programmlist == null, "Debug.Assert test");
                int abc = 200000;
                Debug.Assert(abc == 10, "Ошибка");
            }
            catch (RatingException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка:" + ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArrayIsFull ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка:" + ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            catch (TotalTimeException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка:" + ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArrayIsEmpty ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка:" + ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            catch (ElementDoesNotExist ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка:" + ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Программа завершилась");
            }
        }
    }
}

