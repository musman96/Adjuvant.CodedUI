using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UITest.Common.UIMap;

namespace CashierApp
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        #region global Variables
        private string applink = "https://fgxadjuvantdev.azurewebsites.net";
        #endregion
        BrowserWindow browserWindow;
        [TestMethod]
        public void Login()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

           // IWebDriver driver = new ope();
            BrowserWindow.CurrentBrowser="chrome";
            browserWindow = BrowserWindow.Launch(applink);
            HtmlEdit username = new HtmlEdit(browserWindow);
            HtmlEdit password = new HtmlEdit(browserWindow);
            HtmlButton btnlogin = new HtmlButton(browserWindow);

            username.SearchProperties.Add(HtmlEdit.PropertyNames.Id,"username");
            password.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "password");
            btnlogin.SearchProperties.Add(HtmlButton.PropertyNames.Id,"btn_login");

            //enter username and password in fields1405726200
            Keyboard.SendKeys(username,"admin@fgxplatform.com");
            Playback.PlaybackSettings.DelayBetweenActions = 200;
            Keyboard.SendKeys(password,"Fgx1234!");
            Playback.PlaybackSettings.DelayBetweenActions = 200;
            Mouse.Click(btnlogin);


            OpenCashHouse();

        }
        [TestMethod]
        public void OpenCashHouse()
        {
            /* HtmlDiv menu = new HtmlDiv(browserWindow);
             menu.SearchProperties.Add(HtmlDiv.PropertyNames.Class, "tile-object text-center");
             HtmlHyperlink dropmenu = new HtmlHyperlink(menu);
             dropmenu.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText,"Cashier");*/

            HtmlHyperlink cashier = new HtmlHyperlink(browserWindow);
            cashier.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id,"cashier");

            Mouse.Click(cashier);
            //this.UIMap.RecordedMethod1();
            OpenCashDesk();
        }

        [TestMethod]
        public void OpenCashDesk()
        {
            HtmlHyperlink cashier = new HtmlHyperlink(browserWindow);
            cashier.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "cashier");

            Mouse.Click(cashier);
           /* this.UIMap.OpenCashHouse();
            this.UIMap.OpenCashDesk();
            this.UIMap.PositiveLogin();*/
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
