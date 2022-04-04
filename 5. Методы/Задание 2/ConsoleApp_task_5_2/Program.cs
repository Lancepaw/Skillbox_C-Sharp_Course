using System;

using static System.Console;

namespace ConsoleApp_task_5_2{
static class Program{

static void Main()
{	string   input;
	string[] splitted;

	WriteLine( "Введите предложение.\n" );
	input = ReadLine();

	WriteLine( $"\nИнвертированное предложение:\n" );
	InvertAndPrintString( input );
	ReadLine();
}

static private void InvertAndPrintString( string input )
{	string   invertedString;
	string[] splittedString;

	invertedString = "";
	splittedString = SplitStringManually( input );

	for( int i = splittedString.Length-1; i >= 0 ; i-- )
	{	invertedString += splittedString[ i ];
	
		if( i != 0 )
			invertedString += ' ';
	}

	WriteLine( invertedString );
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
	
}}