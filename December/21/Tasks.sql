--Task 1

select COUNT(*) as TeachersCount from Teachers T
inner join Departments D on T.Id = D.Id
where D.Name = 'Software Development';

--Task 2

select COUNT(*) as LecturesCount from Lectures L
inner join Teachers T on L.TeacherId = T.Id
where T.Name = 'Dave McQueen';

--Task 3

select COUNT(*) as ClassesCount from Lectures
where LectureRoom = 'D201';

--Task 4

select LectureRoom, COUNT(*) as LecturesCount from Lectures
group by LectureRoom;

--Task 5

select COUNT(distinct GL.Id) as StudentsCount from GroupsLectures GL
inner join Lectures L on GL.Id = L.Id
inner join Teachers T on L.TeacherId = T.Id
where T.Name = 'Jack Underhill';


--Task 6

select AVG(Salary) as AverageSalary from Teachers T
inner join Departments D on T.Id = D.Id
inner join Faculties F on D.FacultyId = F.Id
where F.Name = 'Computer Science';

--Task 7

select MIN(StudentsCount) as MinStudents, MAX(StudentsCount) as MaxStudents
from (
    select G.Id, G.Name, COUNT(GL.Id) as StudentsCount
    from Groups G
    inner join GroupsLectures GL on G.Id = GL.GroupId
    group by G.Id, G.Name
) as GroupStudents;

--Task 8

select AVG(Financing) as AverageFinancing from Departments;

--Task 9

select T.Name + ' ' + T.Surname as FullName, COUNT(distinct L.SubjectId) as SubjectsCount
from Teachers T
inner join Lectures L on T.Id = L.TeacherId
group by T.Id, T.Name, T.Surname;

--Task 10

select DayOfWeek, COUNT(*) as LecturesCount from Lectures
group by DayOfWeek;

--Task 11

select L.LectureRoom, COUNT(distinct D.Id) as DepartmentsCount
from Lectures L
inner join Teachers T on L.TeacherId = T.Id
inner join Departments D on T.Id = D.Id
group by L.LectureRoom;

--Task 12

select F.Name as FacultyName, COUNT(distinct L.SubjectId) as SubjectsCount
from Faculties F
inner join Departments D on F.Id = D.FacultyId
inner join Teachers T on D.Id = T.Id
inner join Lectures L on T.Id = L.TeacherId
group by F.Id, F.Name;

--Task 13

select T.Name + ' ' + T.Surname as TeacherName, L.LectureRoom, COUNT(*) as LecturesCount
from Lectures L
inner join Teachers T on L.TeacherId = T.Id
group by T.Id, T.Name, T.Surname, L.LectureRoom;