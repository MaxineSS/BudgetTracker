using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewExpenseEntryPage : ContentPage
    {

        public Expense Expense { get; set; }

        public NewExpenseEntryPage()
        {
            InitializeComponent();
            Expense = new Expense
            {

            };
        }


        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}