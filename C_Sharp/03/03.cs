using System;

namespace C3
{
    class ex1
    {
        static void Main(string[] args)
        {
            string[] players = new string[10];
            string[] Regions = { "서울, 경기", "부산" };

            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            string[,,] Cubes;

            int[][] A = new int[3][];
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;

            int sum = 0;
            int[] scores = { 80, 78, 60, 90, 100 };
            //for(int i=0;i<scores.Length; i++)
            //{
            //    sum += scores[i];
            //}
            sum = CalculateSum(scores);
            Console.WriteLine(sum);
        }

        static int CalculateSum(int[] scoresArray)
        {
            int sum = 0;

            for(int i=0;i<scoresArray.Length;i++)
            {
                sum += scoresArray[i];
            }

            return sum;
        }
    }

}