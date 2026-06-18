public class SimulationPrompt
{
    public string title;
    public string message;
    public int incomeEffect;
    public int expenseEffect;
    public string category;

    public string Title
    {
        get{return title;}
        set{title = value;}
    }

    public string Message
    {
        get{return message;}
        set{message = value;}
    }

    public int IncomeEffect
    {
        get{return incomeEffect;}
        set{incomeEffect = value;}
    }

    public int ExpenseEffect
    {
        get{return expenseEffect;}
        set{expenseEffect = value;}
    }

    public string Category
    {
        get{return category;}
        set{category = value;}
    }


}