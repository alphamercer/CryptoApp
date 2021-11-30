using System;

namespace CryptoApp
{
    class Polybius
    {
        static char[,] GetSquare(string alphabet)
        {
            string filler = "0123456789!@#$%^&*)_+-=<>?,.";
            int alphLength = alphabet.Length;
            var n = (int)Math.Ceiling(Math.Sqrt(alphLength));

            int k = 0;
            double power = Math.Pow(n, 2);
            while (alphabet.Length != power)
            {
                alphabet += filler[k];
                k++;
            }


            char[,] square = new char[n, n];
            var index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (index < alphabet.Length)
                    {
                        square[i, j] = alphabet[index];
                        index++;
                    }
                }
            }

            return square;
        }

        static (int, int) FindSymbol(char[,] square, char symbol)
        {
            int row = -1;
            int column = -1;
            bool isFound = false;

            var l = square.GetLength(0);

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (square[i, j] == symbol)
                    {
                        row = i;
                        column = j;
                        isFound = true;
                        break;
                    }
                }
                if (isFound) break;
            }



            return (row, column);
        }

        public static string CryptPS(string input, string key, bool check)
        {
            {
                var cryptString = "";
                var square = GetSquare(key);

                foreach (var letter in input)
                {
                    var (i, j) = FindSymbol(square, letter);

                    if (check)
                    {
                        i--;
                        cryptString += square[i < 0 ? square.GetLength(0) - 1 : i, j];
                    }
                    else
                    {
                        i++;
                        cryptString += square[i >= square.GetLength(0) ? 0 : i, j];
                    }

                }

                return cryptString;
            }
        }
    }
}