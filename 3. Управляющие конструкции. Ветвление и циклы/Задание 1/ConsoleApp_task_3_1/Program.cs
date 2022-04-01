using System;

using static System.Console;

namespace ConsoleApp_Task_3_1{
static class Program{

static void Main()
{	int    input;
	string output;

	WriteLine( "Введите целое число." );
	input = int.Parse(ReadLine());

	output = input % 2 == 0 ? "чётное" : "нечётное";

	WriteLine( $"\nВы ввели {output} число." );
	ReadLine();
}
	
}}