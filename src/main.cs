class main
{
    public static string username = "";
    public static string userID = Guid.NewGuid().ToString();
    public static string ageRange = "";
    public static string gender = "";
    public static string educationLevel = "";
    public static string employmentStatus = "";
    public static int financialConfidence = 0;
    public static int input = 0;

    static void Main(string[] args)
    {
        userNameInput();

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
    }

    static void userNameInput()
    {
        Console.WriteLine("Enter a username");
        username = Console.ReadLine();
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
        input = int.Parse(Console.ReadLine() ?? "0");
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