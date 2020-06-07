using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using static Android.Icu.Util.ULocale;
using static BudgetTracker.Models.Expense;

namespace BudgetTracker.ViewModels
{
    public class ExpenseViewModel : INotifyPropertyChanged
    {

        string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                if (name == value)
                    return;
                name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        DateTime date;
        public DateTime DateTime
        {
            get => date;
            set
            {   if (date == value)
                    return;
                date = value;
                OnPropertyChanged(nameof(date));

            }
        }

        public ExpenseCategory category;
        public ExpenseCategory Category
        {
            get => category;
            set
            {
                if (category == value)
                    return;
                Category = value;
                OnPropertyChanged(nameof(category));
            }
        }
        

        double amount;
        public double Amount
        {
            get => amount;
            set
            {
                if (amount == value)
                    return;
                amount = value;
                OnPropertyChanged(nameof(amount));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
