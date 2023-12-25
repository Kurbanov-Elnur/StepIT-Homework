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