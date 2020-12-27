using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestProject
{
    [TestFixture()]
    public class Tests
    {

        string test_url = "https://lamp.ii.us.edu.pl/~mtdyd/zawody/";
        ChromeDriver driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");

        [OneTimeSetUp]
        public void startBrowser()
        {

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1() //Test 1
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan");
            nazwisko.SendKeys("Kowalski");
            data.SendKeys("05-05-0000");
            rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;



            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);


            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test2() //Test 2
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan123");
            nazwisko.SendKeys("Kowalski123");
            data.SendKeys("05-05-1998");
            rodzice.Click();
            //lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test3() //Test 3
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan");
            nazwisko.SendKeys("Kowalski");
            data.SendKeys("11-11-1998");
            //rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test4() //Test 4
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan");
            nazwisko.SendKeys("Kowalski");
            data.SendKeys("11-11-2003");
            //rodzice.Click();
            //lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test5() //Test 5
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan");
            nazwisko.SendKeys("Kowalski");
            data.SendKeys("11-11-2011");
            rodzice.Click();
            //lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }

        [Test]
        public void Test6() //Test 6
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("ـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـة");
            nazwisko.SendKeys("ـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـةـة");
            data.SendKeys("X-d-d");
            rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }

            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test7() //Test 7
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("1-2-3");
            nazwisko.SendKeys("3-4-5");
            data.SendKeys("1-2-2-3");
            rodzice.Click();
            //lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test8() //Test 8
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("var Nazwisko = Wielbłąd;");
            nazwisko.SendKeys("(!*#^%$!)@*%");
            data.SendKeys("30-30-3030");
            rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test9() //Test 9
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("'okoń' ; Select * from password_table;");
            nazwisko.SendKeys("zxcasd");
            data.SendKeys("15 V 2000");
            rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }

            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }

        [Test]
        public void Test10() //Test 10
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan Nowak");
            nazwisko.SendKeys("polecony");
            data.SendKeys("Zdanie jako data? czemu nie.");
            rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }

        [Test]
        public void Test11() //Test 11
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Fajne");
            nazwisko.SendKeys("Te");
            data.SendKeys("Testy");
            //rodzice.Click();
            // lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }

        [Test]
        public void Test12() //Test 12
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("x");
            nazwisko.SendKeys("d");
            data.SendKeys("d");
            //rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test13() //Test 13
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys(":D");
            nazwisko.SendKeys("100%");
            data.SendKeys("00-99-(-1)*0");
            //rodzice.Click();
            //lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test14() //Test 14
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan");
            nazwisko.SendKeys("Nowak");
            data.SendKeys("01-01-2002");
            rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }
        [Test]
        public void Test15() //Test 15
        {
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan");
            nazwisko.SendKeys("Nowak");
            data.SendKeys("01-01-2004");
            rodzice.Click();
            lekarz.Click();
            sendForm.Click();

            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;
            Boolean condition = false;
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }

        [Test]
        public void Test16() //Test 16
        {
            Boolean condition = false;
            driver.Url = test_url;

            IWebElement imie = driver.FindElement(By.CssSelector("[id='inputEmail3']"));
            IWebElement nazwisko = driver.FindElement(By.CssSelector("[id='inputPassword3']"));
            IWebElement data = driver.FindElement(By.CssSelector("[id='dataU']"));
            IWebElement rodzice = driver.FindElement(By.CssSelector("[id='rodzice']"));
            IWebElement lekarz = driver.FindElement(By.CssSelector("[id='lekarz']"));
            IWebElement sendForm = driver.FindElement(By.CssSelector("[class='btn btn-default']"));

            imie.SendKeys("Jan");
            nazwisko.SendKeys("Nowak");
            data.SendKeys("12-12-1995");
            //rodzice.Click();
            //lekarz.Click();
            sendForm.Click();


            driver.SwitchTo().Alert().Accept();
            string AlertText = driver.SwitchTo().Alert().Text;

            System.Threading.Thread.Sleep(100);
            if (AlertText.Equals("Dorosly") || AlertText.Equals("Mlodzik") || AlertText.Equals("Junior") || AlertText.Equals("Senior") || AlertText.Equals("Brak kwalifikacji"))
            {
                condition = true;
            }
            else if (AlertText.Equals("Blad danych"))
            {
                condition = false;
            }
            Assert.True(condition);

            Console.WriteLine("test zakonczony");
        }




        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
            System.Threading.Thread.Sleep(2000);
        }
    }
}