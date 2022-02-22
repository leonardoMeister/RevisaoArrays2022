using System;

namespace RevisaoArrays.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -3, 9, 1, 7, -2, 5, 4, 10, 6, -8 };

            //PegarValores(array);

            int maiorNumero = 0, menorNumero = 0;
            MaiorValor(array, ref maiorNumero);
            MenorNumero(array, out menorNumero);
            int valorMedio = ValorMedio(array);
            int[] maioresValores = TresMaioresValores(array);
            int[] valoresNegativos = ValoresNegativos(array);

            ImprimirArray(array);
            RemoverValor(ref array, 5);
        }

        static int MaiorValor(int[] array, ref int maiorValor)
        {
            maiorValor = array[0];

            for (int x = 0; x < array.Length; x++) if (array[x] > maiorValor) maiorValor = array[x];

            return maiorValor;
        }

        static int[] ValoresNegativos(int[] array)
        {
            int[] valoresNegativos = new int[array.Length];

            Array.Sort(array);

            for (int x = 0; x < array.Length; x++) if (array[x] < 0) valoresNegativos[x] = array[x];

            return valoresNegativos;
        }

        static void ImprimirArray(int[] array)
        {
            Array.Sort(array);
            for (int x = 0; x < array.Length; x++) Console.WriteLine(array[x]);
        }

        static int[] RemoverValor(ref int[] array, int posicao)
        {
            Array.Clear(array, (posicao) - 1, 1);
            return array;
        }

        static int[] TresMaioresValores(int[] array)
        {
            int[] valoresMaiores = new int[3];
            Array.Sort(array);
            for (int x = 0; x < 3; x++) valoresMaiores[x] = array[(array.Length - x) - 1];

            return valoresMaiores;
        }

        static int ValorMedio(int[] array)
        {
            Array.Sort(array);
            int soma = 0;
            for (int x = 0; x < array.Length; x++) soma += array[x];

            int media = soma / array.Length;
            return media;
        }


        static void MenorNumero(int[] array, out int menorValor)
        {
            menorValor = array[0];
            for (int x = 0; x < array.Length; x++) if (array[x] < menorValor) menorValor = array[x];
        }

        static void PegarValores(int[] array)
        {
            Console.WriteLine("Informe 10 valores: ");

            for (int x = 0; x < 10; x++)
            {
                array[x] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
