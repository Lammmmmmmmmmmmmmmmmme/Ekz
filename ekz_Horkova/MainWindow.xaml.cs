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

namespace ekz_Horkova
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void CalculateMass_Click(object sender, RoutedEventArgs e)
        {
            double fuelVolume;
            double fuelDensity;

            if (double.TryParse(txtFuelVolume.Text, out fuelVolume) && double.TryParse(txtFuelDensity.Text, out fuelDensity))
            {
                Топливо топливо = new Топливо { Объем = fuelVolume, Плотность = fuelDensity };
                double масса = топливо.ВычислитьМассу();
                lblResult.Text = $"Масса топлива: {масса} ";
            }
            else
            {
                lblResult.Text = "Пожалуйста, введите действительные числовые значения объема и плотности топлива.";
            }
        }
    }
   
   



}
