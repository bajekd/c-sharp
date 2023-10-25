using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleShoppingList
{
    public class Specs
    {
        IWebDriver driver;
        IWebElement header, shopping_list, shopping_list_button, shopping_list_title, item, item_button;
        String page_title;
        int number_of_li_elements;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:58386/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void chwila_prawdy()
        {
            page_title = driver.Title;
            header = driver.FindElement(By.XPath("//div//h1"));
            shopping_list = driver.FindElement(By.Id("shoppingListName"));
            shopping_list_button = driver.FindElement(By.Id("shoppingListButton"));

            shopping_list_title = driver.FindElement(By.XPath("//div[2]//h1"));
            item = driver.FindElement(By.Id("newItemName"));
            item_button = driver.FindElement(By.Id("newItemButton")); ;

            Assert.AreEqual("Shopping List", page_title);
            Assert.AreEqual("Lista zakupów", header.Text);
            Assert.AreEqual("Tu wpisz nazwę nowej listy", shopping_list.GetAttribute("placeholder"));
            Assert.AreEqual("text", shopping_list.GetAttribute("type"));

            //Przy samych białych znakach przycisk "Dodaj" powinien nie działać - lista zakupów nie zostanie dodana
            shopping_list.SendKeys("      ");
            shopping_list_button.Click();
            Thread.Sleep(1500);

            //Stwórz listę zakupów o nazwie "Owoce"
            shopping_list.SendKeys("Owoce");
            shopping_list_button.Click();
            Thread.Sleep(3000);

            Assert.AreEqual("Owoce", shopping_list_title.Text);
            Assert.AreEqual("Tu wpisz nazwę przedmiotu", item.GetAttribute("placeholder"));
            Assert.AreEqual("text", item.GetAttribute("type"));

            //Dodawanie przykłądowych produktów do utworzonej listy zakupów
            item.SendKeys("Jabłka x2kg");
            item_button.Click();
            Thread.Sleep(1500);
            item.SendKeys("Banany x6");
            item_button.Click();
            Thread.Sleep(1500);
            item.SendKeys("Truskawki x3,5kg");
            item_button.Click();
            Thread.Sleep(1500);
            //Przy samych białych znakach przycisk "Dodaj" powinien nie działać - przedmiot nie zostanie dodany
            item.SendKeys("      ");
            item_button.Click();

            number_of_li_elements = driver.FindElements(By.XPath("//div[2]//ul//li")).Count;
            Assert.AreEqual(3, number_of_li_elements);

            //Odznaczenie i usunięcie przedmiotu
            driver.FindElement(By.XPath("//div[2]//ul/li[1]//button[2]")).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("checked", driver.FindElement(By.Id("item_0")).GetAttribute("class"));

            driver.FindElement(By.XPath("//div[2]//ul/li[1]//button[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[2]//ul/li[2]//button[1]")).Click();
            Thread.Sleep(2000);

            number_of_li_elements = driver.FindElements(By.XPath("//div[2]//ul//li")).Count;
            Assert.AreEqual(2, number_of_li_elements);
        }

        [TearDown]

        public void CloseBrowser()
        {
            driver.Close();
        }

    }

    internal class Int
    {
    }
}
