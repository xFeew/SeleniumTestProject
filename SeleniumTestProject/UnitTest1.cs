using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestProject
{
    [TestFixture()]
    public class Tests
    {
        //URL formularza
        string test_url = "https://lamp.ii.us.edu.pl/~mtdyd/zawody/";
        //Sciezka do chromedriver - jesli testy nie dzialaja, mozliwe ze tu tkwi przyczyna, nalezy sprawdzic sciezke w jakiej mamy zainstalowane Google Chrome i chromedriver (powinny byc umieszczone w tym samym katalogu)
        ChromeDriver driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
        //bool do oblsugi alertow
        private bool accAlert = true;

        [OneTimeSetUp]
        public void startBrowser()
        {
            driver.Manage().Window.Maximize();
        }

        //Testy, przykladowe dane ktorymi zostanie uzupelniony formularz
        [Test]
        [TestCase("Jan", "Kowalski", "05-05-0000", true, true)]
        [TestCase("Jan", "Nowak", "Piętnasty Tego Roku", true, false)]
        [TestCase("Imię", "Nazwisko", "15 V 2000", false, true)]
        [TestCase("Jan", "Kowalski", "11-12-1998", false, false)]
        [TestCase("Jan!@#!@#", "Kowa1231!!lski", "12-12-2006", false, true)]
        [TestCase("Jan", "Kowalski", "15062000", true, true)]
        [TestCase("z", "z", "15-06-1950", false, true)]
        [TestCase("Jan", "Kowalski", "XD", true, false)]
        [TestCase("Jan", "Kowalski", "15/15/15", true, true)]
        [TestCase("Jan", "Kowalski", "-10000", true, true)]
        [TestCase("Jan", "Kowalski", "!@#)%*(!@&%)!@", true, true)]
        [TestCase("Jan", "Kowalski", "12-31-2000", true, true)]
        [TestCase("Jan", "xD", "31-12-2020", false, false)]
        [TestCase("ـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـة", "Jan", "05-05-0000", false, true)]
        [TestCase("--------------B15x", "Nowak", "Piętnasty Tego Roku", true, false)]
        [TestCase("Imię", "2+2=1", "15 V 2000", false, true)]
        [TestCase(":D", "Kowalski", "11-12-1998", false, false)]
        [TestCase("Jan!@#!@#", "Kowa1231!!lski", "12-12-2006", true, false)]
        [TestCase("Jan", "Kowalski", "15062000", true, true)]
        [TestCase("z", "z", "15-06-1950", true, true)]
        [TestCase("*****", "***", "XD", false, false)]
        [TestCase("-1", "Kowalski", "15/15/15", true, true)]
        [TestCase("'okoń'; Select * from password_table;", "Kowalski", "-10000", true, true)]
        [TestCase("var Nazwisko = Wielbłąd;", "Kowalski analiza", "!@#)%*(!@&%)!@", true, true)]
        [TestCase("Jan", "Kowalski", "12-31-2000", true, true)]
        [TestCase("Jan", "panda5", "31-12-2020", true, true)]
        [TestCase("J@n", ":-D", "1a2b3c", false, true)]

        public void Testowanie(string firstname, string lastname, string date, bool rodzice, bool lekarz)
        {
            //Przejscie do strony
            driver.Url = test_url;
            driver.Navigate().GoToUrl(test_url);

            //Znalezienie odpowiednich elementow w formularzu do uzupelnienia
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys(firstname);
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys(lastname);
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys(date);

            //Warunki odpowiedzialne za odpowiednie zaznaczanie CheckBox w formularzu
            if (rodzice)
            {
                driver.FindElement(By.Id("rodzice")).Click();
            }
            if (lekarz)
            {
                driver.FindElement(By.Id("lekarz")).Click();
            }

            driver.FindElement(By.CssSelector("[class='btn btn-default']")).Click();

            //Informacja zwrotna dla uzytkownika, wyniki testow
            Console.WriteLine("Test zakonczony, wynik:");
            Console.WriteLine(handleAlert());
            Console.WriteLine(handleAlert());
        }

        //Obsluga Alert'ow
        private string handleAlert()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (accAlert = true)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }

                return alertText;
            }
            finally
            {
                accAlert = true;
            }
        }

        //Zakonczenie testow
        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
            System.Threading.Thread.Sleep(2000);
        }
    }
}