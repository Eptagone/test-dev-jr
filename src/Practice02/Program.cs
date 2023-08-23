// Main program
Console.WriteLine("Practica 02. Para cerrar el programa, escriba 'exit' o presione Ctrl+C\n");

while (true)
{
	Console.Write("Ingrese un numero: ");
	string? input = Console.ReadLine();

	// Salir del programa
	if (input == "exit")
	{
		break;
	}

	if (int.TryParse(input, out int number))
	{
		var evenMessage = number % 2 == 0 ? "par" : "impar";
		Console.WriteLine("El numero {0} es {1}", number, evenMessage);
	}
	else
	{
		Console.WriteLine("El valor ingresado no es un numero");
	}
}
