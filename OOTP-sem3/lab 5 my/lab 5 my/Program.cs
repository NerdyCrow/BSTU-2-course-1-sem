using System;

namespace lab_5_my
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                rectangle r1 = new rectangle();
                r1.ShowSizes();
                r1.square();
                Console.WriteLine(r1.ToString());

                circle c1 = new circle();
                c1.square();
                Console.WriteLine(c1.ToString());

                button but1 = new button();
                but1.ToString();
                but1.Print();
                IControle ibut1 = new button();
                ibut1.Print();

                Printer prnt = new Printer();
                prnt.IAmPrinting(but1);




                ////Laba 6
                ///
                textbox tb1 = new textbox();

                triangle t1 = new triangle();
                foreach (var el in t1.infos)
                {
                    Console.WriteLine($"Высота треугольника {el._tp} = {el._h}");
                }


                PS<Controle> ps1 = new PS<Controle>();
                //ps1.Add(but1);
                //ps1.Add(tb1, 3);
                //ps1.Print();
                ps1.ShowCountText();
            }
            catch (Exception1 e)
            {
                LOG.WriteLog(e);
                throw;
            }
            catch (Exception2 e)
            {
                LOG.WriteLog(e);
            }
            finally
            {
                Console.WriteLine("Ok");
            }

            

        }
    }
}
