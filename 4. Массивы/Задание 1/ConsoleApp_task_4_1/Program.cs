using System;

using static System.Console;

namespace ConsoleApp_task_4_1{
static class Program{

static void Main()
{	int height, width, summary;

	int[,] matrix;
	Random randomizer = new Random();
	

	WriteLine( "Введите число строк матрицы." );
	height = int.Parse(ReadLine());

	WriteLine( "\nВведите число столбцов матрицы." );
	width = int.Parse(ReadLine());

	matrix = new int[height, width];
	summary = 0;
	
	WriteLine( "\nМатрица:\n" );
	for( int i = 0; i < height; i++ )
	{	for( int j = 0; j < width; j++ )
		{	matrix[ i, j ] = randomizer.Next( int.MinValue,int.MaxValue );
			summary += matrix[ i, j ];
			Write( $"{ matrix[ i, j ] } " );
		}

		WriteLine();
	}

	WriteLine( $"\nСумма элементов матрицы: { summary }." );
	ReadLine();
}
	
}}