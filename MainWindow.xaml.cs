using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using InTeethDocumentPrinter;

namespace OrthoPrinter
{
    public partial class MainWindow : Window
    {
        private PrintWorker _printWorker;
        public PatientArchsData PatientArchsData { get; set; }
        public PatientPersonalData PatientPersonalData { get; set; }
        public ObservableCollection<RadioButtonOption> MaxillaryOptions { get; set; }
        public ObservableCollection<RadioButtonOption> MandibularOptions { get; set; }
        //public PatientDataDocument PatientData { get; set; }
        //public PatientArchsDocument _patientArchs;

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new PatientDataDocument();
            _printWorker = new PrintWorker();
            PatientArchsData = new PatientArchsData();
            PatientPersonalData = new PatientPersonalData();
            
            //var flowDoc = Application.LoadComponent(new Uri("/InTeethDocumentPrinter;component/PersonnalDataDocument.xaml", UriKind.Relative)) as FlowDocument;

            DocumentViewer.Document = _printWorker.GenerateFlowDocument();

            DataContext = this; // Set DataContext for binding
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(new Grid(), "New");
            }
        }


        private void Maxillary_Checked(object sender, RoutedEventArgs e)
        {
            //_maxillary = Enum.Parse<MaxillaryType>(((RadioButton)sender).Tag?.ToString() ?? "PaintNone");
            //var selectedRadioButton = sender as RadioButton;
            //if (selectedRadioButton != null)
            //{
            //    string selectedTag = selectedRadioButton.Tag.ToString();
            //    MessageBox.Show($"You selected: {selectedTag}");
            //}

        }
        private void Mandibular_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void FirstNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //PatientData.FirstName = FirstNameBox.Text;
        }

        private void LastNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }


    public class LineEndPositionConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is double lineX2 && values[1] is double canvasWidth)
            {
                // Retourne la position à la fin de la ligne
                return lineX2 - 5; // Décalage pour centrer le carré sur l'extrémité
            }
            return 0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
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
