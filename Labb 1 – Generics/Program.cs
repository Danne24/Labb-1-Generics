using System;

namespace Labb_1___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxCollection listOfBoxes = new BoxCollection();

            // Adds 5 boxes to the collection.
            listOfBoxes.Add(new Box(10, 23, 9));
            listOfBoxes.Add(new Box(12, 13, 59));
            listOfBoxes.Add(new Box(20, 30, 40));
            listOfBoxes.Add(new Box(2, 3, 10));
            listOfBoxes.Add(new Box(39, 28, 19));

            // Trying to add a new box to the collection won't work, error message appears.
            listOfBoxes.Add(new Box(39, 28, 19));

            Console.WriteLine();

            // Trying to remove a box from the collection.
            DisplayAllBoxes(listOfBoxes);
            listOfBoxes.Remove(new Box(2, 3, 10));
            Console.WriteLine("-----------------------------------------------------------------");
            DisplayAllBoxes(listOfBoxes);

            Console.WriteLine();

            // Trying contains method with dimension.
            Box checkTheBox = new Box(10, 23, 9);
            string result;
            if (listOfBoxes.Contains(checkTheBox) == true)
            {
                result = "Yes, a box with those dimensions does exist in the collection";
            }
            else
            {
                result = "No, a box with those dimensions does NOT exist in the collection";
            }
            Console.WriteLine($"Does a box with the dimensions {checkTheBox.Height.ToString()} X {checkTheBox.Length.ToString()} X {checkTheBox.Width.ToString()} exist in the collection, going by dimensions? {result}.");

            Console.WriteLine();

            // Trying contains method with volume.
            Box checkTheBox2 = new Box(11, 23, 9);
            string result2;
            if (listOfBoxes.Contains(checkTheBox2, new BoxSameVolume()) == true)
            {
                result2 = "Yes, a box with that volume does exist in the collection";
            }
            else
            {
                result2 = "No, a box with that volume does NOT exist in the collection";
            }
            Console.WriteLine($"Does a box with the dimensions {checkTheBox2.Height.ToString()} X {checkTheBox2.Length.ToString()} X {checkTheBox2.Width.ToString()} exist in the collection, going by volume? {result2}.");

            Console.WriteLine();

            // Iterates through the collection.
            DisplayAllBoxes(listOfBoxes);

            Console.ReadKey();
        }

        public static void DisplayAllBoxes(BoxCollection listOfBoxes)
        {
            int i = 1;
            foreach (Box box in listOfBoxes)
            {
                Console.WriteLine($"Height of box {i}: {box.Height.ToString()}. Length of box {i}: {box.Length.ToString()}. Width of box {i}: {box.Width.ToString()}.");
                i++;
            }
        }
    }
}
