using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem11 : EulerProblem
    {
        private const string format = "The greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) is {0}.";
        private const int productLength = 4;
        //[y,x], from upper left
        private long[][] data = new long[][]{
                                            new long[]{08,02,22,97,38,15,00,40,00,75,04,05,07,78,52,12,50,77,91,08},
                                            new long[]{49,49,99,40,17,81,18,57,60,87,17,40,98,43,69,48,04,56,62,00},
                                            new long[]{81,49,31,73,55,79,14,29,93,71,40,67,53,88,30,03,49,13,36,65},
                                            new long[]{52,70,95,23,04,60,11,42,69,24,68,56,01,32,56,71,37,02,36,91},
                                            new long[]{22,31,16,71,51,67,63,89,41,92,36,54,22,40,40,28,66,33,13,80},
                                            new long[]{24,47,32,60,99,03,45,02,44,75,33,53,78,36,84,20,35,17,12,50},
                                            new long[]{32,98,81,28,64,23,67,10,26,38,40,67,59,54,70,66,18,38,64,70},
                                            new long[]{67,26,20,68,02,62,12,20,95,63,94,39,63,08,40,91,66,49,94,21},
                                            new long[]{24,55,58,05,66,73,99,26,97,17,78,78,96,83,14,88,34,89,63,72},
                                            new long[]{21,36,23,09,75,00,76,44,20,45,35,14,00,61,33,97,34,31,33,95},
                                            new long[]{78,17,53,28,22,75,31,67,15,94,03,80,04,62,16,14,09,53,56,92},
                                            new long[]{16,39,05,42,96,35,31,47,55,58,88,24,00,17,54,24,36,29,85,57},
                                            new long[]{86,56,00,48,35,71,89,07,05,44,44,37,44,60,21,58,51,54,17,58},
                                            new long[]{19,80,81,68,05,94,47,69,28,73,92,13,86,52,17,77,04,89,55,40},
                                            new long[]{04,52,08,83,97,35,99,16,07,97,57,32,16,26,26,79,33,27,98,66},
                                            new long[]{88,36,68,87,57,62,20,72,03,46,33,67,46,55,12,32,63,93,53,69},
                                            new long[]{04,42,16,73,38,25,39,11,24,94,72,18,08,46,29,32,40,62,76,36},
                                            new long[]{20,69,36,41,72,30,23,88,34,62,99,69,82,67,59,85,74,04,36,16},
                                            new long[]{20,73,35,29,78,31,90,01,74,31,49,71,48,86,81,16,23,57,05,54},
                                            new long[]{01,70,54,71,83,51,54,69,16,92,33,48,61,43,52,01,89,19,67,48}};

        protected override void SetProblemText()
        {
            problemText = "Problem 11:\nIn the 20×20 grid below, four numbers along a diagonal line have been marked in red.\n\n08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08\n49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00\n81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65\n52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91\n22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80\n24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50\n32 98 81 28 64 23 67 10*26*38 40 67 59 54 70 66 18 38 64 70\n67 26 20 68 02 62 12 20 95*63*94 39 63 08 40 91 66 49 94 21\n24 55 58 05 66 73 99 26 97 17*78*78 96 83 14 88 34 89 63 72\n21 36 23 09 75 00 76 44 20 45 35*14*00 61 33 97 34 31 33 95\n78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92\n16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57\n86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58\n19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40\n04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66\n88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69\n04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36\n20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16\n20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54\n01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48\n\nThe product of these numbers is 26 × 63 × 78 × 14 = 1788696.\n\nWhat is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?"; ;
        }

        public override void Run()
        {
            long maxHoriz = MaxProductHorizontal(productLength);
            long maxVert = MaxProductVertical(productLength);
            result = Math.Max(maxHoriz, maxVert);

            stringResult = string.Format(format, result);
        }

        private long MaxProductHorizontal(int length)
        {
            long maxProduct = -1;

            for (int y = 0; y < data.Length; y++)
            {
                //Console.WriteLine("line {0} is {1}", y, string.Join(",", data[y]));
                for (int x = 0; x <= data[y].Length - length; x++)
                {
                    long product = data[y].Where((val, index) => (index >= x && index < x + length)).Aggregate((sum, element) => sum * element);
                    //Console.WriteLine("Product is {0}.", product);
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                        Console.WriteLine("New max product horizontal is {0}.", maxProduct);
                    }
                }
            }

            Console.WriteLine("MaxProductHorizontal: {0}.", maxProduct);
            return maxProduct;
        }

        private long MaxProductVertical(int length)
        {
            long maxProduct = -1;

            for (int y = 0; y <= data.Length-length; y++)
            {
                //Console.WriteLine("line {0} is {1}", y, string.Join(",", data[y]));
                for (int x = 0; x < data[y].Length; x++)
                {
                    long[] temp = VerticalSlice(data, x, y, length);
                    //string asString = string.Join(",", temp);
                    //Console.WriteLine("A {0} long vertical slice starting at [{1},{2}] is {3}",length,x, y, asString);
                    long product = temp.Aggregate((sum, element) => sum * element);
                    //Console.WriteLine("Product is {0}.", product);
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                        Console.WriteLine("New max product vertical is {0}.", maxProduct);
                    }
                }
            }

            Console.WriteLine("MaxProductVertical: {0}.", maxProduct);
            return maxProduct;
        }

        private long[] VerticalSlice(long[][] data, int x, int y, int length)
        {
            long[] result = new long[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = data[y + i][x];
            }

            return result;
        }
    }
}
