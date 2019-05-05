using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
                Browser.Manage().Window.Maximize();
                Browser.Navigate().GoToUrl("http://google.com");

                IWebElement SearchInput = Browser.FindElement(By.Name("q"));
                SearchInput.SendKeys("как вырастить гомункула" + OpenQA.Selenium.Keys.Enter);
            }
            catch (Exception e1) { MessageBox.Show("Данная версия selenium работает только с 74 весией GoogleChrome. Обновите браузер.  " + e1); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }
    }
}
