using System;

using static System.Console;

namespace ConsoleApp_Task_2_1{
static class Program{

static void Main()
{	int age;
	string fullName, mail;
	double programming, math, physics;
	
	mail     = "pavelko93@gmail.com"       ;
	fullName = "Кожевников Павел Андреевич";

	age         = 28 ;
	math        = 4.8;
	physics     = 4.3;
	programming = 5.0;

	WriteLine( $"Ф.И.О: { fullName };\n\rВозраст: { age };\n\rE-mail: { mail };\n\rБалл по программированию: { programming.ToString("0.0") };\n\rБалл по математике: { math };\n\rБалл по физике: { physics };" );
	ReadLine();
}
	
}}