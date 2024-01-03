// See https://aka.ms/new-console-template for more information

Course Course1 = new Course();

Course1.Name = "C#";
Course1.Teacher = "Engin Demiroğ";
Course1.Progress = 3;

Course Course2 = new Course();

Course2.Name = "C++";
Course2.Teacher = "Engin Cemiroğ";
Course2.Progress = 4;

Course Course3 = new Course();

Course3.Name = "Java";
Course3.Teacher = "Engin Jemiroğ";
Course3.Progress = 5;

Course Course4 = new Course();

Course4.Name = "C";
Course4.Teacher = "Engin Ultemiroğ";
Course4.Progress = 10;

Course[] courses = new Course[]
{
    Course1, Course2, Course3, Course4
};


//Console.WriteLine("Kurs Adı: " + Course1.Name + ", Öğretim Görevlisi: " + Course1.Teacher + ", İlerleme Durumu: " + Course1.Progress + "%");

foreach (Course crs in courses)
{
    Console.WriteLine("Kurs Adı: " + crs.Name + ", Öğretim Görevlisi: " + crs.Teacher + ", İlerleme Durumu: " + crs.Progress + "%");
}

class Course
{
    public string Name { get; set; }
    public string Teacher { get; set; }
    public int Progress { get; set; }
}
