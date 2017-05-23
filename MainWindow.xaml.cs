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
        public MainWindow()
        {
            InitializeComponent();

            Database DB = new Database();
            // DB.LoadFromFile(Config.DatabaseFullPath);
            int i = 5;

            Category BeginnerCategory = new Category("Beginner");
            GrammarPoint Point = new GrammarPoint("Grammar Point");
            Point.Category = BeginnerCategory;
            Sentence ExampleSentence = new Sentence("I love Conny very much");
            Point.Sentences.Add(ExampleSentence);
            DB.Categories.Add(BeginnerCategory);
            DB.GrammarPoints.Add(Point);

            MySingleEntryEditor.DataContext = Point;

            // DB.SaveToFile(Config.DatabaseFullPath);

        }
    }
}
