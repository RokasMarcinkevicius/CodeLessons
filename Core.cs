using System;

namespace CodeLessons
{
    class Core
    {
        static void Main()
        {
            Console.WriteLine("BinaryGap ----------------------------------------------------------------");

            BinaryGap lesson1 = new BinaryGap();
            Console.WriteLine(lesson1.Solution(529));

            Console.WriteLine("OddOccurencesInArrays ----------------------------------------------------------------");
            int []arr = {5, 7, 2, 7, 5, 2, 5};
            OddOccurencesInArrays lesson2 = new OddOccurencesInArrays();
            Console.WriteLine(lesson2.SolutionNestedArrays(arr, arr.Length));
            Console.WriteLine(lesson2.SolutionHashSet(arr, arr.Length));
            Console.WriteLine(lesson2.SolutionBitwiseXOR(arr, arr.Length));

            Console.WriteLine("CyclicRotation ----------------------------------------------------------------");
            CyclicRotation lesson2_2 = new CyclicRotation();
            Console.WriteLine("[{0}]", string.Join(", ", lesson2_2.Solution(new int[] {1,2,3,4}, 3)));

            Console.WriteLine("FrogJmp ----------------------------------------------------------------");
            FrogJmp lesson3 = new FrogJmp();
            Console.WriteLine(lesson3.Solution(10,85,30));

            Console.WriteLine("PermMissingElement ----------------------------------------------------------------");
            PermMissingElement lesson3_2 = new PermMissingElement();
            Console.WriteLine("[{0}]", string.Join(", ", lesson3_2.Solution(new int[] {2,3,1,5})));

            Console.WriteLine("TapeEquilibrium ----------------------------------------------------------------");
            TapeEquilibrium lesson3_3 = new TapeEquilibrium();
            Console.WriteLine("[{0}]", string.Join(", ", lesson3_3.Solution(new int[] {3,1,2,4,3})));

            Console.WriteLine("MissingInteger ----------------------------------------------------------------");
            MissingInteger lesson4 = new MissingInteger();
            Console.WriteLine("[{0}]", string.Join(", ", lesson4.Solution(new int[] {1, 2, 3})));

            Console.WriteLine("PassingCars ----------------------------------------------------------------");
            PassingCars lesson5 = new PassingCars();
            Console.WriteLine("[{0}]", string.Join(", ", lesson5.Solution(new int[] {0,1,0,1,1})));

            Console.WriteLine("Distinct ----------------------------------------------------------------");
            Distinct lesson6 = new Distinct();
            Console.WriteLine("[{0}]", string.Join(", ", lesson6.Solution(new int[] {2,1,1,2,3,1})));
        }
    }
}
