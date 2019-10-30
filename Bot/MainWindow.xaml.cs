using OpenQA.Selenium;
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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System.Net;
using System.IO;

namespace Bot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IWebDriver webDriver;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ChromeOptions options = new ChromeOptions();
            //proxy = new Proxy();
            //proxy.Kind = ProxyKind.Manual;
            //proxy.IsAutoDetect = false;
            //proxy.HttpProxy =
            //proxy.SslProxy = "127.0.0.1:3330";
            //options.Proxy = proxy;
            //options.AddArgument("ignore-certificate-errors");
            //ChromeDriverService service = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory);
            //         service.HideCommandPromptWindow = true;
            //ChromeOptions option = new ChromeOptions();
            //webDriver = new ChromeDriver(service, option);
            //webDriver.Manage().Window.Maximize();
            //MessageBox.Show("Successfull opened");
        }

        private void Navigate(object sender, RoutedEventArgs e)
        {
            //webDriver.Navigate().GoToUrl(Texxt.Text);
            //webDriver.Navigate().GoToUrl("https://www.copart.com/lotSearchResults/?free=true&query=&searchCriteria=%7B%22query%22:%5B%22*%22%5D,%22filter%22:%7B%22YEAR%22:%5B%22lot_year:%5C%222011%5C%22%22,%22lot_year:%5C%222012%5C%22%22,%22lot_year:%5C%222013%5C%22%22,%22lot_year:%5C%222014%5C%22%22,%22lot_year:%5C%222015%5C%22%22,%22lot_year:%5C%222016%5C%22%22,%22lot_year:%5C%222018%5C%22%22,%22lot_year:%5C%222019%5C%22%22,%22lot_year:%5C%222020%5C%22%22%5D%7D,%22sort%22:%5B%22auction_date_type%20desc%22,%22auction_date_utc%20asc%22%5D,%22watchListOnly%22:false,%22searchName%22:%22%22,%22freeFormSearch%22:false%7D");
            //  ICollection<IWebElement> elements = webDriver.FindElements(By.ClassName("sector-modal"));
            //(webDriver as PhantomJSDriver).GetScreenshot().SaveAsFile("kek.jpg", System.Drawing.Imaging.ImageFormat.Jpeg) ;
            //System.IO.File.WriteAllText("ff.txt",element.Text);
            //MessageBox.Show(elements.Count.ToString());
            //elements.First().Click();
            //(webDriver as PhantomJSDriver).GetScreenshot().SaveAsFile("kek.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //MessageBox.Show("ff");
            //webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            //IWebElement element=  webDriver.FindElement(By.XPath("//a[@dt-idx='8']"));
            //element.Click();
            
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                // Or you can get the file content without saving it
                //string htmlCode = client.DownloadString("http://yoursite.com/page.html");
                //MessageBox.Show("Cool");
                Stream data = client.OpenRead("https://www.copart.com/lotSearchResults/?free=true&query=&searchCriteria=%7B%22query%22:%5B%22*%22%5D,%22filter%22:%7B%22YEAR%22:%5B%22lot_year:%5C%222011%5C%22%22,%22lot_year:%5C%222012%5C%22%22,%22lot_year:%5C%222013%5C%22%22,%22lot_year:%5C%222014%5C%22%22,%22lot_year:%5C%222015%5C%22%22,%22lot_year:%5C%222016%5C%22%22,%22lot_year:%5C%222018%5C%22%22,%22lot_year:%5C%222019%5C%22%22,%22lot_year:%5C%222020%5C%22%22%5D%7D,%22sort%22:%5B%22auction_date_type%20desc%22,%22auction_date_utc%20asc%22%5D,%22watchListOnly%22:false,%22searchName%22:%22%22,%22freeFormSearch%22:false%7D");
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();

                MessageBox.Show(s);
                data.Close();
                reader.Close();
            }
        }
  
        private void Stop(object sender, RoutedEventArgs e)
        {
            //webDriver.Close();
            //MessageBox.Show("Successfull closed");
        }
    }
}
