internal class Program
{
    private static void Main(string[] args)
    {
       Calısan user1=new Calısan();
       user1.Ad="Ali";
       user1.Soyad="Ateş";
       user1.No=456789;
       user1.Departman="IK";

        Calısan user2 = new Calısan();
        user2.Ad = "Deniz";
        user2.Soyad = "Yıldız";
        user2.No = 456789;
        user2.Departman = "Software";

        user1.CalisanBilgileri();
        user2.CalisanBilgileri();

        Student ogr1=new Student();
        ogr1.Name1="Ayşe";
        ogr1.Surname1="Baş";
        ogr1.StudentId=456789;

        Console.WriteLine(ogr1.GetFullName());
       


    }
}

class Calısan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("\nÇalışan Adı: {0}",Ad);
        Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
        Console.WriteLine("Çalışan No: {0}",No);
        Console.WriteLine("Çalışan Departmanı: {0}",Departman);
    }

}

class Student
{
    private int id;
    private string Name;
    private string Surname;

    public int StudentId { get { return id; } set { if (value > 0) id = value; } }
    public string Name1 { get => Name; set => Name = value; }
    public string Surname1 { get => Surname; set => Surname = value; }


    public string GetFullName()
    {
        return Name1 + " " + Surname1;
    }
}