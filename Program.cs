internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}

class Group
{
    string name;
    List<Student> group;
    Group()
    {
        name = "P13";
        group = new List<Student>(10);
    }
    public Group(List<Student> g)
    {
        Random rnd = new Random();
        name = $"{(char)rnd.Next(65, 90)} {rnd.Next(10, 99)}";
        group = g;
    }
    public Group(Group g)
    {
        name = g.name;
        group = g.group;
    }
    public void Show()
    {
        Console.WriteLine(this.name);
        for (int i = 0; i < group.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + group[i].GetName());
        }
    }
    public void AddStudent()
    {
        string n = Console.ReadLine();
        int m = Convert.ToInt32(Console.ReadLine());
        Student s = new Student(n, m);
        group.Add(s);
    }
    public void SetName()
    {
        Random rnd = new Random();
        name = $"{(char)rnd.Next(65, 90)} {rnd.Next(10, 99)}";
    }
    public void SwapStudent(string n, List<Student> g)
    {
        for (int i = 0; i < group.Count; i++)
        {
            if (n == group[i].GetName())
            {
                g.Add(group[i]);
                group.Remove(group[i]);
            }
            else Console.WriteLine("Student not found");
        }
    }
    public void KickAllNonPassers()
    {
        for (int i = 0; i < group.Count; i++)
        {
            if (group[i].GetMidGrade() <= 7)
            {
                group.Remove(group[i]);
            }
        }
    }
    public void KickTheWorst()
    {
        Student current = group[0];
        for (int i = 0; i < group.Count; i++)
        {
            if (current.GetMidGrade() < group[i].GetMidGrade())
            {
                current = group[i];
            }
        }
        group.Remove(current);
    }

}

class Student
{
    string name;
    int midGrade;

    Student()
    {
        name = "Вася Пупкин";
        midGrade = 0;
    }
    public Student(string n, int m)
    {
        name = n;
        midGrade = m;
    }
    public Student(Student s)
    {
        this.name = s.name;
        this.midGrade = s.midGrade;
    }
    public string GetName()
    {
        return name;
    }
    public void SetName(string n)
    {
        name = n;
    }
    public void SetMidGrade(int m)
    {
        midGrade = m;
    }
    public int GetMidGrade()
    {
        return midGrade;
    }
}