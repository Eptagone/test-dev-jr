namespace Practice03a;

class Program
{
	static void Main(string[] _)
	{
		Console.WriteLine("Practica 03 IF-ELSE. Para cerrar el programa, escriba 'exit' o presione Ctrl+C");

		while (true)
		{
			Console.WriteLine("\nIngrese un color: ");
			Console.WriteLine("Opciones disponibles: Amarillo, Morado, Rosa, Azul, Blanco");
			Console.Write("Color: ");
			string? input = Console.ReadLine();

			// Salir del programa
			if (input == "exit")
			{
				break;
			}

			// Obtener el número del color
			int? output = GetColorNumber(input);

			if (output == null)
			{
				Console.WriteLine("El color ingresado no existe.");
			}
			else
			{
				// Generar la tabla de multiplicar
				string table = GenerateTable(output.Value);
				Console.WriteLine(table);
			}
		}
	}

	/// <summary>
	/// Obtener el número de color.
	/// </summary>
	/// <param name="color">Nombre del color.</param>
	/// <returns>El número del color o null si el color no existe.</returns>
	private static int? GetColorNumber(string? color)
	{
		if (color == "Amarillo")
		{
			return 2;
		}
		else if (color == "Morado")
		{
			return 7;
		}
		else if (color == "Rosa")
		{
			return 9;
		}
		else if (color == "Azul")
		{
			return 6;
		}
		else if (color == "Blanco")
		{
			return 12;
		}
		else
		{
			return null;
		}
	}

	/// <summary>
	/// Generar la tabla de multiplicar de un número.
	/// </summary>
	/// <param name="number">El número.</param>
	/// <returns>La tabla de multiplicar.</returns>
	private static string GenerateTable(int number)
	{
		// Buffer para almacenar la tabla
		List<string> table = new(new string[] { $"Tabla del {number}:" });

		// Generar la tabla
		for (int i = 1; i <= 10; i++)
		{
			table.Add($"{number} x {i} = {number * i}");
		}

		return string.Join("\n", table);
	}
}
