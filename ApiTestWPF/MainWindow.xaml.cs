using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace ApiTestWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
           
            
            

            
            
        }

        private void CityCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (CityCb.SelectedIndex == 0)
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                //ответ от сервера
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string response = reader.ReadToEnd();
                WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                TextBoxxx.Text = response;
                tb1.Text = weatherResponse.Name;
                tb2.Text = weatherResponse.Main.Temp.ToString();
                ///////////
            }
            if (CityCb.SelectedIndex == 1)
            {
                string urlK = "https://api.openweathermap.org/data/2.5/weather?q=Kazan&appid=952ad2d1124a5544bf641caaac0c357f&units=metric";
                HttpWebRequest reqK = (HttpWebRequest)WebRequest.Create(urlK);
                //ответ от сервера
                HttpWebResponse resK = (HttpWebResponse)reqK.GetResponse();
                StreamReader readerK = new StreamReader(resK.GetResponseStream());
                string responseK = readerK.ReadToEnd();
                WeatherResponse weatherResponseK = JsonConvert.DeserializeObject<WeatherResponse>(responseK);
                TextBoxxx.Text = responseK;
                tb1.Text = weatherResponseK.Name;
                tb2.Text = weatherResponseK.Main.Temp.ToString();
            }
            if (CityCb.SelectedIndex == 2)
            {
                string urlM = "https://api.openweathermap.org/data/2.5/weather?q=Moscow&appid=952ad2d1124a5544bf641caaac0c357f&units=metric";
                HttpWebRequest reqM = (HttpWebRequest)WebRequest.Create(urlM);
                //ответ от сервера
                HttpWebResponse resM = (HttpWebResponse)reqM.GetResponse();
                StreamReader readerM = new StreamReader(resM.GetResponseStream());
                string responseM = readerM.ReadToEnd();
                WeatherResponse weatherResponseM = JsonConvert.DeserializeObject<WeatherResponse>(responseM);
                TextBoxxx.Text = responseM;
                tb1.Text = weatherResponseM.Name;
                tb2.Text = weatherResponseM.Main.Temp.ToString();
            }
        }
    }
}