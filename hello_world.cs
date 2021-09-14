//teste de commit fora da master e adicao do namespace
namespace MaxNum
{
	class HelloCSharp

	{

		static void Main()
		{

			System.Console.WriteLine(MaxNum(30, 70));
			System.Console.ReadLine();
		}
		static int MaxNum(int num1, int num2)
		{
			int result;

			if (num1 >= num2)
			{
				result = num1;
				return result;

			}
			else
			{
				result = num2;
				return result;
			}
		}
	}
}

