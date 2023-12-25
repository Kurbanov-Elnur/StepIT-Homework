insert into Curators ([Name], [Surname])
values
    (N'Anna', N'Smith'),
    (N'Mark', N'Johnson'),
    (N'Eva', N'Brown'),
    (N'William', N'Jones'),
    (N'Susan', N'Miller');

insert into Faculties ([Financing], [Name])
values
    (550000, N'Computer Science'),
    (600000, N'Medicine'),
    (500000, N'Engineering'),
    (450000, N'Business'),
    (700000, N'Arts');

insert into Departments ([Financing], [Name], [FacultyId])
values
    (200000, N'Software Engineering', 1),
    (300000, N'Internal Medicine', 2),
    (150000, N'Marketing', 3),
    (400000, N'Mechanical Engineering', 4),
    (250000, N'English Literature', 5);

insert into Groups ([Name], [Course], [DepartmentId])
values
    (N'Group 1A', 2, 1),
    (N'Group 2B', 3, 2),
    (N'Group 3C', 4, 3),
    (N'Group 4D', 5, 4),
    (N'Group 5E', 1, 5);

insert into GroupsCurators ([CuratorId], [GroupId])
values
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5);

insert into Subjects ([Name])
values
    (N'Computer Networks'),
    (N'Cardiology'),
    (N'Advertising Strategies'),
    (N'Algorithm Design'),
    (N'American Literature');

insert into Teachers ([Name], [Surname], [Salary])
values
    (N'Olivia', N'Wilson', 65000),
    (N'Daniel', N'Moore', 72000),
    (N'Grace', N'Davis', 58000),
    (N'Alexander', N'Johnson', 78000),
    (N'Emma', N'Williams', 67000);

insert into Lectures ([LectureRoom], [SubjectId], [TeacherId])
values
    (N'Room 101', 1, 1),
    (N'Room 202', 2, 2),
    (N'Room 303', 3, 3),
    (N'Room 404', 4, 4),
    (N'Room 505', 5, 5);

insert into GroupsLectures ([GroupId], [LectureId])
values
    (2, 4),
    (3, 2),
    (4, 5),
    (5, 1),
    (1, 3);