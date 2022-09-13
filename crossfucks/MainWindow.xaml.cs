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
                    Button label = new Button()
                    {
                        Content = 1,
                        //BorderBrush = System.Windows.Media.Brushes.Black,
                        //BorderThickness = new Thickness(1, 1, 1, 1),
                        HorizontalContentAlignment = HorizontalAlignment.Center
                    };
                    crosswordGrid.Children.Add(label);
                }
            }
            this.Grid_CrosswordPanel.Children.Add(crosswordGrid);
        }

    }
}
