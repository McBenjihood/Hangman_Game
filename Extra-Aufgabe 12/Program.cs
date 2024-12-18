using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extra_Aufgabe_12
{
    internal class Program
    {

        static string solution = RandomWord().ToLower();
        static int tries = 0;
        static char[] SolutionArray = ArrayConvert(solution);
        static bool finished = false;
        static char[] CompleteCharray = ArrayCopy(solution);
        
        static void Main(string[] args)
        {
            bool completed = false;
            bool exit = false;
            
            do 
            {
                do
                {
                    UserInterface(tries);
                    logic();
                    if (tries >= 10) { finished = true;  }
                    if (SolutionArray.SequenceEqual(CompleteCharray)) 
                    { 
                        Console.Clear();
                        finished = true; 
                        completed = true;  
                        string HappyEnd = @"                          
  Du hast               
  das Wort             
  Erraten :)


============
[Y] = Noch eine Runde | [N] = Programm beenden:  ";
                        Console.WriteLine("HANGMAN - THE GAME\n==================\n");
                        Console.WriteLine(HappyEnd);
                        break;
                    }
                    Console.Clear();
                } while (finished == false);
                if (completed == false) 
                { UserInterface(tries); }
                

                string strinput = Console.ReadLine();
                if (strinput.Length == 1)
                {
                    char input = char.ToLower(Convert.ToChar(strinput));
                    
                    switch (input) 
                    {
                        case 'y':
                            Console.Clear();         
                            solution = RandomWord().ToLower();
                            tries = 0;
                            SolutionArray = ArrayConvert(solution);
                            finished = false;
                            break;
                        case 'n': exit = true; break;
                        default:
                            Console.Write("Ungültige Eingabe..."); Console.ReadKey(); Console.Clear() ;
                            break;
                    }

                }
                else { Console.Write("Ungültige Eingabe..."); Console.ReadKey(); Console.Clear();   }

            } while (exit == false);
            Console.WriteLine("\nDanke fürs Spielen :)");
            Environment.Exit(0);
            
                



        }

        static char[] logic() 
        {
            int counter = 0;
            char input = char.ToLower(inputhandling());
            for (int i = 0; i < solution.Length; i++)
            {
                if (input == 'ä')
                { counter--; }
                if (solution[i] == input) 
                {
                    SolutionArray[i] = input;
                }
                if (solution[i] != input)
                {
                    counter++;
                }

            }
            if (counter == solution.Length) { tries++; }
            
            return SolutionArray;
        }


        static char inputhandling() 
        {
            string strinput = Console.ReadLine();
            if (Regex.IsMatch(strinput, "^[a-zA-Z$]")&&strinput.Length==1)
            {
                char input = Convert.ToChar(strinput);
                return input;
            }
            else { Console.Write("Ungültige Eingabe..."); Console.ReadKey(); return 'ä'; }
            

        }

        static void UserInterface(int tries) 
        {
            Console.WriteLine("HANGMAN - THE GAME\n==================\n");

            Dictionary<int, string> hangmanStages = new Dictionary<int, string>
        {
            { 0, @"
               
               
               
               
               
============" },
            { 1, @"
               
               
               
           |    
           |
============" },
            { 2, @"
               
           |
           |
           |
           |
============" },
            { 3, @"
       +---+
           |
           |
           |
           |
============" },
            { 4, @"
       +---+
       |   |
       O   |
           |
           |
============" },
            { 5, @"
       +---+
       |   |
       O   |
       |   |
           |
============" },
            { 6, @"
       +---+
       |   |
       O   |
      /|   |
           |
============" },
            { 7, @"
       +---+
       |   |
       O   |
      /|\  |
           |
============" },
            { 8, @"
       +---+
       |   |
       O   |
      /|\  |
      /    |
============" },
            { 9, @"
       +---+
       |   |
       O   |
      /|\  |
      / \  |
============" },
                { 10, @"
       
       
 Game Over   
      
      
============
[Y] = Noch eine Runde | [N] = Programm beenden:  " }


        };
            

            Console.Write(hangmanStages[tries]);
            if (finished == false)
            {
                Console.Write("\nGesuchtes Wort\t:");
                foreach (char c in SolutionArray)
                {
                    Console.Write(c);
                }
                Console.Write("\nBuchstabe\t:");
            }
        }

        static string RandomWord()
        {
            Dictionary<int, string> Words = new Dictionary<int, string>();

            Words.Add(1, "Elefant");
            Words.Add(2, "Banane");
            Words.Add(3, "Pudding");
            Words.Add(4, "Quatsch");
            Words.Add(5, "Socken");
            Words.Add(6, "Hose");
            Words.Add(7, "Erbse");
            Words.Add(8, "Blase");
            Words.Add(9, "Nase");
            Words.Add(10, "Kaese");
            Words.Add(11, "Wackeln");
            Words.Add(12, "Monster");
            Words.Add(13, "Frosch");
            Words.Add(14, "Kartoffel");
            Words.Add(15, "Gurke");
            Words.Add(16, "Koenig");
            Words.Add(17, "Blick");
            Words.Add(18, "Wurst");
            Words.Add(19, "Keks");
            Words.Add(20, "Kruemel");
            Words.Add(21, "Maschine");
            Words.Add(22, "Dose");
            Words.Add(23, "Tasche");
            Words.Add(24, "Zwerg");
            Words.Add(25, "Schokolade");
            Words.Add(26, "Ball");
            Words.Add(27, "Brezel");
            Words.Add(28, "Kuchen");
            Words.Add(29, "Wirbel");
            Words.Add(30, "Pfanne");
            Words.Add(31, "Zwiebel");
            Words.Add(32, "Erdbeere");
            Words.Add(33, "Zucker");
            Words.Add(34, "Trommel");
            Words.Add(35, "Nudel");
            Words.Add(36, "Auflauf");
            Words.Add(37, "Suppe");
            Words.Add(38, "Muetze");
            Words.Add(39, "Buchstaben");
            Words.Add(40, "Hase");
            Words.Add(41, "Dosenoeffner");
            Words.Add(42, "Kuh");
            Words.Add(43, "Ring");
            Words.Add(44, "Baum");
            Words.Add(45, "Schirm");
            Words.Add(46, "Lampe");
            Words.Add(47, "Brot");
            Words.Add(48, "Teller");
            Words.Add(49, "Tinte");
            Words.Add(50, "Schrank");

            Random random = new Random();
            string randomWord = Words[random.Next(1, 50)];
            return randomWord;  
        }

        static char[] ArrayConvert(string word) 
        {
            char[] SolutionCharray = new char[word.Length];
            for (int i = 0; i < word.Length ; i++)
            {
                SolutionCharray[i] = '_';
            }
            return SolutionCharray;
        }

        static char[] ArrayCopy(string word)
        {
            char[] FullCharray = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                FullCharray[i] = word[i];
            }
            return FullCharray;
        }
    }
}
