using System;

using static System.Console;

namespace ConsoleApp_task_4_2{
static class Program{

static void Main()
{	int    length, min ;
	int[]  numbers     ;

	WriteLine( "Введите длину последовательности.\n" );
	length = int.Parse( ReadLine() );

	numbers = new int[ length ];

	WriteLine( "\nВведите числа, разделяя их клавишей Enter.\n" );

	for( int i = 0; i < length ; i++ )
	{	numbers[ i ] = int.Parse ( ReadLine() );
		WriteLine(); 
	}

	min = numbers[0];

	for( int i = 1; i < length ; i++ )
	{	if( numbers[i] < min )
			min = numbers[i];
	}

	WriteLine( $"\nНаименьшее число в вашей последовательности: { min }." );
	ReadLine();
}
	
}}