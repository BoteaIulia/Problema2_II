using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Introduceti cate numere va contine sirul:");
		Console.Write("\n");
		Console.Write("n= ");

		int n;
		int pozitive = 0;
		int negative = 0;
		int zero = 0;

		n = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			int nr;
			nr = Convert.ToInt32(Console.ReadLine());
			if (nr == 0)
			{
				zero++;
			}
			if (nr > 0)
			{
				pozitive++;
			}
			if (nr < 0)
			{
				negative++;
			}
		}
		Console.Write("Sirul contine " + negative + " numere negative" + "\n");
		Console.Write("Sirul contine " + zero + " numere = zero"+"\n");
		Console.Write("Sirul contine " + pozitive + " numere pozitive" + "\n");

	}
}
