create database Academy;
go;
use Academy;


create table Groups(
    Id int primary key identity(1, 1),
    Name nvarchar(10) not null UNIQUE check(Name <> '' AND Name NOT LIKE N'%[^а-яА-Яa-zA-Z]%'),
    Rating int not null check (Rating >= 0 and Rating <= 5),
    Kurs int not null check (Kurs >= 1 and Kurs <= 5),
);

create table Departments(
    Id int primary key identity(1, 1),
    Financing money not null check ( Financing > 0) default 0,
    Name nvarchar(10) not null UNIQUE check(Name <> '' AND Name NOT LIKE N'%[^а-яА-Яa-zA-Z]%'),
);

create table Faculties(
    Id int primary key identity(1, 1),
    Name nvarchar(10) not null UNIQUE check(Name <> '' AND Name NOT LIKE N'%[^а-яА-Яa-zA-Z]%'),
);

create table Teachers(
    Id int primary key identity(1, 1),
    EmploymentDate date not null check (EmploymentDate > '01.01.1990'),
    Name nvarchar(30) not null UNIQUE check(Name <> '' AND Name NOT LIKE N'%[^а-яА-Яa-zA-Z]%'),
    Surname nvarchar(30) not null UNIQUE check(Surname <> '' AND Surname NOT LIKE N'%[^а-яА-Яa-zA-Z]%'),
    Premium money not null check (Premium > 0) default 0,
    Salary money not null check (Salary > 0),
);