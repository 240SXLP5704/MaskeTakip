// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Degiskenler();

        Citizen1 citizen1 = new Citizen1();

        SelamVer(name: "Engin");
        SelamVer(name: "Ahmet");
        SelamVer(name: "Ayşe");
       

        int result = Topla(6,2);

        //Diziler - Arrays
        string student1 = "Engin";
        string student2 = "Eren";
        string student3 = "Berke";

        string[] students = new string[3];
        students[0] = "Engin";
        students[1] = "Eren";
        students[2] = "Berke";

        students = new string[4];
        students[3] = "İlker";

        //for (int i = 0; i < students.Length; i=i+1)
       for (int i=0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }

        
        string[] cities = new[] {"Ankara","İstanbul","İzmir"};
        string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
        cities2 = cities;
        cities[0] = "Adana";
        Console.WriteLine(cities2[0]);


        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }


        int numb1 = 10;
        int numb2 = 20;
        numb2 = numb1;
        numb1 = 30;
        //numb2 = ??
        Console.WriteLine(numb2);
        //değer atamaları referans gibi değil.
        //atandıktan sonra işi bitiyor.

        //MyList
        //List fonksiyonu olmadan nasıl yazardın? DENE!
        List<string> newCities1 = new List<string> {"Aydın","Muğla","Manisa","Antalya"};
        newCities1.Add("İstanbul");
        foreach (string city in newCities1)
        {
            Console.WriteLine(city);   
        }



        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);//BU NE YA :(

        Person person1 = new Person();
        person1.FirstName = "Engin";
        person1.LastName = "DEMİROĞ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 1234567890;

        Person person2 = new Person();
        person2.FirstName = "Eren";
        person2.LastName = "ÇETİN";
        person2.DateOfBirthYear = 2002;
        person2.NationalIdentity = 0987654321;


        Console.ReadLine();
    }

     
    static void SelamVer(string name)
    {
        Console.WriteLine("Merhaba" + "," + " " + name);
    }

    static int Topla(int number1, int number2)
    {
        int result = number1 + number2;
        Console.WriteLine("Result = " + result);
        return result;
    }



    private static void Degiskenler()
    {
        string mesaj = "Selamlar";
        double tutar = 1000.5; //db'den gelir
        int sayi = 100;
        //bool truefalse
        bool girisYapmisMi = false;

        string name = "Engin";
        string surName = "Demioğ";
        int birthYear = 1985;
        long idNumber = 12345678910;


        Console.WriteLine(mesaj);
        Console.WriteLine(mesaj);

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(1000 * 1.18);
    }
}

public class PttManager
{
    public PttManager(PersonManager personManager)
    {
        PersonManager = personManager;
    }

    public PersonManager PersonManager { get; }

    internal void GiveMask(Person person1)
    {
        throw new NotImplementedException();
    }
}

public class Citizen1
{
    string name = "Engin";
    string surName = "Demioğ";
    int birthYear = 1985;
    long idNumber = 12345678910;
    //kutu kutu pense veya birazcık matruşka ha
    //buradaki değişkenler class içinde,
    //eğer ki başlarında public olsaydı dışarıdan - 
    //- da özelliklerine erişilebilirdi
}

public class Citizen2
{
    public string Name { get; set; }
    public string SurName { get; set;}
    public int BirthYear { get; set;}
    public long IdNumber { get; set;}

}
