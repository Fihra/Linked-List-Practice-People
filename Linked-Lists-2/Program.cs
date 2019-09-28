using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists_2
{
    class Program
    {
        static public LinkedList<string> people = new LinkedList<string>();

        static void Menu()
        {
            Console.WriteLine("1. Add After");
            Console.WriteLine("2. Add Before");
            Console.WriteLine("3. Add First");
            Console.WriteLine("4. Add Last");
            Console.WriteLine("5. Remove(LinkedListNode)");
            Console.WriteLine("6 Remove");
            Console.WriteLine("7. Remove First");
            Console.WriteLine("8. Remove Last");
            Console.WriteLine("9. Clear");
        }

        static string NewName()
        {
            Console.Write("Input name: ");
            string newName = Console.ReadLine();
            return newName;
        }

        static LinkedListNode<string> FindName()
        {
            Console.Write("Find name: ");
            string searchName = Console.ReadLine();
            LinkedListNode<string> currentName = people.FindLast(searchName);
            return currentName;
        }

        static void Display()
        {
            Console.WriteLine("List of Students");
            foreach (string p in people)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Linked Lists Practice");

            people.AddLast("Rae");
            people.AddLast("Wan");
            people.AddLast("Hojo");
            Display();

            string newPerson;

            bool isLooping = true;
            LinkedListNode<string> current;
            do
            {
                Menu();
                Console.Write("Choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    //Add After
                    case "1":
                        newPerson = NewName();
                        current = FindName();
                        people.AddAfter(current, newPerson);
                        break;
                    //Add Before
                    case "2":
                        newPerson = NewName();
                        break;
                    //Add First
                    case "3":
                        //Add New Person at the beginning
                        newPerson = NewName();
                        people.AddFirst(newPerson);
                        break;
                    //Add Last
                    case "4":
                        newPerson = NewName();
                        break;
                    //Remove(LinkedListNode)
                    case "5":
                    //Remove
                    case "6":
                    //Remove First
                    case "7":
                        //Remove First Node
                        people.RemoveFirst();
                        break;
                    //Remove Last
                    case "8":
                    //Clear
                    case "9":
                        people.Clear();
                        break;
                    case "10":
                        isLooping = false;
                        break;
                    default:
                        break;
                }
                Display();
            } while (isLooping);
           

            Console.ReadKey();
        }
    }
}
