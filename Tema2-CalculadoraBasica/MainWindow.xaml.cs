using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int resultado;
        public MainWindow()
        {
            InitializeComponent();
            resultado_TextBox.IsReadOnly = true;
    
        }

        private void operador1_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void operando_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operando_TextBox.Text != "*" && operando_TextBox.Text != "/" && operando_TextBox.Text != "-" && operando_TextBox.Text != "+")
            {
                Calcular_Button.IsEnabled = false;
            }
            else
                Calcular_Button.IsEnabled = true;
        }

        private void operador2_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void resultado_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Calcular_Button_Click(object sender, RoutedEventArgs e)
        {
            switch(operando_TextBox.Text)
            {
                case "*":
                    resultado = int.Parse(operador1_TextBox.Text) * int.Parse(operador2_TextBox.Text);
                    resultado_TextBox.Text = resultado;
                    break;
            }
            
        }
    }
}
