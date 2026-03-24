// Make a method called AgeCalculator
// The method will have one input parameter, your birthday date
// The method should return your age
// Show the age of a user after he inputs a date
using System.Threading.Channels;

static int AgeCalucalator(DateTime birthday)
{
    DateTime today = DateTime.Today;

    int age = today.Year - birthday.Year;

    DateTime thisYearBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);

    if (today < thisYearBirthday)
    {
        age--;
    }
    return age; 
}

string myBirthdayDate = "05.06.1999";
DateTime birthdayDate = DateTime.Parse(myBirthdayDate);
Console.WriteLine(AgeCalucalator(birthdayDate));