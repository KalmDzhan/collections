using StudentRepos;

StudentRepository repository = new StudentRepository();

int id = 1;

string firstName;
string lastName;
string group;

repository.Insert(new Student { Id = id, FirstName = "Макс", LastName = "Пейн", Group = "21Д" });
id++;
repository.Insert(new Student { Id = id, FirstName = "Чад", LastName = "Гигов", Group = "21Д" });
id++;
repository.Insert(new Student { Id = id, FirstName = "Гоку", LastName = "Сон", Group = "21Д" });
id++;
repository.Insert(new Student { Id = id, FirstName = "Тони", LastName = "Сварка", Group = "21Д" });
id++;
repository.Insert(new Student { Id = id, FirstName = "Гон", LastName = "Фладд", Group = "21Д" });
id++;

//GetAll
Console.WriteLine("\nGetAll");

List<Student> studentsList = repository.GetAll();
Console.WriteLine("Студенты:");
foreach (Student student in studentsList)
{
    Console.WriteLine($"Id {student.Id}| {student.LastName} {student.FirstName} {student.Group}");
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

repository.Insert(new Student { Id = id, FirstName = firstName, LastName = lastName, Group = group });
id++;

//Delete
Console.WriteLine("\nDelete");

Console.WriteLine("id удаляемого студента: ");
getId = Convert.ToInt32(Console.ReadLine());
repository.Delete(getId - 1);

Console.WriteLine("Обновленный список студентов:");
foreach (Student student in studentsList)
{
    Console.WriteLine($"Id {student.Id}| {student.LastName} {student.FirstName} {student.Group}");
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
Console.WriteLine("Студент " + studentAfterUpdate.Id + " изменен");

//Find
Console.WriteLine("\nFind");

Console.WriteLine("Введите первую букву фамилии: ");
char firstLetter = Convert.ToChar(Console.ReadLine());

foreach (Student student in repository.Find(firstLetter))
{
    Console.WriteLine($"Id {student.Id}| {student.LastName} {student.FirstName} {student.Group}");
}