DateTime today = DateTime.Today;
Console.WriteLine(today);

DateTime threeDaysFromNow = today.AddDays(3);
Console.WriteLine(threeDaysFromNow);

DateTime oneMonthFromNow = today.AddMonths(1);
Console.WriteLine(oneMonthFromNow);

DateTime oneMonthAndThreeDaysFromNow = oneMonthFromNow.AddDays(3);
Console.WriteLine(oneMonthAndThreeDaysFromNow);

DateTime oneYearAndTwoMonthsAgo= today.AddYears(-1).AddMonths(-2);
Console.WriteLine(oneYearAndTwoMonthsAgo);

int currentMonth = today.Month;
Console.WriteLine("Current Month: " + currentMonth);

int currentYear = today.Year;
Console.WriteLine("Current year: " + currentYear);
