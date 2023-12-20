using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Variety_Interactions.Websites
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = SubmitBtn.UniqueID;


            if (!IsPostBack)
            {
                //adding other regions to the list
                OtherRegionClock.Items.Add("California, US");
                OtherRegionClock.Items.Add("New York, US");
                OtherRegionClock.Items.Add("Madrid, Spain");
                OtherRegionClock.Items.Add("Tokyo, Japan");
                OtherRegionClock.Items.Add("Venice, Italy");

                //getting current time and timezone
                DateTime dateTime = DateTime.Now;
                TimeZoneInfo timeZone = TimeZoneInfo.Local;
                WorldTimeID.Text = $"Current time is {dateTime.ToString("hh:mm tt")} {timeZone.StandardName} ";

                //adding event to radio
                EventRadioBtn.Items.Add("New years Day");
                EventRadioBtn.Items.Add("Valentines Day");
                EventRadioBtn.Items.Add("Independence Day");
                EventRadioBtn.Items.Add("Thanksgiving Day");
                EventRadioBtn.Items.Add("Christmas Day");

            }
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {

            WorldClockOther.Text = "";
            foreach (ListItem item in OtherRegionClock.Items)
            {
                if (item.Selected)
                {
                    // Get the time zone for the selected region
                    TimeZoneInfo selectedTimeZone = GetTimeZone(item.Text);

                    // Calculate the time in the selected time zone
                    DateTime selectedTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, selectedTimeZone);

                    // Display the result
                    WorldClockOther.Text += $"{item.Text}: {selectedTime.ToString("hh:mm tt")} {selectedTimeZone.StandardName}<br/>";

                }
            }

        }
        private TimeZoneInfo GetTimeZone(string region)
        {
            switch (region)
            {
                case "California, US":
                    return TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
                case "New York, US":
                    return TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                case "Madrid, Spain":
                    return TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                case "Tokyo, Japan":
                    return TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
                case "Venice, Italy":
                    return TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                default:
                    return TimeZoneInfo.Local;
            }

        }

        protected void SubmitBtn2_Click(object sender, EventArgs e)
        {
            // Get the selected event from the RadioButtonList
            string selectedEvent = EventRadioBtn.SelectedItem.Text;
            //Get number of days until event
            int daysUntil = DayofEvent(selectedEvent);
            CountDownResultsID.Text = $"<br>There are exactly {daysUntil} days until {selectedEvent}";

        }


        private int DayofEvent(string selectedOption)
        {
            DateTime today = DateTime.Today;
            DateTime eventDay;
            int totalDays = 0;

            if (selectedOption == "New years Day")
            {
                eventDay = new DateTime(today.Year, 1, 1); //Jan 1st
                totalDays = OverallTime(ref eventDay, ref today).Days;
                EventImages.ImageUrl = "~/Images/Bronya_NewYears.png";

            }
            else if (selectedOption == "Valentines Day")
            {
                eventDay = new DateTime(today.Year, 2, 14); //Feb 14th
                totalDays = OverallTime(ref eventDay, ref today).Days;
                EventImages.ImageUrl = "~/Images/Bronya_Valentines.png";
            }
            else if (selectedOption == "Independence Day")
            {
                eventDay = new DateTime(today.Year, 7, 4); // Jul 4th
                totalDays = OverallTime(ref eventDay, ref today).Days;
                EventImages.ImageUrl = "~/Images/Bronya_4thOfJuly.png";
            }
            else if (selectedOption == "Thanksgiving Day")
            {
                eventDay = GetThanksgivingDay(today.Year); // 4th Thursday of Nov
                totalDays = OverallTime(ref eventDay, ref today).Days;
                EventImages.ImageUrl = "~/Images/Bronya_Thanksgiving.png";

            }
            else if (selectedOption == "Christmas Day")
            {
                eventDay = new DateTime(today.Year, 12, 25); //Dec 25th
                totalDays = OverallTime(ref eventDay, ref today).Days;
                EventImages.ImageUrl = "~/Images/Bronya_Christmas.png";
            }

            return totalDays;
        }
        private DateTime GetThanksgivingDay(int year)
        {
            DateTime thanksgivingDay = new DateTime(year, 11, 1);
            int daysUntilThursday = ((int)DayOfWeek.Thursday - (int)thanksgivingDay.DayOfWeek + 7) % 7;
            DateTime fourthThursday = thanksgivingDay.AddDays(daysUntilThursday + 21);
            return fourthThursday;
        }

        private TimeSpan OverallTime(ref DateTime selectedOption, ref DateTime current)
        {
            if (current > selectedOption)
            {
                selectedOption = selectedOption.AddYears(1);
            }

            TimeSpan currentspan = selectedOption - current;
            return currentspan;
        }
    }
}
