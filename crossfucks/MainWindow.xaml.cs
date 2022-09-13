using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace crossfucks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int gridSize = 10;
            UniformGrid crosswordGrid = new UniformGrid() { Columns = gridSize, Rows = gridSize };
            for (int rowIndex = 0; rowIndex<gridSize; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < gridSize; columnIndex++)
                {
                    Button button_cell = new Button()
                    {
                        Content = 1,
                        //BorderBrush = System.Windows.Media.Brushes.Black,
                        //BorderThickness = new Thickness(1, 1, 1, 1),
                        HorizontalContentAlignment = HorizontalAlignment.Center
                    };
                    button_cell.Click += new RoutedEventHandler(Button_Click);
                    crosswordGrid.Children.Add(button_cell);
                }
            }
            this.Grid_CrosswordPanel.Children.Add(crosswordGrid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("asdfasdfasdfFUCK!!!!!!!!!!!!!!!!1");
        }
    }
}
