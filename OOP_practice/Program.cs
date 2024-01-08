abstract class Person
{
    public int age { get; set; }
    public string gender { get; set; }
    public string nationality { get; set; }
    public Person(int Age, string Gender, string Nationality)
    {
        age = Age;
        gender = Gender;
        nationality = Nationality;
    }
    public virtual void printInfo()
    {
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Nationality: {(nationality is null ? "unknown" : nationality)}");
    }

}

class Student : Person
{
    public string name { get; set; }
    public string surname { get; set; }
    public string major { get; set; }
    public string[] subjects { get; set; }
    public Student(string Name, string Surname,
           string Major, int Age, string Gender,
           string Nationality) : base(Age, Gender, Nationality)
    {
        name = Name;
        surname = Surname;
        major = Major;
    }
    public void AddSubjects(params string[] newSubjects)
    {
        subjects = newSubjects;
    }
    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"Major of {name} is {major}");
        Console.WriteLine();
        if (subjects != null && subjects.Length > 0)
        {
            Console.WriteLine($"Subjects: {string.Join(", ", subjects)}");
        }
    }
}

class Teacher : Person
{
    string name { get; set; }
    public string surname { get; set; }
    public string major { get; set; }
    public Teacher(string Name, string Surname,
           string Major, int Age, string Gender,
           string Nationality) : base(Age, Gender, Nationality)
    {
        name = Name;
        surname = Surname;
        major = Major;
    }

    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"{name} teaches {major}");
    }
}

class Subject
{
    public string subject_name { get; set; }
    public string subject_description { get; set; }
    public Subject(string subject, string time)
    {
        subject_name = subject;
        subject_description = time;
    }
    public void printInfo()
    {
        Console.WriteLine("| Subject   | Time |");
        Console.WriteLine($"| {subject_name} | {subject_description}|");
    }
}

class Program
{
    static void Main()
    {
        Student student = new("Sam", "Jones", "CS ML", 24, "male", "Uzbek");
        student.AddSubjects("Math", "CS", "ML");
        student.printInfo();
        Console.WriteLine();
        Teacher teacher = new("Steve", "Rock", "ML", 49, "male", "Kazah");
        teacher.printInfo();
        Console.WriteLine();
        Subject subject = new("ML lesson", "13:40");
        subject.printInfo();
    }

}