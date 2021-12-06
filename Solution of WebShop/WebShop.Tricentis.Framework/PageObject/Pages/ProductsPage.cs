using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
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

        private readonly By _productCards = By.CssSelector(".item-box");

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
    }
}