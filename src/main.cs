class main
{
    public static Random random = new Random();
    public static string username = "";
    public static string userID = Guid.NewGuid().ToString();
    public static string ageRange = "";
    public static string gender = "";
    public static string educationLevel = "";
    public static string employmentStatus = "";
    public static string consent = " ";
    public static int num = 0;
    public static int financialConfidence = 0;
    public static int input = 0;
    public static int income = 100;
    public static int expense = 60;
    public static int steps = 12;
    public static int totalExpense = 0;
    public static int totalIncome = 0;
    public static int allowance = 200;
    public static int stepCounter = 0;
    public static int pExpense = 0;
    public static int pIncome = 0;
    public static int acceptedPrompts = 0;
    public static int rejectedPrompts = 0;
    public static List<string> decisionsMade = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine();
        userNameInput();
        userNameCheck();

        while (userNameCheck() == false)
        {
            Console.WriteLine("ERROR: Your username must contain atleast one number.");
            Console.WriteLine();
            userNameInput();
        }
        Console.WriteLine();

        ageRangeInput();
        ageRangeCheck();

        genderInput();
        genderCheck();

        educationInput();
        educationCheck();

        employmentInput();
        employmentCheck();

        financialConfidenceInput();
        financialConfidenceCheck();

        Console.WriteLine(username + ageRange + gender + educationLevel + employmentStatus + financialConfidence);
        Console.WriteLine("Randomly generate ID: " + userID);
        Console.WriteLine("Starting balance: " + allowance);
        Console.WriteLine("Monthly income: " + income);
        Console.WriteLine("Monthly expense: " + expense);
        Console.WriteLine();

        for (stepCounter = 0; stepCounter < steps; stepCounter++)
        {
            num = random.Next(0, PromptService.Prompts.Count);
            SimulationPrompt firstPrompt = PromptService.Prompts[num];

            Console.WriteLine();
            Console.WriteLine("This is step " + (stepCounter + 1));
            Console.WriteLine();
            Console.WriteLine("Do you accept this task? (Invalid input will lead to rejection of task)");
            Console.WriteLine("Task: " + firstPrompt.Title);
            Console.WriteLine("Context: " + firstPrompt.Message);
            Console.WriteLine("Effect on Income: " + firstPrompt.IncomeEffect);
            Console.WriteLine("Effect on Expence: " + firstPrompt.ExpenseEffect);
            Console.WriteLine("Category: " + firstPrompt.Category);
            Console.WriteLine();

            consentInput();

            if (consent == "y" || consent == "Y")
            {
                pExpense = firstPrompt.ExpenseEffect;
                pIncome = firstPrompt.IncomeEffect;
                acceptedPrompts++;
                decisionsMade.Add("Step " + (stepCounter + 1) + ": Accepted - " + firstPrompt.Title);
            }
            else if (consent == "n" || consent == "N")
            {
                pExpense = 0;
                pIncome = 0;
                rejectedPrompts++;
                decisionsMade.Add("Step " + (stepCounter + 1) + ": Rejected - " + firstPrompt.Title);
            }
            else
            {
                Console.WriteLine("Please input a valid input");
                pExpense = 0;
                pIncome = 0;
                rejectedPrompts++;
                decisionsMade.Add("Step " + (stepCounter + 1) + ": Invalid input, rejected - " + firstPrompt.Title);
            }

            applyIncome();
            applyExpense();
            expenseCalculator();
            incomeCalculator();

            Console.WriteLine("Your current balance is " + allowance);
        }

        Console.WriteLine();
        Console.WriteLine("Your Details;");
        Console.WriteLine();
        Console.WriteLine("Name: " + username);
        Console.WriteLine("Your user ID: " + userID);
        Console.WriteLine("Age range: " + ageRange);
        Console.WriteLine("gender: " + gender);
        Console.WriteLine("Highest level of education: " + educationLevel);
        Console.WriteLine("employment status: " + employmentStatus);

        Console.WriteLine();
        Console.WriteLine("Your Summary;");
        Console.WriteLine();
        Console.WriteLine("Total Income: " + totalIncome);
        Console.WriteLine("Total expenses: " + totalExpense);
        Console.WriteLine("Final Balance: " + allowance);
        Console.WriteLine("Number of accepted prompts: " + acceptedPrompts);
        Console.WriteLine("Number of rejected prompts: " + rejectedPrompts);
        Console.WriteLine("List of decisions made: ");
        Console.WriteLine();
    }

    static void applyIncome()
    {
        allowance += income;
        allowance += pIncome;
    }

    static void applyExpense()
    {
        allowance -= expense;
        allowance -= pExpense;
    }

    static void expenseCalculator()
    {
        totalExpense += expense;
        totalExpense += pExpense;
    }

    static void incomeCalculator()
    {
        totalIncome += income;
        totalIncome += pIncome;
    }

    static void consentInput()
    {
        Console.WriteLine("Answer Y/N");
        consent = Console.ReadLine() ?? "";
    }

    static void userNameInput()
    {
        Console.WriteLine("Enter a username (Your username must contain atleast one number)");
        username = Console.ReadLine();
    }

    static bool userNameCheck()
    {
        foreach (char c in username)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }

    static void ageRangeInput()
    {
        Console.WriteLine("What is your age range? (Input 1 - ages 0 to 24, 2 - ages 25 to 44, 3 - ages 45 to 59, 4 - Prefer not to say )");
        input = int.Parse(Console.ReadLine());
    }

    static void ageRangeCheck()
    {
        if (input == 1)
        {
            ageRange = "0 to 24";
        }
        else if (input == 2)
        {
            ageRange = "25 to 44";
        }
        else if (input == 3)
        {
            ageRange = "45 to 59";
        }
        else if (input == 4)
        {
            ageRange = "Prefer not to say";
        }
        else
        {
            Console.WriteLine("Please input a valid value");
            ageRangeInput();
            ageRangeCheck();
        }
        Console.WriteLine();
    }

    static void genderInput()
    {
        Console.WriteLine("What is your gender? (Input 1 - Male, 2 - Female, 3 - Not-binary, 4 - Prefer not to say )");
        input = int.Parse(Console.ReadLine() ?? "0");
    }

    static void genderCheck()
    {
        if (input == 1)
        {
            gender = "Male";
        }
        else if (input == 2)
        {
            gender = "Female";
        }
        else if (input == 3)
        {
            gender = "Non-binary";
        }
        else if (input == 4)
        {
            gender = "Prefer not to say";
        }
        else
        {
            Console.WriteLine("Please input a valid value");
            genderInput();
            genderCheck();
        }
        Console.WriteLine();
    }

    static void educationInput()
    {
        Console.WriteLine("What is your Highest level of education? (Input 1 - Secondary, 2 - Undergraduate, 3 - Master's and above");
        input = int.Parse(Console.ReadLine() ?? "0");
    }

    static void educationCheck()
    {
        if (input == 1)
        {
            educationLevel = "Secondary";
        }
        else if (input == 2)
        {
            educationLevel = " Undergraduate";
        }
        else if (input == 3)
        {
            educationLevel = "Master’s and above";
        }
        else
        {
            Console.WriteLine("Please input a valid value");
            educationInput();
            educationCheck();
        }
        Console.WriteLine();
    }

    static void employmentInput()
    {
        Console.WriteLine("What is your Employment status? (Input 1 - Student, 2 - Employment, 3 - Self-employed, 4 - Unemployed");
        input = int.Parse(Console.ReadLine() ?? "0");
    }

    static void employmentCheck()
    {
        if (input == 1)
        {
            employmentStatus = "Student";
        }
        else if (input == 2)
        {
            employmentStatus = "Employed";
        }
        else if (input == 3)
        {
            employmentStatus = "Self-employed";
        }
        else if (input == 4)
        {
            employmentStatus = "Unemployed";
        }
        else
        {
            Console.WriteLine("Please input a valid value");
            employmentInput();
            employmentCheck();
        }
        Console.WriteLine();
    }

    static void financialConfidenceInput()
    {
        Console.WriteLine("What would you rate your financial confidence on a scale 1-5?");
        input = int.Parse(Console.ReadLine());
    }

    static void financialConfidenceCheck()
    {
        if (input == 1)
        {
            financialConfidence = input;
        }
        else if (input == 2)
        {
            financialConfidence = input;
        }
        else if (input == 3)
        {
            financialConfidence = input;
        }
        else if (input == 4)
        {
            financialConfidence = input;
        }
        else if (input == 5)
        {
            financialConfidence = input;
        }
        else
        {
            Console.WriteLine("Please input a valid value");
            financialConfidenceInput();
            financialConfidenceCheck();
        }
        Console.WriteLine();
    }
}