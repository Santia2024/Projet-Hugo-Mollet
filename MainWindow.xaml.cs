using System.Collections.ObjectModel;
using System.Windows;

namespace OrthoPrinter
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<RadioButtonOption> MaxillaryOptions { get; set; }
        public ObservableCollection<RadioButtonOption> MandibularOptions { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Maxillary Options
            MaxillaryOptions = new ObservableCollection<RadioButtonOption>
            {
                new RadioButtonOption { Content = "Maxillary 1", Tag = "MaxillaryOne", ImagePath = "Images/MAXILLARY/Maxillary_1.png", ToolTipImagePath = "Images/MAXILLARY/Maxillary_Tooltip_1.png" },
                new RadioButtonOption { Content = "Maxillary 2", Tag = "MaxillaryTwo", ImagePath = "Images/MAXILLARY/Maxillary_2.png", ToolTipImagePath = "Images/MAXILLARY/Maxillary_Tooltip_2.png" },
                // Add more options as needed...
                new RadioButtonOption { Content = "Maxillary 3", Tag = "MaxillaryThree", ImagePath = "Images/MAXILLARY/Maxillary_3.png", ToolTipImagePath = "Images/MAXILLARY/Maxillary_Tooltip_3.png" },

            };

            // Mandibular Options
            MandibularOptions = new ObservableCollection<RadioButtonOption>
            {
                new RadioButtonOption { Content = "Mandibular 1", Tag = "MandibularOne", ImagePath = "Images/MANDIBULAR/Mandibular_1.png", ToolTipImagePath = "Images/MANDIBULAR/Mandibular_Tooltip_1.png" },
                new RadioButtonOption { Content = "Mandibular 2", Tag = "MandibularTwo", ImagePath = "Images/MANDIBULAR/Mandibular_2.png", ToolTipImagePath = "Images/MANDIBULAR/Mandibular_Tooltip_2.png" },
                // Add more options as needed...
            };

            DataContext = this; // Set DataContext for binding
        }
        public void Save_Checked(object sender, RoutedEventArgs e)
        {

        }
    }

    public class RadioButtonOption
    {
        public string Content { get; set; }
        public string Tag { get; set; }
        public string ImagePath { get; set; }
        public string ToolTipImagePath { get; set; }
    }
}
