using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Models
{
    class Budget
    {
        public string BudgetName { get; set; }
        public double Goal { get; set; }
        public DateTime Timeframe { get; set; }
        public List<Expense> Expenses { get; set; }

        public double AmountLeft { get; set; }

        public double AmountSpent { get; set; }



        public Budget(string aBudgetname, double aGoal, DateTime aTimeframe)
        {
            BudgetName = aBudgetname;
            Goal = aGoal;
            Timeframe = aTimeframe;
        }
    }
}
