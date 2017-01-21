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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace LiveChartCrash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection EpisodeCollection { get; } = new SeriesCollection();
        public string[] DayLabels { get; }

        public MainWindow()
        {
            InitializeComponent();
            DayLabels = new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            DataContext = this;
            EpisodeCollection.Add(new ColumnSeries()
            {
                Values = new ChartValues<ObservableValue>() { new ObservableValue(12)}

            });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid.Height = 0;
            Grid.Width = 0;
        }
    }
}
