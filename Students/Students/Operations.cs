using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Operations
    {
        public static string ime1;
        public static string prezime1;
        public static string gpa1;
        public static string redak;
        public static int id = 0;
        public static int id1 = 0;
        public static int brojac = 1;
        public static string a;
        public static List<string> studenti = new List<string>();

        static public void operacija()
        {
            do
            {
                System.Console.Write(brojac++ + ". " + "Operation: ");
                a = Console.ReadLine();
                if (String.Compare(a, "enlist", true) == 0)
                {
                    id++;
                    ime();
                }
                else
                {
                    if (String.Compare(a, "display", true) == 0)
                    {
                        var asc = from s in studenti
                                  orderby s ascending
                                   select s;
                        int i = 1;
                        foreach (string s in asc)
                        {
                            if(i == 1)
                            {
                            Console.WriteLine(brojac++ + ". " + i + ". " + s);
                            i++;
                            }
                            else
                            {
                               Console.WriteLine("    " + i + ". " + s);
                               i++;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(brojac++ + ". " + "Operation non-existing, please use appropriate operation");
                        operacija();
                    }
                }
            } while (a == "Display");

        }

        static public void ime()
        {
            Console.WriteLine(brojac++ + ". " + "Student");
            System.Console.Write(brojac++ + ". " + "First name: ");
            a = Console.ReadLine();
            if (!string.IsNullOrEmpty(a))
                {
                    ime1 = a;
                    prezime();
                }
                else
                {
                    Console.WriteLine(brojac++ + ". " + "You need to insert value.");
                    ime();
                }

        }

        static public void prezime()
        {
            System.Console.Write(brojac++ + ". " + "Last name: ");
                a = Console.ReadLine();
                if (!string.IsNullOrEmpty(a))
                {
                    prezime1 = a;
                    gpa();
                }
                else
                {
                    Console.WriteLine(brojac++ + ". " + "You need to insert value.");
                    prezime();
                }
        }

        static public void gpa()
        {
            System.Console.Write(brojac++ + ". " + "GPA: ");
                string line = Console.ReadLine();
                Decimal value;
                    if (!string.IsNullOrEmpty(line))
                    {
                     if (Decimal.TryParse(line, out value))
                     {
                        gpa1 = line;

                        redak = (prezime1 + ", " + ime1 + " - " + gpa1);


                        if (id == 1)
                        {
                            studenti.Add(redak);
                        }
                        else
                        {
                            studenti.Insert(id - 1, redak);
                        }

                        operacija();
                    }
                    else
                    {
                        Console.WriteLine(brojac++ + ". " + "You need to insert numerical value.");
                        gpa();
                    }

                }
                else
                {
                    Console.WriteLine(brojac++ + ". " + "You need to insert value.");
                    gpa();
                }
        }
    }
}
