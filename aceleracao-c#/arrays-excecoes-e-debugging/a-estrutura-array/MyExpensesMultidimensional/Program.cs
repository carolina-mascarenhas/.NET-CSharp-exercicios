class Program
{
  static public int[] custos = new int[4] {100, 50, 400, 30};
  static void Main(string[] args)
  {
    int[,] expensesCost;
    Console.WriteLine("Entre com o número de despesas: ");
    int numberOfExpenses = custos.Length; // quantidade de despesas da pessoa usuária, um valor inteiro
    expensesCost = new int[numberOfExpenses, 2];

    for (int i = 0; i < numberOfExpenses; i++)
    {
      for (int j = 0; j < 2; j++)
      {
        if (j % 2 != 0)
          expensesCost[i, j] = custos[i] * 80 / 100;
        else
          expensesCost[i, j] = custos[i];
      }
    }

    int totalExpenses = 0;

    for (int i = 0; i < numberOfExpenses; i++)
    {
      totalExpenses += expensesCost[i, 0];
    }

    Console.WriteLine("O total das despesas é: " + totalExpenses);
  }
}
