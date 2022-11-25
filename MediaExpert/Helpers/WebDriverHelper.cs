﻿using MediaExpert.WrapperFactory;
using MediaExpert.Extensions;
using OpenQA.Selenium;

namespace MediaExpert.Helper
{
    public static class WebDriverHelper
    {
        public static void WaitAndClick(By by)
        {
            BrowserFactory.Driver.WaitForElement(by).Click();
        }
    }
}