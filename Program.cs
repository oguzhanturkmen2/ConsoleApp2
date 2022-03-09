using System;


namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //string sample = "aaa.bbb";
            //string[] a = new string[100];
            //a = sample.Split(".");

            //for (int i = 0; i < a.Length; i++)
            //    Console.WriteLine(a[i]);

            //string[] b = test1();

            //for (int i = 0; i < b.Length; i++)
            //    Console.WriteLine(b[i]);

            //string result = test2_A("testtest");
            //Console.WriteLine(result);

            //int[] c = test2_B();
            //for (int i = 0; i < c.Length; i++)
            //    Console.WriteLine(c[i]);

            //string[] a = new string[] { "all", "side", "front" };
            //bool[] c = test2_C(ref a);
            //for (int i = 0; i < c.Length; i++)
            //    Console.WriteLine(a[i] + " " + c[i]);

            //string result = Test3("aarbhny", "rtnnh");
            //Console.WriteLine(result);

            //var kv = new KeyvalArr();
            //kv.insertKey(3, 33);
            //kv.insertKey(4, 44);
            ////Console.WriteLine(kv.ToString());
            //int val = kv.getValue(4);
            //Console.WriteLine(val);

            //kv.addToKey(6);
            //kv.addToValue(77);
            //val = kv.getValue(6);
            //Console.WriteLine(val);

            //Console.WriteLine(solution2("yzyzyz").ToString());

            //bool[][] field = new bool[5][];
            //field[0] = new bool[] { false, true, true};
            //field[1] = new bool[] { true, false, true };
            //field[2] = new bool[] { false, false, true };
            //field[3] = new bool[] { false, false, true };
            //field[4] = new bool[] { false, false, true };

            //int[][] res;
            //res = solution3(field,4,0);

            Rectangle.testRect(); //Asıl sınav task 4
        }

        public static int solution2(string s)
        {
            int result = 0;
            string a, b, c;
            for (int i = 1; i <= s.Length - 2; i++)
            {
                a = s.Substring(0, i);
                for (int j = 1; j <= s.Length - i - 1; j++)
                {
                    b = s.Substring(i, j);
                    c = s.Substring(i + j);
                    Console.Write(a); Console.Write("+");
                    Console.Write(b); Console.Write("+");
                    Console.Write(c); Console.Write("--");
                    int d = isDifferent(a, b, c);
                    Console.Write(d.ToString() + "::");
                    result += d;
                }
            }
            return result;
        }

        public static int isDifferent(string a, string b, string c)
        {
            if (a + b == b + c)
                return 0;
            else if (a + b == c + a)
                return 0;
            else if (b + c == c + a)
                return 0;
            else
                return 1;
        }

        public static int[][] solution3(bool[][] field, int x, int y)
        {
            int[][] result = new int[field.GetLength(0)][];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                result[i] = new int[field[i].Length];
                for (int j = 0; j < field[i].Length; j++)
                    result[i][j] = -1;
            }
            //
            int num = getNumber(ref field, x, y);
            result[x][y] = num;
            SearchNeighbour(ref result, ref field, x, y);

            return result;
        }


        public static void SearchNeighbour(ref int[][] result, ref bool[][] field, int x, int y)
        {
            int count; int x1; int y1;

            if (x - 1 >= 0 && y - 1 >= 0)
            {              
                x1= x - 1; y1= y - 1;

                if (result[x1][y1] == -1)
                {

                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }
            if (x - 1 >= 0)
            {
                x1 = x - 1; y1 = y;
                if (result[x1][y1] == -1)
                {
                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }
            if (x - 1 >= 0 && y + 1 < field[x - 1].Length)
            {
                x1 = x - 1; y1 = y + 1;
                if (result[x1][y1] == -1)
                {
                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }
            if (y - 1 > 0)
            {
                x1 = x; y1 = y - 1;
                if (result[x1][y1] == -1)
                {
                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }
            if (y + 1 < field[x].Length)
            {
                x1 = x; y1 = y + 1;
                if (result[x1][y1] == -1)
                {
                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }
            if (x + 1 < field.Length && y - 1 > 0)
            {
                x1 = x + 1; y1 = y - 1;
                if (result[x1][y1] == -1)
                {
                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }
            if (x + 1 < field.Length)
            {
                x1 = x + 1; y1 = y;
                if (result[x1][y1] == -1)
                {
                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }
            if (x + 1 < field.Length && y + 1 <= field[x + 1].Length)
            {
                x1 = x + 1; y1 = y + 1;
                if (result[x1][y1] == -1)
                {
                    count = getNumber(ref field, x1, y1);
                    result[x1][y1] = count;
                    if (count == 0)
                        SearchNeighbour(ref result, ref field, x1, y1);
                }
            }



        }

        public static int getNumber(ref bool[][] field, int x, int y)
        {
            int result = 0;
            if (x - 1 >= 0 && y - 1 >= 0 && field[x - 1][y - 1])
                result++;
            if (x - 1 >= 0 && field[x-1][y])
                result++;
            if (x - 1 >= 0 && y + 1 < field[x-1].Length && field[x - 1][y + 1])
                result++;
            if (y - 1 > 0 && field[x][y - 1])
                result++;
            if (y + 1 < field[x].Length && field[x][y + 1])
                result++;
            if (x + 1 < field.Length && y - 1 > 0 && field[x + 1][y - 1])
                result++;
            if (x + 1 < field.Length && field[x + 1][y])
                result++;
            if (x + 1 < field.Length && y + 1 < field[x + 1].Length && field[x + 1][y + 1])
                result++;
            return result;
        }



        public static string[] test1()
        {
            string[] a = new string[100];
            for (int i = 0; i < 100; i++)
                a[i] = i.ToString();
            return a;
        }

        public static string test2_A(string sample)
        {
            string a = sample.Substring(0, sample.Length / 2);
            string b = sample.Substring(sample.Length / 2);
            if (a == b)
                return a;
            else
                return a + b;
        }

        public static int[] test2_B()
        {
            int[] a = new int[] { 3, 6, 9, 11, 13, 15, 18 };
            int[] b = new int[] { };
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 == 0)
                {
                    Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = a[i];
                }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = b[i] * 2;
                a = appendArray(a, b[i]);
            }

            return a;
        }

        public static int[] appendArray(int[] apAr, int p)
        {
            Array.Resize(ref apAr, apAr.Length + 1);
            for (int i = apAr.Length - 1; i > 0; i--)
            {
                apAr[i] = apAr[i - 1];
            }
            apAr[0] = p;
            return apAr;
        }

        public static bool[] test2_C(ref string[] a)
        {

            string b = "asAllFarAwayFront";

            bool[] c = new bool[] { true, true, true };
            string bUpper = b.ToUpper();
            for (int i = 0; i < a.Length; i++)
                if (bUpper.IndexOf(a[i].ToUpper()) < 0)
                    c[i] = false;
            return c;
        }

        public static string Test3(string st1, string st2)
        {
            string stRes = "";
            //int[] cntArr = new int[stRes.Length];
            for (int i = 0; i < st1.Length; i++)
            {
                if (i > st2.Length - 1)
                    stRes += st1[i];
                else
                {
                    int cntOccrSt1 = countOfOccur(st1[i], st1);
                    int cntOccrSt2 = countOfOccur(st2[i], st2);
                    if (cntOccrSt1 < cntOccrSt2)
                        stRes += st1[i];
                    else if (cntOccrSt1 > cntOccrSt2)
                        stRes += st2[i];
                    else if (st1[i] > st2[i])
                        stRes += st2[i];
                    else
                        stRes += st1[i];
                }
            }
            if (st2.Length > st1.Length)
                stRes += st2.Substring(st1.Length, st2.Length - st1.Length);

            return stRes;
        }

        private static int countOfOccur(char ch, string st)
        {
            int count = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == ch)
                    count++;
            }
            return count;
        }
    }
}
