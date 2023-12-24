--Task 1

select Teachers.[Name] AS TeacherName, Teachers.[Surname] AS TeacherSurname,
    Groups.[Name] AS GroupName
from Teachers cross join Groups;

--Task 2

select F.Name as DepartmentName from Departments
inner join Faculties F on F.Id = Departments.FacultyId
where Departments.Financing < F.Financing;

--Task 3

select C.Surname as CuratorSurname, G.Name as GroupName from GroupsCurators
inner join Curators C on C.Id = GroupsCurators.CuratorId
inner join Groups G on G.Id = GroupsCurators.GroupId;

--Task 4

select T.Name, T.Surname from GroupsLectures
inner join Groups G on G.Id = GroupsLectures.GroupId
inner join Lectures L on L.Id = GroupsLectures.LectureId
inner join Teachers T on T.Id = L.TeacherId
where G.Name = N'Group 2B';

--Task 5

select Surname as TeacherName, F.Name as FacultyName from Teachers
inner join Lectures L on L.TeacherId = Teachers.Id
inner join Subjects S on S.Id = L.SubjectId
inner join Departments D on D.Id = S.Id
inner join Faculties F on F.Id = D.FacultyId;

--Task 6

select Departments.Name as DepartmentName, G.Name as GroupName from Departments
inner join Groups G on G.DepartmentId = Departments.Id;

--Task 7

select S.Name as SubjectName from Teachers
inner join Lectures L on L.TeacherId = Teachers.Id
inner join Subjects S on S.Id = L.SubjectId
where Teachers.Name = N'Emma' AND Teachers.Surname = N'Williams';

--Task 8

select Departments.Name AS DepartmentName from Departments
inner join Groups G on G.DepartmentId = Departments.Id
inner join GroupsCurators GC on GC.GroupId = G.Id
inner join GroupsLectures GL on GL.GroupId = G.Id
inner join Lectures L on L.Id = GL.LectureId
inner join Subjects S on S.Id = L.SubjectId
where S.Name = N'Algorithm Design';

--Task 9

select Groups.Name as GroupName from Groups
inner join Departments D on D.Id = Groups.DepartmentId
inner join Faculties F on F.Id = D.FacultyId
where F.name = N'Engineering';

--Task 10

select Groups.name as GroupName, F.Name as FacultyName from Groups
inner join Departments D on D.Id = Groups.DepartmentId
inner join Faculties F on F.Id = D.FacultyId
where Groups.Course = 5;

--Task 11

select T.Name as TeacherName, T.Surname as TeacherSurname, L.LectureRoom, S.Name as SubjectName, G.Name as GroupName
from Teachers as T
inner join Lectures L on L.TeacherId = T.Id
inner join Subjects S on S.Id = L.SubjectId
inner join GroupsLectures GL on Gl.LectureId = L.Id
inner join Groups G on G.Id = GL.GroupId
where L.LectureRoom = N'Room 404';