using Core;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
using System.Xml.Linq;

namespace ConsoleApp
{
    internal class Program
    {      
        static void Main(string[] args)
        {
          Classroom[] classroom = new Classroom[0];
            int studentId = 1;
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Classroom yarat");
                Console.WriteLine("2.Telebe yarat");
                Console.WriteLine("3.Butun Telebeleri ekrana cixart");
                Console.WriteLine("4..Secilmis sinifdeki telebeleri ekrana cixart");
                Console.WriteLine("5.Telebe sil ");
                Console.WriteLine("6.Programdan cix");

                Console.WriteLine("Secim et");
                string choice= Console.ReadLine();
                
                switch(choice)
                {
                    case "1":
                      
                        
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":


                }
            }
           static void Createclass(Classroom[]classrooms)
            {
                Console.WriteLine("Sinif yaradin");
                string name = Console.ReadLine();

                if(!Helper.Classnamechecker(name))
                {
                        Console.WriteLine("Ad duzgun deyil");
                        return;
                   
                }
                Console.WriteLine("Backend ucun 1, Fromntend ucun 2 daxil edin");
                if (Enum.TryParse(Console.ReadLine(), out Core.Type type))
                {
                    Console.WriteLine("duzgun sinif tipi daxil edin");
                    return;
                }
                Array.Resize(ref classrooms, classrooms.Length + 1);
                classrooms[classrooms.Length - 1] = classrooms[0];
                Console.WriteLine("Classroom ugurla yaradildi");

            }
           
        }
         static void Createstudent(Classroom[]classrooms, ref int studentid)
        {
            if (classrooms.Length == 0)
            {
                Console.WriteLine("Ilk once classroom yaratmalisiniz");
                return;
            }
            Console.WriteLine("Telebe adi daxil edin");
            string name= Console.ReadLine();

            if (!Helper.Namechecker(name))
            {
                Console.WriteLine("Adi duzgun daxil edin");
                return;
            }
            Console.WriteLine("Telebe soyadi daxil edin");
            string surname=Console.ReadLine();
            if (!Helper.Surnamechecker(surname))
            {
                Console.WriteLine("Soyadi duzgun faxil edin");
                return;
            }

        }
    }
}