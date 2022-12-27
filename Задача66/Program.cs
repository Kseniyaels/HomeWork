/*Задайте значения M и N. Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int CalculateSumm(int M, int N)
{
	int start = M;
	int end = N;
	if(M > N)
	{
		start = N;
		end = M;
	}
	return (end + start)*(end - start + 1)/2; 
}
		
Console.WriteLine(CalculateSumm(4, 16));
	
		