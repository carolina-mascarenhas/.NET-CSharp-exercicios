class Program
{
  static public int[] custos = new int[4] {100, 50, 400, 30};
  static void Main(string[] args)
  {
    int[] expensesCost;
    Console.WriteLine("Entre com o número de despesas: ");
    int numberOfExpenses = custos.Length; // quantidade de despesas da pessoa usuária, um valor inteiro
    expensesCost = new int[numberOfExpenses];
    for (int i = 0; i < numberOfExpenses; i++)
    {
      expensesCost[i] = custos[i]; // custos das despesas
    }

    int totalExpenses = 0;

    for (int i = 0; i < numberOfExpenses; i++)
    {
      totalExpenses += expensesCost[i];
    }

    Console.WriteLine("O total das despesas é: " + totalExpenses);
  }
}
