using System;
class Program{
        static void Main(){
            Console.BackgroundColor = ConsoleColor.White; //culoare de fundal
            Console.ForegroundColor = ConsoleColor.Red;   //---------- font 
            Console.Title = "Nebuneala cu clasa Console"; // textul scris in partea
            // de sus a ferestrei 
            Console.WriteLine("Acest text este scris cu rosu!");
            Console.WriteLine("Acest text este scris cu rosu!");
            Console.WriteLine("Acest text este scris cu rosu!");
            Console.WriteLine("Apasati orice spre a continua!");
            Console.Beep(); // scoate un bip
            Console.ReadKey(); 
            Console.Clear(); // curata ecranul
            Console.WriteLine("Am curatat si noi ecranul!:))))");
            Console.WriteLine("Apasati orice");
            Console.ReadKey();
            Console.SetWindowSize(40,40);
            Console.WriteLine("Am  redimensionat  fereastra!");

                Console.WriteLine("Apasati enter");
                Console.ReadKey();
        } }

