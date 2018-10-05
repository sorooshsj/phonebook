using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[1];
            string[] families = new string[1];
            string[] phones = new string[1];
            int number = 0;
            bool exit = false;
            while (exit == false)
            {
                Console.Clear();
                for (int i = 0; i < phones.Length; i++)
                {
                    Console.WriteLine($"{names[i]}\t{families[i]}\t{phones[i]}");
                }
                Console.WriteLine("-----------------------");
                menuewrite();
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.Write("Name:");
                        var newName = Console.ReadLine();
                        AddToArray(ref names, newName);

                        Console.Write("Family:");
                        var newFamily = Console.ReadLine();
                        AddToArray(ref families, newFamily);

                        Console.Write("Phone:");
                        var newPhone = Console.ReadLine();
                        AddToArray(ref phones, newPhone);
                        break;
                    case 2:
                        Console.Write("Name:");
                        var deleteName = Console.ReadLine();
                        RemoveFromArray(ref names, deleteName);

                        Console.Write("Family:");
                        var deleteFamily = Console.ReadLine();
                        RemoveFromArray(ref families, deleteFamily);

                        Console.Write("Phone:");
                        var deletePhone = Console.ReadLine();
                        RemoveFromArray(ref phones, deletePhone);
                        break;
                    case 3:
                        Console.Write("current name:");
                        var nametoedit = Console.ReadLine();
                        Console.Write("new name:");
                        var newnamevalue = Console.ReadLine();
                        EditFromArray(ref names, nametoedit, newnamevalue);

                        Console.Write("current familyname:");
                        var familynametoedit = Console.ReadLine();
                        Console.Write("new familyname:");
                        var familynewnamevalue = Console.ReadLine();
                        EditFromArray(ref families, familynametoedit, familynewnamevalue);

                        Console.Write("current phone:");
                        var phonetoedit = Console.ReadLine();
                        Console.Write("new phone:");
                        var newphonevalue = Console.ReadLine();
                        EditFromArray(ref phones, phonetoedit, newphonevalue);
                        break;
                    case 4:
                        exit = true;
                        break;

                }

            }

        }

        static void AddToArray(ref string[] array, string newValue)
        {
            if (array[0] != null)//اگر خانه اول آرایه پر بود
            {
                string[] newArray = new string[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[newArray.Length - 1] = newValue;
                array = newArray;
            }
            else//اگر خانه ااول آرایه خالی بود

            {
                array[0] = newValue;
            }

        }

        static void RemoveFromArray(ref string[] array, string valueToRemove)
        {
            var newArray = new string[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] != valueToRemove)
                {
                    newArray[j++] = array[i];
                }
            }
            array = newArray;
        }
        static void EditFromArray(ref string[] array, string ValueToEdit, string newValue)
        {
            var newArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ValueToEdit)
                {
                    newArray[i] = newValue;
                }
                else
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
        }
        static void menuewrite()
        {
            Console.WriteLine("Choose one action:");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Edit");
            Console.WriteLine("4.Exit");
            Console.Write("Select the number of action:");
        }
    }
}
