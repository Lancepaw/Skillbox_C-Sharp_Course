using System;

using static System.Console;

namespace ConsoleApp_task_5_1{
static class Program{

static void Main()
{	string   input   ;
	string[] splitted;

	WriteLine( "Введите предложение.\n" );
	input = ReadLine();

	WriteLine( $"\nРазбивка приложения самодельным способом:\n" );
	PrintLineByLine( SplitStringManually( input ) );

	WriteLine( "Введите ещё одно предложение.\n" );
	input = ReadLine();

	WriteLine( $"\nРазбивка приложения с использованием библиотечного метода:\n" );
	PrintLineByLine( SplitStringUsingLibrary( input ) );
	ReadLine();
}

static private string[] SplitStringManually( string input )
{	List< string > res = new List< string >();

	while( true )
	{	int tmp = input.IndexOf( ' ' );

		if( tmp > 0 )
		{	res.Add( input.Substring(0, tmp) );
			input = input.Substring( tmp + 1 );
		}
		else
		{	res.Add( input );
			break;  
		}
	}

	return res.ToArray();
}
static private string[] SplitStringUsingLibrary( string input )
{	return input.Split(' ');  }

static private void PrintLineByLine( string[] line)
{	for( int i = 0; i < line.Length; i++ )
	{	WriteLine( $"{ line[i] }\n" );	}
}
	
}}