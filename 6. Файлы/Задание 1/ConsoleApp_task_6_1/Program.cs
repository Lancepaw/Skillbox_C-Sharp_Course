using System;
using System.IO;

using static System.Console;

namespace ConsoleApp_task_6_1{
static class Program{

static string path = "users.txt";
static void Main()
{	string command; 
	
	
	command = ""         ;

	while( command != "Q" && command != "q" )
	{	WriteLine( "Выберите действие: \n\t1 - Вывести данные на экран;\n\t2 - Внести данные в файл;\n\tQ - Выйти из программы\n" );

		command = ReadLine();

		switch( command )
		{	case "1":
				
				if( CheckDbFile( path ) )
					PrintDbLines( ReadDbFile( path ) ); else
					WriteLine( "Файл с записями не существует. Для его оздания воспользуйтесь функцией записи.\n" );

				break;

			case "2":
				if( !CheckDbFile( path ) )
					File.Create( path ).Close();

				WriteLine( "Введите следующе данные, разделяя их пробелом:\n\tФ. И. О.\n\tВозраст\n\tРост\n\tДату рождения\n\tМесто рождения.\n" );
				InsertLineIntoDb( PrepareDataBeforeInsert( ReadLine() ) );
				break;

			default:
				WriteLine( "\nНеправильная команда." );
				break;
		}
	}
}

static private void InsertLineIntoDb( string[] lines )
{	FormatDbLines( "out", ref lines ); 
	File.AppendAllLines( path, lines );

	WriteLine( "Данные импортированы." );
}

static private string[] PrepareDataBeforeInsert( string line )
{	string[] res = new string[ 1 ];

	res[ 0 ] += $"{ GenerateLineId()   } ";
	res[ 0 ] += $"{ GenerateLineDate() } ";
	res[ 0 ] += line                      ;

	return res;
}

static private string GenerateLineDate()
{	string day, month, hour, minute;
	DateTime date = DateTime.UtcNow;

	day = date.Day > 9 ? date.Day.ToString() : '0' + date.Day.ToString();
	month = date.Month > 9 ? date.Month.ToString() : '0' + date.Month.ToString();
	hour = date.Hour > 9 ? date.Hour.ToString() : '0' + date.Hour.ToString();
	minute = date.Minute > 9 ? date.Minute.ToString() : '0' + date.Minute.ToString();

	return $"{ day }.{ month }.{ date.Year } { hour }:{ minute }";
}

static private string GenerateLineId()
{	string[] lines = ReadDbFile( path );

	return lines.Length > 0 ? ( lines.Length + 1 ).ToString() : "1";
}

static private bool CheckDbFile( string path )
{	return File.Exists( path );  }

static private string[] ReadDbFile( string path )
{	string[] res = File.ReadAllLines( path );
	FormatDbLines( "in", ref res );

	return res;
}

static private void FormatDbLines( string destination, ref string[] lines )
{	for( int i = 0; i < lines.Length; i++ )
	{	if( destination == "in" )
		{	lines[i] = lines[i].Replace( '#', ' ' );  }
		else
		{	string   tmp   ;
			string[] tmpArr;
			
			tmp = "";
			tmpArr= lines[ i ].Split( ' ' );
			
			for( int j = 0; j < tmpArr.Length; j++ )
			{	if( j == 1 || j == 3 || j == 4 || j == 9 )
					tmp += $"{ tmpArr[ j ] } ";
				else if( j != tmpArr.Length  -1 )
					tmp += $"{ tmpArr[ j ] }#";
				else
					tmp += $"{ tmpArr[ j ] }";
			}

			lines[ i ] = tmp;
		}
	}
}

static private void PrintDbLines( string[] lines )
{	WriteLine( "Считанные из файла записи:\n" );

	for( int i = 0; i < lines.Length; i++ )
	{	WriteLine( $"{ lines[ i ] }\n" );  }
}
	
}}