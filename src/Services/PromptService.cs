using System;
using System.Collections.Generic;

public static class PromptService
{
    public static List<SimulationPrompt> Prompts = new List<SimulationPrompt>
{
    new SimulationPrompt
    {
        Title = "Overtime Work",
        Message = "You worked extra hours this month.",
        IncomeEffect = 250,
        ExpenseEffect = 0,
        Category = "Income"
    },

    new SimulationPrompt
    {
        Title = "Unexpected Transport Cost",
        Message = "You had to pay for unexpected transport this month.",
        IncomeEffect = 0,
        ExpenseEffect = 80,
        Category = "Expense"
    },

    new SimulationPrompt
    {
        Title = "Freelance Payment",
        Message = "You received a small freelance payment.",
        IncomeEffect = 150,
        ExpenseEffect = 0,
        Category = "Income"
    },

    new SimulationPrompt
    {
        Title = "Grocery Price Increase",
        Message = "Food prices increased this month, so your grocery spending went up.",
        IncomeEffect = 0,
        ExpenseEffect = 60,
        Category = "Expense"
    },

    new SimulationPrompt
    {
        Title = "Freelance Payment",
        Message = "You completed a small freelance job and received extra income.",
        IncomeEffect = 180,
        ExpenseEffect = 0,
        Category = "Income"
    },

    new SimulationPrompt
    {
        Title = "Phone Repair",
        Message = "Your phone needed repair this month.",
        IncomeEffect = 0,
        ExpenseEffect = 120,
        Category = "Expense"
    },

    new SimulationPrompt
    {
        Title = "Part Time Bonus",
        Message = "You received a small bonus from your part time work.",
        IncomeEffect = 150,
        ExpenseEffect = 0,
        Category = "Income"
    },

    new SimulationPrompt
    {
        Title = "Medical Expense",
        Message = "You had to pay for medicine and a health check this month.",
        IncomeEffect = 0,
        ExpenseEffect = 90,
        Category = "Expense"
    },

    new SimulationPrompt
    {
        Title = "Sold Old Item",
        Message = "You sold an old item and earned some extra money.",
        IncomeEffect = 100,
        ExpenseEffect = 0,
        Category = "Income"
    },

    new SimulationPrompt
    {
        Title = "Utility Bill Increase",
        Message = "Your electricity and gas bill increased this month.",
        IncomeEffect = 0,
        ExpenseEffect = 75,
        Category = "Expense"
    }
};
}