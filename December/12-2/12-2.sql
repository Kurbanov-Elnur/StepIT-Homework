create database Academy;

create table Departments(
    Id int primary key not null identity (1,1),
    Financing money not null check(Financing > 0) default 0,
    Name nvarchar(100) not null unique check (Name NOT LIKE '[A-Za-z]')
);

create table Faculties(
    Id int primary key not null identity (1,1),
    Dean nvarchar(max) not null check (Dean NOT LIKE '[A-Za-z]'),
    Name nvarchar(100) not null unique check (Name NOT LIKE '[A-Za-z]'),
);

create table Groups(
    Id int primary key not null identity (1,1),
    Name nvarchar(100) not null unique check (Name NOT LIKE '[A-Za-z]'),
    Rating int not null check (Rating >= 0 and Rating <= 5),
    Year int not null check (Year >= 1 and Year <= 5)
);

create table Teachers(
    Id int primary key not null identity (1,1),
    EmploymentDate date not null check (EmploymentDate > '01.01.1990'),
    IsAssistant bit not null default 0,
    IsProfessor bit not null default 0,
    Name nvarchar(100) not null check (Name NOT LIKE '[A-Za-z]'),
    Surname nvarchar(100) not null check (Surname NOT LIKE '[A-Za-z]'),
    Position nvarchar(max) not null check (Position NOT LIKE '[A-Za-z]'),
    Premium money not null check (Premium >= 0) default 0,
    Salary money not null check (Salary >= 0),
);

insert into Departments (Financing, Name)
values
    (50000, N'Department of Physics'),
    (75000, N'Department of Computer Science'),
    (100000, N'Department of Mathematics'),
    (60000, N'Department of History'),
    (90000, N'Department of Economics');

insert into Faculties (Dean, Name)
values
    (N'John Dean', N'Faculty of Arts'),
    (N'Alice Director', N'Faculty of Science'),
    (N'Bob Head', N'Faculty of Engineering'),
    (N'Emma Chairperson', N'Faculty of Social Sciences'),
    (N'Michael Coordinator', N'Faculty of Business');

insert into Groups (Name, Rating, Year)
values
    (N'Physics Group 1', 4, 2),
    (N'Computer Science Group 2', 3, 3),
    (N'Mathematics Group 3', 5, 1),
    (N'History Group 4', 2, 4),
    (N'Economics Group 5', 1, 5);

insert into Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Surname, Position, Premium, Salary)
values
    ('1995-03-15', 1, 0, N'John', N'Doe', N'Assistant Professor', 5000, 60000),
    ('2000-07-22', 0, 1, N'Alice', N'Johnson', N'Professor', 8000, 90000),
    ('1998-12-10', 1, 0, N'Bob', N'Smith', N'Assistant Professor', 4000, 55000),
    ('2005-05-03', 0, 0, N'Emma', N'Williams', N'Teacher', 3000, 48000),
    ('1993-09-18', 0, 1, N'Michael', N'Jones', N'Professor', 7000, 75000);