using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using WebShop.Tricentis.Framework.PageObject.Elements;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class ProductsPage : BasePage
    {
        protected new IWebDriver Driver;
        protected ProductCardElement productCard;  //todo Investigate todo

        public ProductsPage(IWebDriver driver) : base(driver)

        {
            Driver = driver;
            productCard = new ProductCardElement(driver);
        }

        #region Maps of elements

        public readonly By _productCards = By.CssSelector(".item-box");
        public readonly By _addToCart = By.CssSelector(".item-box [data-productid='13'] .button-2");
        //public readonly By _addToCart = By.CssSelector("[data-productid='71'] .button-2");
        public readonly By _successMessage = By.CssSelector("[class='content']");

        #endregion

        public List<IWebElement> GetElements(By selector)  // 1.Общий метод, который получает все карточки
        {
            return Driver.FindElements(selector).ToList(); // - это список всех контейнеров, которые содержат текст
            //                     =
            //var x = Driver.FindElements(_productCards).ToList();
            //return x;
        }
        
        public string[] GetProductCardsNames() //Метод 2. Получаем текст. Отдельный метод, который должен получить текст из тега элемента
        {
            var listOfProductCards = GetElements(_productCards);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++) // method 1
            {
                names[i] = listOfProductCards[i].FindElement(productCard.ProductTitle).Text;
                Console.WriteLine(names[i]);
            }

            //List<string> titles = new List<string>(); // method 2

            //foreach (var card in listOfProductCards)
            //{
            //    titles.Add(card.FindElement(productCard.ProductTitle).Text);
            //}

            return names;
            //return titles.ToArray();
        }

        public string[] GetProductCardsPrice() // Get array of prices from cards
        {
            var listOfProductCards = GetElements(_productCards);
            string[] prices = new string[listOfProductCards.Count];

            for (int i = 0; i < prices.Length; i++) // method 1
            {
                prices[i] = listOfProductCards[i].FindElement(productCard.ActualPrice).Text;
                Console.WriteLine(prices[i]);
            }

            return prices;
        }

        public bool IsSortingAskRight(string[] actualArray)
        {

            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }

        public bool IsSortingDescRight(string[] actualArray)
        {

            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray); 
            Array.Reverse(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }

        public bool IsSortingByPriceAskRight(string[] actualArray)
        {
            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }

        public bool IsSortingByPriceDescRight(string[] actualArray)
        {
            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);
            Array.Reverse(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }




        public string[] SortProductCardsNamesAsc() //My double method to check the sorting
        {
            //_apparelShoesPage.ShowAllCards();
            var listOfProductCards2 = GetElements(_productCards);
            string[] sortNames = new string[listOfProductCards2.Count];

            for (int i = 0; i < sortNames.Length; i++) // method 1
            {
                sortNames[i] = listOfProductCards2[i].FindElement(productCard.ProductTitle).Text;
                //Console.WriteLine(names[i]);
            }
            Array.Sort(sortNames);
            foreach (string s in sortNames)
            {
                Console.WriteLine(s);
            }
            return sortNames;
        }



        public bool AreArraySorted(string[] actualArray, bool asc = true) // Salabonchik's method
        {
            var expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);
            Array.Sort(expectedArray);
            if (!asc)
            {
                Array.Reverse(expectedArray);
            }

            return actualArray.Equals(expectedArray);
        }

        //public string[] SortProductCardsNamesAsc()
        //{
        //    string[] sortAsc = GetProductCardsNames();

        //    Array.Sort(sortAsc);
        //    foreach (string s in sortAsc)
        //    {
        //        Console.WriteLine(s);
        //    }

        //    return sortAsc;
        //}






        //public string[]
        //    GetProductCardsNamesDesc()
        //{
        //    var listOfProductCards = GetElements(_productCards);
        //    string[] names = new string[listOfProductCards.Count];

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = listOfProductCards[i].FindElement(productCard.ProductTitle).Text;
        //        //Console.WriteLine(names[i]);
        //    }

        //    return names;
        //}
        
        public string[] SortProductCardsNamesDesc()
        {
            var listOfProductCards3 = GetElements(_productCards);
            string[] sortNamesDesc = new string[listOfProductCards3.Count];

            for (int i = 0; i < sortNamesDesc.Length; i++) // method 1
            {
                sortNamesDesc[i] = listOfProductCards3[i].FindElement(productCard.ProductTitle).Text;
                //Console.WriteLine(names[i]);
            }
            Array.Sort(sortNamesDesc);
            Array.Reverse(sortNamesDesc);
            foreach (string s in sortNamesDesc)
            {
                Console.WriteLine(s);
            }
            return sortNamesDesc;
        }
        //public string[] SortProductCardsNamesDesc()
        //{
        //    string[] sortDesc = GetProductCardsNames();

        //    Array.Reverse(sortDesc);
        //    foreach (string s in sortDesc)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    return sortDesc;
        //}

        public void ClickAddToCartButton()
        {
            Driver.FindElement(_addToCart).Click();
        }

        //public bool IsSuccessMessageExists()
        //{
        //    try
        //    {
        //        //return Driver.FindElement(_successMessage).Displayed;

        //        new WebDriverWait(Driver, TimeSpan.FromSeconds(2000)).Until(condition: ExpectedConditions.PresenceOfAllElementsLocatedBy(_successMessage));
        //        return Driver.FindElement(_successMessage).Displayed;
        //    }
        //    catch (NoSuchElementException e)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        bool IsElementExists(By selector) // - проверяем наличие элемента - вынести в отдельный tool
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
                wait.Until(d => IsElementDisplayed(selector));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        bool IsElementDisplayed(By selector)
        {
            try
            {
                return Driver.FindElement(selector).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsSuccessMessageExists()
        {

            return IsElementExists(_successMessage);
            //try
            //{

            //    //new WebDriverWait(Driver, TimeSpan.FromSeconds(10))
            //        //.Until(condition: ExpectedConditions.ElementIsVisible(_successMessage));

            //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            //    wait.Until(d => d.FindElement(_successMessage).Displayed); !!!!!!!!!!!!!!!!!!!!!!!!!!
            //    return true;

            //}
            //catch (NoSuchElementException)
            //{
            //    return false;
            //}
        }

    }
}