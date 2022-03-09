using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Asıl sınav task 4
    //int[][] tipinde 3 elemanlı matriks veriliyor. 1. eleman 0 ise rect kaydediliyor. 2. eleman 1 ise kaydilen rect'lere sığması test ediliyor.
    //Hepsine sığıyorsa true, bir tanesine bile sığmıyorsa false döner.
    //Dönüş tipi bool[]. Sıfır tipli dizi sayısı kadar uzunluğu var. Eğer sıfır tipli yoksa 1 uzunluğunda ve true döner. 
    internal static class Rectangle
    {
        public static void testRect()
        {
            //int rowCount = 2;
            int[][] rect = new int[][]
            {
                new int[] { 0, 2,3},
                new int[] { 0, 5,3},
                new int[] { 0, 6,3},
                new int[] { 0, 2,3},
                new int[] { 0, 5,3},
                new int[] { 0, 2,3},
                new int[] { 1, 3,2},
                new int[] { 1, 3,2},
                new int[] { 1, 5,2},
                new int[] { 1, 7,2},
                new int[] { 1, 3,2},
                new int[] { 1, 3,1},
                new int[] { 1, 1,2},
            };   
            bool[] result = task4(rect);
            for (int i = 0; i < result.Length; i++) 
                Console.WriteLine(result[i]);
        }

        public static bool[] task4(int[][] operations)
        {
            List<int[]> conts = new List<int[]>();
            List<int[]> rects = new List<int[]>();
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i][0] == 0)
                    conts.Add(new int[] { operations[i][1], operations[i][2] });
                else
                    rects.Add(new int[] { operations[i][1], operations[i][2] });
            }
            List<bool> result = new List<bool>(); bool isFit;
            foreach (int[] rect in rects)
            {
                isFit = true;
                foreach (int[] cont in conts)
                {
                    isFit = (rect[0] <= cont[0] && rect[1] <= cont[1]) || (rect[1] <= cont[0] && rect[0] <= cont[1]);
                    if (!isFit)
                        break;
                }
                result.Add(isFit);
            }
            if (result.Count == 0)
                result.Add(false);
            return result.ToArray();
        }


    }
}
