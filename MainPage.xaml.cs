using System;
using Xamarin.Forms;

namespace CreditCalculator
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            currentDatePicker.Date = DateTime.Now;
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            // Вставьте весь метод OnCalculateClicked из предыдущего примера
        }
    }
}