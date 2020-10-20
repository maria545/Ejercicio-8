using System;
using System.Windows;
using System.Windows.Input;


namespace Ejercicio_8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxEdad_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean tryParseNumero = int.TryParse(TextBoxEdad.Text, out _);

            if (tryParseNumero!=true)
            {
                if (e.Key == Key.F2)
                {
                    TextBlockEdadIncorrecta.Visibility = Visibility.Visible;
                }
            }
        }

        private void TextBoxApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBlockApellidoCliente.Visibility = Visibility.Visible;
            }
        }

        private void textBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBlockNombreCliente.Visibility = Visibility.Visible;
            }
        }
    }
}
