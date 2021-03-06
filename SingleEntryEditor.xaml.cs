﻿using System;
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
    /// Interaction logic for SingleEntryEditor.xaml
    /// </summary>
    public partial class SingleEntryEditor : UserControl
    {
        public SingleEntryEditor()
        {
            InitializeComponent();
        }

        public GrammarPoint CurrentGrammarPoint
        {
            get
            {
                return DataContext as GrammarPoint;
            }
        }

        private void AddExampleButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentGrammarPoint.Examples.Add(new Sentence());
        }

        private void AddSentenceButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentGrammarPoint.Sentences.Add(new Sentence());
        }
    }
}
