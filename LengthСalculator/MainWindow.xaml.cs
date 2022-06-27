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

namespace LengthСalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LengthController controller; 

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            controller = new LengthController();
        }

        /// <summary>
        /// загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LengthController controller = new LengthController();
            cbIn.ItemsSource = controller.LengthUnit; // контент  для комбобоксов 
            cbOut.ItemsSource = controller.LengthUnit; // контент  для комбобоксов 
        }

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            if(cbIn.SelectedIndex < 0 || cbIn.SelectedIndex > cbIn.Items.Count)
            {
                MessageBox.Show("Неверные  параметры ");
                return;
            }

            if (cbOut.SelectedIndex < 0 || cbOut.SelectedIndex > cbOut.Items.Count)
            {
                MessageBox.Show("Неверные  параметры ");
                return;
            }

            try
            {
                var valueLength = Convert.ToDouble(tbvalue.Text);
                string inUint = (string)cbIn.SelectedItem;
                string outUint = (string)cbOut.SelectedItem;

                lbRez.Content = $"Ответ: {controller.MetematicCalc(inUint, outUint, valueLength)} {outUint}ов ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
