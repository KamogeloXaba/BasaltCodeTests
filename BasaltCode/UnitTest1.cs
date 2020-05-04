using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasaltCode
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void BasaltTests()
        {
            // Accessing the site
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://basalt.co/");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }

        [TestMethod]

        public void BasaltHomepage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://basalt.co/");
            driver.Manage().Window.Maximize();

            //Title
            Assert.IsTrue(driver.Title.Contains("Basalt.co - Intentional Technology"));

            //Message
            driver.FindElement(By.CssSelector("#__next>div>header>div.nav__bar>nav>ul>li:nth-child(1)>a")).Click();
            var divMessage = driver.FindElement(By.CssSelector("#__next>div>section.styles__IntroSliderStyled-elawKH.kgWeGi>div.slide.slide--current.animated.animatedFadeInUp.fadeInUp>div.hero.hero__one>p"));
            Assert.IsTrue(divMessage.Text.Contains("INTENTIONAL TECHNOLOGY"));

            //Home page contains social media logos
            var facebook = driver.FindElement(By.ClassName("facebook__icon"));
            Assert.IsNotNull(facebook);

            var instagram = driver.FindElement(By.CssSelector("#__next>div>section.styles__IntroSliderStyled-elawKH.kgWeGi>div.intro__footer>div>ul>li:nth-child(2)>a>svg"));
            Assert.IsNotNull(instagram);

            var twitter = driver.FindElement(By.CssSelector("#__next>div>section.styles__IntroSliderStyled-elawKH.kgWeGi>div.intro__footer>div>ul>li:nth-child(3)>a>svg"));
            Assert.IsNotNull(twitter);

            var linkedin = driver.FindElement(By.CssSelector("#__next>div>section.styles__IntroSliderStyled-elawKH.kgWeGi>div.intro__footer>div>ul>li:nth-child(4)>a>svg"));
            Assert.IsNotNull(linkedin);

            var medium = driver.FindElement(By.CssSelector("#__next>div>section.styles__IntroSliderStyled-elawKH.kgWeGi>div.intro__footer>div>ul>li:nth-child(5)>a>svg"));
            Assert.IsNotNull(medium);

            var github = driver.FindElement(By.CssSelector("#__next>div>section.styles__IntroSliderStyled-elawKH.kgWeGi>div.intro__footer>div>ul>li:nth-child(6)>a>svg"));
            Assert.IsNotNull(github);

            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void BasaltAboutPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://basalt.co/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#__next>div>header>div.nav__bar>nav>ul>li:nth-child(2)>a")).Click();
            Thread.Sleep(3000);

            //Contact via email
            try
            {
                driver.FindElement(By.ClassName("link")).Click();
                Thread.Sleep(3000);

            }
            catch(Exception ex)
            {
                Thread.Sleep(2000);
            }
            driver.Close();
            driver.Quit();

        }


    }
}
