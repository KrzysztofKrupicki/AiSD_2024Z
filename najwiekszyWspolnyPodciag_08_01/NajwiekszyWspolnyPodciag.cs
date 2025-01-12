namespace najwiekszyWspolnyPodciag_08_01
{
    internal class NajwiekszyWspolnyPodciag
    {
        private String string_1;
        private String string_2;
        private int[,] matrix;

        public NajwiekszyWspolnyPodciag(String string_1, String string_2)
        {
            this.string_1 = string_1;
            this.string_2 = string_2;
            this.matrix = GenerujMacierz();
        }

        public int[,] GenerujMacierz()
        {
            string s1 = " " + string_1;
            string s2 = " " + string_2;
            int[,] matrix = new int[s1.Length, s2.Length];
            for (int i = 1; i < s1.Length; i++)
            {
                for (int j = 1; j < s2.Length; j++)
                {
                    if (s1[i] != s2[j])
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                    }
                }
            }
            return matrix;
        }

        public void WyswietlMacierz()
        {
            Console.WriteLine("Macierz:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void WyswietlMacierzZLiterami()
        {
            string s1 = " " + string_1;
            string s2 = " " + string_2;
            Console.WriteLine("Macierz z literami:");
            Console.Write("  ");
            for (int j = 0; j < s2.Length; j++)
            {
                Console.Write(s2[j] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(s1[i] + " ");

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int Dlugosc()
        {
            int i = matrix.GetLength(0) - 1;
            int j = matrix.GetLength(1) - 1;
            return matrix[i, j];
        }

        public string PodciagGora()
        {
            string podciag = "";
            int i = matrix.GetLength(0) - 1;
            int j = matrix.GetLength(1) - 1;
            while (i > 0 && j > 0)
            {
                if (matrix[i - 1, j] == matrix[i, j])
                {
                    i--;
                }
                else if (matrix[i, j - 1] == matrix[i, j])
                {
                    j--;
                }
                else
                {
                    podciag = string_1[i - 1] + podciag;
                    i--;
                    j--;
                }
            }
            return podciag;
        }

        public string PodciagLewo()
        {
            string podciag = "";
            int i = matrix.GetLength(0) - 1;
            int j = matrix.GetLength(1) - 1;
            while (i > 0 && j > 0)
            {
                if (matrix[i, j - 1] == matrix[i, j])
                {
                    j--;
                }
                else if (matrix[i - 1, j] == matrix[i, j])
                {
                    i--;
                }
                else
                {
                    podciag = string_1[i - 1] + podciag;
                    i--;
                    j--;
                }
            }
            return podciag;
        }
    }
}
