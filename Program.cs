using System;

namespace matris {
    class Program {
        static void Main (string[] args) {

            double[, ] A = { { 1, 4, 5 }, { 1, 5, 5 }, { 6, 7, 5 }, { 8, 9, 5 } };
            double[, ] B = { { 1, 2, 6, 9 }, { 1, 2, 4, 8 } };
            double[, ] C = multiple (A, B);
            for (int i = 0; i < C.GetLength (0); i++) {
                for (int j = 0; j < C.GetLength (1); j++) {
                    Console.Write ("[{0}]", C[i, j]);
                }
                Console.WriteLine ();
            }

        }

        public static double[, ] multiple (double[, ] a, double[, ] b) {
            int r1 = a.GetLength (0); //satr a
            int c1 = a.GetLength (1); //sotun a
            int r2 = b.GetLength (0); //satr b
            int c2 = b.GetLength (1); //sotun b
            double[, ] c = new double[r1, c2];
            if (c1 != r2) {

                throw new Exception ("Matrix Multipication Not Possible , the coloumns of the first matrix should be equal to the rows of the second one ");
            } else {
                for (int i = 0; i < r1; i++)
                    for (int j = 0; j < c2; j++)
                        for (int k = 0; k < c1; k++) {
                            c[i, j] += a[i, k] * b[k, j];
                        }

            }
            return c;

        }
    }
}