--Task 1

select Id, Name, Financing from Departments;

--Task 2

select Name as "Group Name", Rating as "Group Rating" from Groups;

--Task 3

select
    Surname,
    Premium / Salary * 100 AS "The percentage of the rate to the surcharge",
    (Salary + Premium) / Salary * 100 AS "The percentage of the salary rate"
from Teachers;

--Task 4

select 'The dean of ' + Name + 'is' + Dean from Faculties

--Task 5

select Surname from Teachers
where IsProfessor >= 1
and Salary > 1050

--Task 6

select Name from Departments
where Financing < 11000 or Financing > 25000

--Task 7

select Name from Faculties
where Name != N'Faculty of Science'

--Task 8

select Surname, Position from Teachers
where IsProfessor = 0

--Task 9

select Surname, Position, Salary, Premium from Teachers
where Premium >= 160 and Premium <= 550

--Task 10

select Surname, Salary from Teachers
where IsAssistant >= 1

--Task 11

select Surname, Position from Teachers
where EmploymentDate < '01.01.2000'

--Task 12

select Name as NameofDepartment from Departments
where Name < 'Department of Software Development'
order by Name

--Task 13

select Surname from Teachers
where IsAssistant >= 1
and Salary + Premium <= 1200

--Task 14

select Name from Groups
where Year = 5
and Rating >= 2 and Rating <= 4

--Task 15

select Surname from Teachers
where IsAssistant >= 1
and (Salary < 550 or Premium < 200)