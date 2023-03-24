using StudentRepos;

StudentRepository repository = new StudentRepository();

string firstName;
string lastName;
string group;

repository.Insert(new Student { FirstName = "Макс", LastName = "Пейн", Group = "21Д" });
repository.Insert(new Student { FirstName = "Чад", LastName = "Гигов", Group = "21Д" });
repository.Insert(new Student { FirstName = "Гоку", LastName = "Сон", Group = "21Д" });
repository.Insert(new Student { FirstName = "Тони", LastName = "Сварка", Group = "21Д" });
repository.Insert(new Student { FirstName = "Гон", LastName = "Фладд", Group = "21Д" });

//GetAll
Console.WriteLine("\nGetAll");

List<Student> studentsList = repository.GetAll();
Console.WriteLine("Студенты:");
for (int i = 0; i < studentsList.Count; i++)
{
    Console.WriteLine($"Id {studentsList.IndexOf(studentsList[i]) + 1}| {studentsList[i].LastName} {studentsList[i].FirstName} {studentsList[i].Group}");
}

//GetById
Console.WriteLine("\nGetById");
Console.WriteLine("Введите id искомого студента");
int getId = Convert.ToInt32(Console.ReadLine());

Student studentById = repository.GetById(getId - 1);
Console.WriteLine("Студент " + getId);
Console.WriteLine($"{studentById.FirstName} {studentById.LastName} {studentById.Group}");

//Insert
Console.WriteLine("\nInsert");

Console.Write("Имя: ");
firstName = Console.ReadLine();
Console.Write("Фамилия: ");
lastName = Console.ReadLine();
Console.Write("Группа: ");
group = Console.ReadLine();

repository.Insert(new Student { FirstName = firstName, LastName = lastName, Group = group });

//Delete
Console.WriteLine("\nDelete");

Console.WriteLine("id удаляемого студента: ");
getId = Convert.ToInt32(Console.ReadLine());
repository.Delete(getId - 1);

Console.WriteLine("Обновленный список студентов:");
for (int i = 0; i < studentsList.Count; i++)
{
    Console.WriteLine($"Id {studentsList.IndexOf(studentsList[i]) + 1}| {studentsList[i].LastName} {studentsList[i].FirstName} {studentsList[i].Group}");
}

//Update
Console.WriteLine("\nUpdate");

Console.WriteLine("id обновляемого студента: ");
getId = Convert.ToInt32(Console.ReadLine());

Console.Write("Имя: ");
firstName = Console.ReadLine();
Console.Write("Фамилия: ");
lastName = Console.ReadLine();
Console.Write("Группа: ");
group = Console.ReadLine();

Student updatedStudent = new Student { FirstName = firstName, LastName = lastName, Group = group };
repository.Update(getId - 1, updatedStudent);

Student studentAfterUpdate = repository.GetById(getId);
Console.WriteLine("Студент " + studentAfterUpdate.FirstName + " " + studentAfterUpdate.LastName + " изменен");

Console.WriteLine("Обновленный список студентов:");
for (int i = 0; i < studentsList.Count; i++)
{
    Console.WriteLine($"Id {studentsList.IndexOf(studentsList[i]) + 1}| {studentsList[i].LastName} {studentsList[i].FirstName} {studentsList[i].Group}");
}

//Find
Console.WriteLine("\nFind");

Console.WriteLine("Введите первую букву фамилии: ");
char firstLetter = Convert.ToChar(Console.ReadLine());

List<Student> findedStudents = repository.Find(firstLetter);
for (int i = 0; i < findedStudents.Count; i++)
{
    Console.WriteLine($"Id {studentsList.IndexOf(findedStudents[i]) + 1}| {findedStudents[i].LastName} {findedStudents[i].FirstName} {findedStudents[i].Group}");
}
