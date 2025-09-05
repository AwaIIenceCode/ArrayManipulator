using System;

class MyClass
{
    /// <summary>
    /// method for generating random array 
    /// </summary>
    static void GenerateArray(int[] mainArray)
    {
        Random rnd = new Random();

        for (int i = 0; i < mainArray.Length; i++)
        {
            mainArray[i] = rnd.Next(-21, 21);
        }
    }

    /// <summary>
    /// method for showing array
    /// </summary>
    static void ShowArray(int[] mainArray)
    {
        for (int i = 0; i < mainArray.Length; i++)
        {
            Console.Write(mainArray[i] + " ");
        }
    }

    /// <summary>
    /// method for adding number to the end of an array
    /// </summary>
    static void AddToEnd(ref int[] mainArray)
    {
        Console.Write("Enter the number you want to put at the end of the array ->");

        if (!int.TryParse(Console.ReadLine(), out int userNumber))
        {
            Console.WriteLine("Enter the number!");
            return;
        }

        int[] tempArray = new int [mainArray.Length + 1];

        Array.Copy(mainArray,tempArray, mainArray.Length);
        tempArray[^1] = userNumber;
        
        mainArray = tempArray;
    }

    /// <summary>
    /// method for adding number to the start of an array
    /// </summary>
    static void AddToStart(ref int[] mainArray)
    {
        Console.Write("Enter the number you want to put at the start of the array ->");

        if (!int.TryParse(Console.ReadLine(), out int userNumber))
        {
            Console.WriteLine("Enter the number!");
            return;
        }

        int[] tempArray = new int [mainArray.Length + 1];

        Array.Copy(mainArray, 0, tempArray, 1, mainArray.Length);
        tempArray[0] = userNumber;
        
        mainArray = tempArray;
    }

    /// <summary>
    /// method for adding number to the user index of an array
    /// </summary>
    static void AddAtIndex()
    {

    }

    static void Main()
    {
        Console.Write("Enter the size your array (0-1000) -> ");
        if (!int.TryParse(Console.ReadLine(), out int mainSize) || mainSize <= 0 || mainSize > 1000)
        {
            Console.WriteLine("Size must be 0 - 1000!");
            return;
        }

        int[] mainArray = new int[mainSize];

        GenerateArray(mainArray);

        while (true)
        {
            Console.WriteLine("\n\n1 - for showing full array" +
                              "\n2 - for add number to the end at an array" +
                              "\n3 - for add number to the start at an array" +
                              "\n4 for add number to index of an array" +
                              "\nWrite \"Exit\" for exit the program");

            Console.Write("\nEnter your choice -> ");

            string userChoice = Console.ReadLine()?.ToLower();

            switch (userChoice)
            {
                case "1":
                    ShowArray(mainArray); break;

                case "2":
                    AddToEnd(ref mainArray); break;

                case "3":
                    AddToStart(ref mainArray); break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Try again..."); break;
            }
        }
    }
}