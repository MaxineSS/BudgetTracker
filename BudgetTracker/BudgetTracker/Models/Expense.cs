using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Models
{
    public class Expense
    {
        public enum ExpenseCategory
        {
            Food,
            Transportation,
            Household,
            Health,
            Education,
        }

        public ExpenseCategory Category { get; set; }
        public string IconFile { get; set; }

        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string FileName { get; set; }

        public Expense(string name, double amount, DateTime date, ExpenseCategory category, string filename)
        {
            Name = name;
            Amount = amount;
            Date = date;
            Category = category;
            FileName = filename;
        }

        public Expense(double amount, string filename)
        {
            Amount = amount;
            FileName = filename;
        }

        public Expense()
        {

        }

    }
}
