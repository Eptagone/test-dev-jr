using Avalonia.Controls;
using System.Linq;

namespace Practice01.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

	// <summary>
	/// Invierte el texto del TextBox
	/// </summary>
	/// <param name="sender">El objeto que ha lanzado el evento</param>
	/// <param name="e">Informaci�n sobre el evento</param>
	private void input_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (sender is TextBox input)
		{
			// Si el texto est� vac�o, no invertir nada
			if (string.IsNullOrEmpty(input.Text))
			{
				// Vaciar el TextBox de salida
				this.output.Text = string.Empty;
				return;
			}

			// Invertir el texto
			string invertedText = new(input.Text.Reverse().ToArray());

			// Aplicar el texto invertido al TextBox de salida
			this.output.Text = invertedText;
		}
	}
}
