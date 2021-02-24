using System;

namespace Builder
{
    public static class Program
    {
        private static void Main()
        {
            //The director receives the object of a particular builder from the client.
            //The program itself knows which builder to use to get the right product.
            GuitarCreator electricGuitarCreator = new GuitarCreator(new ElectricGuitarBuilder());
            electricGuitarCreator.CreateGuitar();
            Console.WriteLine(electricGuitarCreator.GetGuitar().ListParts());

            GuitarCreator acousticGuitarCreator = new GuitarCreator(new AcousticGuitarBuilder());
            acousticGuitarCreator.CreateGuitar();
            Console.WriteLine(acousticGuitarCreator.GetGuitar().ListParts());
        }
    }
}