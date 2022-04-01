using System;

using static System.Console;

namespace ConsoleApp_task_3_3{
static class Program{

static void Main()
{	int    input, i ;
	bool   notSimple;
	string output   ;

	WriteLine( "Введите целое число." );
	
	i = 1;
	input = int.Parse(ReadLine());
	notSimple = false;

	while( i < input )
	{	notSimple = input % i == 0;

		if( notSimple && i != 1 )
			break;

		i++;
	}

	output = notSimple ? "не является простым" : "является простым";

	WriteLine( $"\nВаше число {output}." );
	ReadLine();
}
	
}}