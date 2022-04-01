using System;

using static System.Console;

namespace ConsoleApp_Task_3_2{
static class Program{

static void Main()
{	int    count, summary;

	WriteLine( "Укажите количество карт у вас на руках." );
	
	count = int.Parse(ReadLine());
	summary = 0;

	for( int i = 0; i < count; i++ )
	{	WriteLine( "\nВведите номинал следующей карты" );
		
		switch( ReadLine())
		{	case "5":
				summary += 5;
				break;

			case "6":
				summary += 6;
				break;

			case "7":
				summary += 7;
				break;

			case "8":
				summary += 8;
				break;

			case "9":
				summary += 9;
				break;

			case "10":
				summary += 10;
				break;

			case "J":
				summary += 10;
				break;

			case "Q":
				summary += 10;
				break;

			case "K":
				summary += 10;
				break;

			case "T":
				summary += 10;
				break;

			default:
				WriteLine("\nКарта не существет, либо не участвует в игре");
				i--;
				break;
		}
	}

	WriteLine( $"\nСумма ваших карт: { summary }.");
	ReadLine();
}
	
}}