using System;
class Student
{
  public string Name;
  public int ID;
  public int Batch;
  public char Section;
  private long Password;

  public long uniqePass
  {
    get { return Password; }
    set { Password = value; }
  }

  public Student()
  {
    Name = "Al-Amin Hossain";
    ID = 1166;
    Batch = 62;
    Section = 'B';

  }

  public void Display()
  {
    Console.WriteLine("Student's Name   : " + Name);
    Console.WriteLine("Student's ID     : " + ID);
    Console.WriteLine("Student's Batch  : " + Batch);
    Console.WriteLine("Student's Section: " + Section);

  } 
  }
class Program
{
  public static void Main(string[] args)
  {
    Student studentINFO = new Student();
    studentINFO.Display();
    studentINFO.uniqePass = 15645;
    Console.WriteLine("My ERP Password  : " + studentINFO.uniqePass);
  }

}
