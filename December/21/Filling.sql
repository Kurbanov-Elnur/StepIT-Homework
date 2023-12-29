insert into Faculties ([Name])
values
    ('Engineering'),
    ('Science'),
    ('Business'),
    ('Arts'),
    ('Health');

insert into Departments ([Financing], [Name], [FacultyId])
values
    (150000, 'Computer Science', 1),
    (200000, 'Mechanical Engineering', 2),
    (180000, 'Business Administration', 3),
    (220000, 'History and Literature', 4),
    (190000, 'Nursing and Health Sciences', 5);

insert into Lectures ([LectureRoom], [DayOfWeek], [SubjectId], [TeacherId])
values
    ('PhysicsLab', 1, 3, 4),
    ('ChemistryLab', 2, 1, 2),
    ('HistoryHall', 3, 5, 1),
    ('MathRoom', 4, 2, 3),
    ('BiologyLab', 5, 4, 5);

insert into  GroupsLectures ([GroupId], [LectureId])
values (1, 3), (2, 2), (3, 5), (4, 1), (5, 4);


insert into Subjects ([Name])
values ('Math'), ('Physics'), ('Marketing'), ('History'), ('Biology');

insert into Teachers ([Name], [Surname], [Salary])
values
    ('John', 'Doe', 50000),
    ('Jane', 'Smith', 60000),
    ('David', 'Johnson', 55000),
    ('Emily', 'Williams', 62000),
    ('Michael', 'Jones', 58000);

insert into Groups ([Name], [Course], [DepartmentId])
values
    ('Engineering-101', 1, 1),
    ('Science-202', 2, 2),
    ('Business-303', 3, 3),
    ('Arts-404', 4, 4),
    ('Health-505', 5, 5);

insert into Lectures ([LectureRoom], [DayOfWeek], [SubjectId], [TeacherId])
values
    ('PhysicsLab', 1, 3, 4),
    ('ChemistryLab', 2, 1, 2),
    ('HistoryHall', 3, 5, 1),
    ('MathRoom', 4, 2, 3),
    ('BiologyLab', 5, 4, 5);

insert into GroupsLectures ([GroupId], [LectureId])
values (1, 3), (2, 2), (3, 5), (4, 1), (5, 4);