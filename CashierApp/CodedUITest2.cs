﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITest.Common.UIMap;
using CashierApp.NegativeTesttingClasses;

namespace CashierApp
{
    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class CodedUITest2
    {
        public CodedUITest2()
        {
        }
        #region global Variables
        private string applink = "https://fgxadjuvantdev.azurewebsites.net";

        BrowserWindow browserWindow;
        #endregion
        [TestMethod]
        public void CodedUITestMethod1()
        {
            //this.UIMap.NegativeLogin();
            //this.UIMap.NegativeSecurityScope();
            //this.UIMap.OpenCashDeskWithoutCashHouse();
            //this.UIMap.OpenCashHouse1();
            this.UIMap.OpenCashDesk();
            //this.UIMap.CloseCashHouseWithoutClosingCashDesk();
            this.UIMap.RecordedMethod1();

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

        public NegativeTestting UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new NegativeTestting();
                }

                return this.map;
            }
        }

        private NegativeTestting map;
    }
}
