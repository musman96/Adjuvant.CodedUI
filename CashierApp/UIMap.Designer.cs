﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CashierApp
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// NegativeOPenCashDeskWithoutCashHouse
        /// </summary>
        public void NegativeOPenCashDeskWithoutCashHouse()
        {
            #region Variable Declarations
            WinControl uIAdjuvantQAHomeOperaApplication = this.UIAdjuvantQAHomeOperaWindow.UIAdjuvantQAHomeOperaApplication;
            #endregion

            // Click 'Adjuvant QA | Home - Opera' Application
            Mouse.Click(uIAdjuvantQAHomeOperaApplication, new Point(159, 231));

            // Click 'Adjuvant QA | Home - Opera' Application
            Mouse.Click(uIAdjuvantQAHomeOperaApplication, new Point(172, 458));
        }
        
        #region Properties
        public UIAdjuvantQAHomeOperaWindow UIAdjuvantQAHomeOperaWindow
        {
            get
            {
                if ((this.mUIAdjuvantQAHomeOperaWindow == null))
                {
                    this.mUIAdjuvantQAHomeOperaWindow = new UIAdjuvantQAHomeOperaWindow();
                }
                return this.mUIAdjuvantQAHomeOperaWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIAdjuvantQAHomeOperaWindow mUIAdjuvantQAHomeOperaWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIAdjuvantQAHomeOperaWindow : WinWindow
    {
        
        public UIAdjuvantQAHomeOperaWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Adjuvant QA | Home - Opera";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_1";
            this.WindowTitles.Add("Adjuvant QA | Home - Opera");
            #endregion
        }
        
        #region Properties
        public WinControl UIAdjuvantQAHomeOperaApplication
        {
            get
            {
                if ((this.mUIAdjuvantQAHomeOperaApplication == null))
                {
                    this.mUIAdjuvantQAHomeOperaApplication = new WinControl(this);
                    #region Search Criteria
                    this.mUIAdjuvantQAHomeOperaApplication.SearchProperties[UITestControl.PropertyNames.Name] = "Adjuvant QA | Home - Opera";
                    this.mUIAdjuvantQAHomeOperaApplication.SearchProperties[UITestControl.PropertyNames.ControlType] = "Application";
                    this.mUIAdjuvantQAHomeOperaApplication.WindowTitles.Add("Adjuvant QA | Home - Opera");
                    #endregion
                }
                return this.mUIAdjuvantQAHomeOperaApplication;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIAdjuvantQAHomeOperaApplication;
        #endregion
    }
}
