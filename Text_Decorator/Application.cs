using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Decorator.TextDecorator;

namespace Text_Decorator
{
    public class Application : IApplication
    {

        public IRegularText Text { get; set; }

        public Application(IRegularText text)
        {
            Text = text;
        }

        public void Run()
        {
            var newText = Text;

            Console.WriteLine("Text Decorator");
            Console.WriteLine("Please write your word: ");
            string userText = Console.ReadLine();

            Console.WriteLine("TEXT DECORATOR");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select an action   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("F: Finished");
            Console.WriteLine("B: BOLD");
            Console.WriteLine("I: ITALIC");
            Console.WriteLine("D: DELETED");
            Console.WriteLine("M: MARKED");
            

            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'f' or 'F':
                        Console.WriteLine(Text.GetText(userText));
                        Text = newText;
                        break;

                    case 'b' or 'B':
                        Text = new BoldText(Text);
                        Console.WriteLine("Bold is added");
                        break;

                    case 'i' or 'I':
                        Text = new ItalicText(Text);
                        Console.WriteLine("Italic is added");
                        break;

                    case 'd' or 'D':
                        Text = new DeletedText(Text);
                        Console.WriteLine("Deleted is added");
                        break;

                    case 'm' or 'M':
                        Text = new MarkedText(Text);
                        Console.WriteLine("Marked is added");
                        break;


                    case 'q' or 'Q':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }

        }

        private static void ClearRow()
        {
            // Set cursor below the menu
            Console.SetCursorPosition(1, 9);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
}
