namespace _30_MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //multidimensional array = an array of arrays. good to use for matrix, grid, tables of data

            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvetter", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };

            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
                                     { "Corvetter", "Camaro", "Silverado" } , 
                                     { "Corolla", "Camry", "Rav4" } 
                                   };

            parkingLot[0, 2] = "Fusion";            //0 row, 2nd column
            parkingLot[2, 0] = "Tacoma";

            /*
            foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
