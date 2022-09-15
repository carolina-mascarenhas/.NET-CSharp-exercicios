// ARRAY MULTIDIMENSIONAL

// class PlayingWithArrays
// {
//   public static void Main()
//   {
//     int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
//     Console.WriteLine(multiDimensionalArray[1, 2]);
//   }
// }


// ARRAY JAGGED

// class PlayingWithArrays
// {
//   public static void Main()
//   {
//     // Somente instanciamos o array mais externo neste primeiro passo
//     // Repare que apenas o primeiro colchetes contém números
//     int[][] jaggedArray = new int[4][];

//     // Agora precisamos instanciar um novo array para cada posição do array mais externo
//     jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
//     jaggedArray[1] = new int[3] { 5, 6, 7 };
//     jaggedArray[2] = new int[5] { 8, 9, 10, 11, 12 };
//     jaggedArray[3] = new int[2] { 13, 14 };
//     Console.WriteLine(jaggedArray[3][0]);
//   }
// }


//ARRAY COM 3 DIMENSOES

int[,,] multiDimensionalArray1 = new int[2, 3, 3];

int[,,] multiDimensionalArray2 = { { { 1, 2 }, { 3, 4 } },{ { 5, 6 }, { 7, 8 } } };

// O array jagged precisa ser instanciado em partes. Primeiro instanciamos o array com 3 dimensões
int[][][] jaggedArray = new int[6][][];

// Depois vamos instanciar a primeira linha do array, recebendo um novo array jagged de 2 dimensões
jaggedArray[0] = new int[3][];

// E assim finalmente podemos instanciar a primeira coluna da primeira linha do array com um novo array de 1 dimensão
jaggedArray[0][0] = new int[4] { 1, 2, 3, 4 };