using LineParsingTMG.Entities;
using LineParsingTMG.Models;
using LineParsingTMG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace LineParsingTMG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringInfoModel stringInfo = new StringInfoModel();
        StringOperations countVowels = new StringOperations();
        StringOperations countWords = new StringOperations();
        WebApiClient client = new WebApiClient();
        

        public MainWindow()
        {
            InitializeComponent();
            client.GetRequest();
        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ExceptionLabel.Text != null)
                {
                    ExceptionLabel.Text = "";
                }

                client.stringId = Int32.Parse(InputTextBox.Text);

                client.GetRequest();

                InfoLabel.Text = client.text;

                ButtonLabel.Content = "Vowels quantity: " + stringInfo.SetVowelsQuantity(countVowels.
                                      CountVowelsInLine(client.text)).ToString();

                ButtonLabel2.Content = "Words quantity: " +
                                      stringInfo.SetWordsQuantity
                                      (countWords.CountWordsInLine(client.text)).ToString();
            }
            catch
            {
                ExceptionLabel.Text = "Please enter a number";
            }
        }
    }
}
