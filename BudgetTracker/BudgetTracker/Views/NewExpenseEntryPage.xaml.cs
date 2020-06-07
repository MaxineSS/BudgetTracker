using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

        public ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();


        public NewExpenseEntryPage()
        {
            InitializeComponent();


        }


        private async void SaveButtonClicked(object sender, EventArgs e)
        {
            var name = (Expense)BindingContext;
            if (string.IsNullOrEmpty(name.FileName))
            {
                var filename = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    $"{Path.GetRandomFileName()}.expenses.txt");
                File.WriteAllText(filename, name_entry.Text);
            }

            var amount = (Expense)BindingContext;
            if (string.IsNullOrEmpty(amount.FileName))
            {
                var filename = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    $"{Path.GetRandomFileName()}.expenses.txt");
                File.WriteAllText(filename, amount_entry.Text);
            }

            var date = (Expense)BindingContext;
            if (string.IsNullOrEmpty(date.FileName))
            {
                var filename = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    $"{Path.GetRandomFileName()}.expenses.txt");
                File.WriteAllText(filename, Datelable.Text);
            }

            var category = (Expense)BindingContext;
            if (string.IsNullOrEmpty(category.FileName))
            {
                var filename = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    $"{Path.GetRandomFileName()}.expenses.txt");
                File.WriteAllText(filename, category_entry.Text);
            }

            await Navigation.PopModalAsync();
        }

        private async void CancelButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void OnDateEntrySelected(object sender, DateChangedEventArgs e) => Datelable.Text = e.NewDate.ToString();

    }
}