using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AvailablePointsView.xaml
    /// </summary>
    public partial class AvailablePointsView : UserControl
    {

        public ObservableCollection<GrammarPoint> AvailablePoints
        {
            get;
            set;
        }

        public GrammarPoint SelectedPoint
        {
            get;
            private set;
        }

        public AvailablePointsView()
        {
            InitializeComponent();
            DataContext = this;
            AvailablePoints = new ObservableCollection<GrammarPoint>();
        }

        // Create a custom routed event by first registering a RoutedEventID
        // This event uses the bubbling routing strategy
        public static readonly RoutedEvent SelectionChangedEvent = EventManager.RegisterRoutedEvent(
            "SelectionChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AvailablePointsView));

        // Provide CLR accessors for the event
        public event RoutedEventHandler SelectionChanged
        {
            add { AddHandler(SelectionChangedEvent, value); }
            remove { RemoveHandler(SelectionChangedEvent, value); }
        }

        // This method raises the Tap event
        void RaiseSelectionChangedEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(AvailablePointsView.SelectionChangedEvent);
            RaiseEvent(newEventArgs);
        }

        private void MyTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            SelectedPoint = MyTreeView.SelectedItem as GrammarPoint;
            RaiseSelectionChangedEvent();
        }
    }
}
