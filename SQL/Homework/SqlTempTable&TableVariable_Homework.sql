
declare @FirstName nvarchar(100)='Antonio'
select  *
from Student 
where FirstName= @FirstName;

declare @Students Table(
StudentId int,
StudentName nvarchar(100),
DateOfBirth DATE
);

insert into @Students(StudentId,StudentName,DateOfBirth)
select Id,FirstName,DateOfBirth
from Student
where Gender = 'F'

select *
from @Students

create table #StudentsTemp (
LastName nvarchar(100),
EnrolledDate Date
)

insert into #StudentsTemp(LastName,EnrolledDate)
select LastName,EnrolledDate
from Student
where Gender='M' and FirstName like'A%'

select *
from #StudentsTemp

select *
from Student
where Len(LastName)=7

select *
from Teacher
where Len(FirstName)<5 and substring(FirstName,1,3)=substring(LastName,1,3)


