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

namespace tilitoli
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

        private void btnGenerateMap_Click(object sender, RoutedEventArgs e)
        {

            static void Shuffle(ComboBox cbDropdown)
            {
                int num = cbDropdown.SelectedIndex + 2;

                List<int> numList = new List<int>();

                int index = 0;

                while(index != num)
                {
                    numList.Add(index);
                    index++;
                }
            }

            //+2 index!!!!!
            int num = cbDropdown.SelectedIndex + 2;
            int index = 0;

            while (index < num)
            {
                RowDefinition row = new RowDefinition();
                ColumnDefinition column = new ColumnDefinition();
                index++;
            }

            spWindow.Children.Add(RowDefinition());


        }
        
    }
}
