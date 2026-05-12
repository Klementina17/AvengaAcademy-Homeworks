using Exercise01.BaseEntity;
using Exercise01.Models;

User student1 = new Student()
{
    Id = 123,
    Name = "Bob",
    UserName = "BobskyB",
    Password = "BobB12",
    Grades=new List<int> { 5,4,5,4,5}
};
User student2 = new Student()
{
    Id = 456,
    Name = "John",
    UserName = "JohnB",
    Password = "JohnB34",
    Grades=new List<int> { 4,3,5,4,5}
};

User teacher1 = new Teacher()
{
    Id = 555,
    Name = "Tanja",
    UserName = "TanjaB",
    Password = "TanjB345",
    Subject="Math"
};

User teacher2 = new Teacher()
{
    Id = 777,
    Name = "Tatijana",
    UserName = "TatijanaG",
    Password = "TatijanaG45",
    Subject="English"
};

student1.PrintUser();
student2.PrintUser();
teacher1.PrintUser();
teacher2.PrintUser();


