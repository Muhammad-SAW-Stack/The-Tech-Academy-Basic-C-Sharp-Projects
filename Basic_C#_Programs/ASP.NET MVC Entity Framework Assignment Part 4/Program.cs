using System;

namespace FinalAssignment
{

    public static void Main(string[] args)
    {
        public decimal CalculateQuote(int age, int carYear, string carMake, string carModel, int numSpeedingTickets, bool hasDUI, bool isFullCoverage)
        {
            decimal quote = 50; // Start with a base of $50 per month.
            // This code calculates the quote based on the person's age using an "if" statement.
            if (age <= 18)
            {
                // If person's age is less than or equal to 18, quote greater than or equal to 100.
                quote += 100;
            }
            // "Else if" statement, if the person's age is greater than or equal to 19, but less than or equal to 25.
            else if (age >= 19 && age <= 25)
            {
                // In C#, the "+=" operator is an assignment operator that adds the value on its right to the variable on its left,
                // and then assigns the result back to the left operand. Then add 50.
                quote += 50;
            }
            // "Else if" statement, if the person's age is greater than or equal to 26.
            else if (age >= 26)
            {
                // Then add 25.
                quote += 25;
            }
            // This code calculates a quote based on the year of the car.
            // If carYear is less than 2000, add 25.
            if (carYear < 2000)
            {
                quote += 25;
            }
            // If carYear is greater than 2015, add 25.
            else if (carYear > 2015)
            {
                quote += 25;
            }
            // This code calculates a quote based on the car make. 
            if (carMake == "Porsche")
            {
                // Add 25.
                quote += 25;
            }
            // If the carMake is Porche and carModel is 911 Carrera, add 25
            if (carMake == "Porsche" && carModel == "911 Carrera")
            {
                quote += 25;
            }
            // This code calculates a quote based on the number of speeding tickets the person received.
            quote += numSpeedingTickets * 10;
            // This code calculates a quote based on the person's DUI history.
            if (hasDUI)
            {
                quote *= 1.25m;
            }
            // This code calculates a quote based on a coverage type.
            if (isFullCoverage)
            {
                quote *= 1.5m;
            }
            return quote;
        }
    }
}
