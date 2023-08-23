namespace Practice03b;

class Program
{
	static void Main(string[] _)
	{
		Console.WriteLine("Practica 03 SWITCH. Para cerrar el programa, escriba 'exit' o presione Ctrl+C");

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
	private static int? GetColorNumber(string? color) => color switch
	{
		"Amarillo" => 2,
		"Morado" => 7,
		"Rosa" => 9,
		"Azul" => 6,
		"Blanco" => 12,
		_ => null
	};

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
