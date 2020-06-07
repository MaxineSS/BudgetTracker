using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionPage : ContentPage
    {
        public TransactionPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            List<Expense> expenses = new List<Expense>();

            var files = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "*.expenses.txt");
            foreach (var filename in files)
            {
                Expense expense = new Expense
                {
                    Name = File.ReadAllText(filename),
                    FileName = filename,
                    Date = File.GetCreationTime(filename),
                    Amount = Convert.ToDouble(File.ReadAllText(filename)),
                };
                expenses.Add(expense);
            }

        }


        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewExpenseEntryPage())
            {
                BindingContext = new Expense()
            });

        }

        private async void OnListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushModalAsync(new NewExpenseEntryPage
                {
                    BindingContext = (Expense)e.SelectedItem
                });
            }
        }

    }
}