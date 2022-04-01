using System;

using static System.Console;

namespace ConsoleApp_task_4_3{
static class Program{

static void Main()
{	int    max, res          ;
	string tmp, input, output;
	Random randomizer        ;

	WriteLine( "Введите максимальное целое число диапазона.\n" );
	
	randomizer = new Random();

	max = int.Parse( ReadLine() );
	res = randomizer.Next( 0, max );
	
	WriteLine( "\nВведите загаданное программой число. В случае ошибки следуйте подсказкам. Для выхода введите пустую строку.\n" );
	while( true )
	{	tmp = ReadLine();
		
		if( tmp == "" )
		{	WriteLine( "\nИгра окончена. Для выхода нажмите Enter ещё раз." );
			break;
		}
		else if( int.Parse( tmp ) == res )
		{	WriteLine( "\nВы угадали!" );
			break;
		}
		else if( int.Parse( tmp ) > res )
			output = "\nВы не угадали, ваше число больше загаданного. Попробуйте ещё раз\n";
		else
			output = "\nВы не угадали, ваше число меньше загаданного. Попробуйте ещё раз\n";

		WriteLine( output );
	}
	
	ReadLine();
}
	
}}