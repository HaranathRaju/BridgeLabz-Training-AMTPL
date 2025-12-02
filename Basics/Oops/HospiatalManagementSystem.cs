using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    public static int TotalPatients = 0;
    public readonly int patientID;
    public string name;
    public int age;
    public string ailment;

    public Patient(int patientID,string name, int age, string ailment)
    {
        this.patientID = patientID;
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        TotalPatients++;
    }

    public static int getTotalPatients()
    {
        return TotalPatients;
    }

    public void DisplayPatientInfo()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient ID: " + patientID);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Ailment: " + ailment);
    }
}
namespace ObjectOrientedProgramming.problems
{
    internal class HospiatalManagementSystem
    {
        public static void Main(string[] args)
        {
            Patient p1 = new Patient(101, "John Doe", 45, "Flu");
            Patient p2 = new Patient(102, "Jane Smith", 30, "Fracture");
            Console.WriteLine("Hospital Name: " + Patient.HospitalName);
            Console.WriteLine("Total Patients: " + Patient.getTotalPatients());

            if (p1 is Patient)
            {
                p1.DisplayPatientInfo();
            }
            if (p2 is Patient)
            {
                p2.DisplayPatientInfo();
            }   
        }

    }
}
