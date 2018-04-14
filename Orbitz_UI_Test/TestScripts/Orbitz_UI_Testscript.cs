using Demo_TestFrameWork.ComponentHelper;
using Demo_TestFrameWork.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Orbitz_UI_Test.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orbitz_UI_Test.TestScripts
{
    [TestClass]
    public class Orbitz_UI_Testscript
    {
        [TestCategory("POM")]
        [TestMethod]
        public void User_Can_Search_Vacation_Rental()
        {
            Home hp = new Home(ObjectRepository.Driver);
            VacationRentals vr = hp.NavigateToVacationRentals();
            vr.SearchVacationRentals("Central Park, New York, New York", "09/19/2018", "09/23/2018", 2);
            Assert.AreEqual("Central Park Hotel Search Results | Orbitz", WindowHelper.GetPageTitle());
        }

        [TestCategory("POM")]
        [TestMethod]
        public void User_Can_Search_Rental_Car_With_Advanced_Options()
        {
            Home hp = new Home(ObjectRepository.Driver);
            Cars cars = hp.NavigateToCars();
            cars.SearchForRentalCarWithAdvancedOptions("LAX", "07/06/2018", 28, "07/09/2018", 12);
            CheckBoxHelper.CheckOnCheckBox(cars.InfantSeatChbx);
            CheckBoxHelper.CheckOnCheckBox(cars.ToddlerSeatChbx);
            CheckBoxHelper.CheckOnCheckBox(cars.NavigationSystemChbx);
            ButtonHelper.ClickButton(cars.SearchCarBtn);
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[@title='Los Angeles, CA (LAX-Los Angeles Intl.)']")));
        }
    }
}
