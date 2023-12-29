create table Departments(
    [Id] int primary key not null identity(1,1),
    [Financing] money not null check ([Financing] >= 0) default 0,
    [Name] nvarchar(10) not null unique check ([Name] NOT LIKE '[A-Za-z]'),
    [FacultyId] int foreign key references Faculties([Id])
)

create table Faculties(
    [Id] int primary key not null identity(1,1),
    [Name] nvarchar(10) not null unique check ([Name] NOT LIKE '[A-Za-z]'),
)

create table Groups(
    [Id] int primary key not null identity(1,1),
    [Name] nvarchar(10) not null unique check ([Name] NOT LIKE '[A-Za-z]'),
    [Course] int not null check ([Course] >= 1 and [Course] <= 5),
    [DepartmentId] int not null foreign key references Departments([Id])
)

create table GroupsLectures(
    [Id] int primary key not null identity(1,1),
    [GroupId] int not null foreign key references Groups([Id]),
    [LectureId] int not null foreign key references Lectures([Id])
)

create table Lectures(
    [Id] int primary key not null identity(1,1),
    [LectureRoom] nvarchar(max) not null check ([LectureRoom] NOT LIKE '[A-Za-z]'),
    [DayOfWeek] int not null check([DayOfWeek] >= 1 and [DayOfWeek] <= 7),
    [SubjectId] int not null foreign key references Subjects([Id]),
    [TeacherId] int not null foreign key references Teachers([Id])
)

create table Subjects(
    [Id] int primary key not null identity(1,1),
    [Name] nvarchar(20) not null unique check ([Name] NOT LIKE '[A-Za-z]'),
)

create table Teachers(
    [Id] int primary key not null identity(1,1),
    [Name] nvarchar(max) not null check ([Name] NOT LIKE '[A-Za-z]'),
    [Surname] nvarchar(max) check ([Surname] NOT LIKE '[A-Za-z]'),
    [Salary] money not null check ([Salary] > 0)
)