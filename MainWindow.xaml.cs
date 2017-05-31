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

namespace WritingPrompter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Database DB
        {
            get;
            set;
        }

        public MainWindow()
        {
            InitializeComponent();

            DB = new Database();
            DB.LoadFromFile(Config.DatabaseFullPath);
            int i = 5;

            Category BeginnerCategory = new Category("Beginner");
            GrammarPoint Point = new GrammarPoint("Grammar Point");
            Point.Category = BeginnerCategory;
            Sentence ExampleSentence = new Sentence("I love Conny very much");
            Point.Sentences.Add(ExampleSentence);
            DB.Categories.Add(BeginnerCategory);
            DB.GrammarPoints.Add(Point);

            GrammarPoint Point2 = new GrammarPoint("Another Grammar Point");
            DB.GrammarPoints.Add(Point2);

            MySingleEntryEditor.DataContext = Point;

            foreach (GrammarPoint CurrentPoint in DB.GrammarPoints)
            {
                MyAvailablePointsView.AvailablePoints.Add(CurrentPoint);
            }


        }

        private void MyAvailablePointsView_SelectionChanged(object sender, RoutedEventArgs e)
        {
            GrammarPoint SelectedPoint = MyAvailablePointsView.SelectedPoint;
            MySingleEntryEditor.DataContext = SelectedPoint;
        }

        private void SaveDatabaseButton_Click(object sender, RoutedEventArgs e)
        {
            DB.SaveToFile(Config.DatabaseFullPath);
        }
    }
}
