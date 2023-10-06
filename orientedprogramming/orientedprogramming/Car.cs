using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Car
    {


        // public her yerden erişilebilmesi için tanımlanan genel bir erişim belirtecidir.

        private string color;        // renk
        private int maxSpeed;          // max hız
        private int year;               //model yılı
        private int currentSpeed;       // sabit hız
        private string carBrand;         //marka
        private string vehicleIdentificationNumber;  // saşe numarası

        public string Color   // property   
        {
            get { return color; }   // get method
            set { color = value; }  // set method
        }


        public int MaxSpeed   // property   
        {
            get { return maxSpeed; }   // get method
            set {

                if (value > 500)   // if kullanarak value değerinin 500 den büyük ise "yavaşla" yazdır
                {
                    Console.WriteLine("Yavaşla!");
                }
                else  //kullanıcının girdiği değer 500 büyük değilse ise kullanıcının girdiği değeri (value) değişkene ataa
                {
                    maxSpeed = value;
                }

            }  // set method
        }


        public int Year  // property
        {
            get { return year; }   // get method  
            set { year = value; }  // set method
        }

        public int CurrentSpeed  // property
        {
            get { return currentSpeed; }   // get method
            set { currentSpeed = value; }  // set method
        }

        public string CarBrand  // property
        {
            get { return carBrand; }   // get method
            set { carBrand = value; }  // set method
        }

        public string VehicleIdentificationNumber // property
        {
            // aracın saşe numarısını herkesle paylaşmak istemiyoruz o yüzden get satırını sildik.
            set {

                if (value.Length != 15)   // if kullanarak value.length değeri 15'e eşit değilse "Saşe numarası 15 haneden az olmaz." yazdır
                {
                    Console.WriteLine("Saşe numarası 15 haneden az olmaz.");
                }
                else  //eşit ise kullanıcının girdiği değeri (value) değişkene ata.
                {
                    vehicleIdentificationNumber = value;
                }


            }  // set method

            get    
            {

                try  // try bloğu içerisindeki değerleri çalıştırmayı dene
                {
                    String vehicleIdentificationPrivateNumber = "***********";  // 11 harfin * şeklinde görünmesini istedik vehicleIdentificationPrivateNumber değişkenini try içerisine yazdık.

                    //return vehicleIdentificationPrivateNumber
                    //   + vehicleIdentificationNumber[11]
                    //  + vehicleIdentificationNumber[12]
                    // + vehicleIdentificationNumber[13]
                    // + vehicleIdentificationNumber[14];

                    return vehicleIdentificationPrivateNumber   // return vehicleIdentificationPrivateNumber + vehicleIdentificationNumber.Substring(11) bunların çıktısını direkt ver demek.
                    + vehicleIdentificationNumber.Substring(11); // substring bundan sonrasını al demek 
                }
                catch (Exception e)  //try da yapmak istediğimiz işlem hata verir ise bunu yakala, catch bloğunun içerisindekileri yap
                {
                    Console.WriteLine("Saşe numarası okunurken hata oluştu"  +  e.Message);
                    return null;
                }

            }
        }


        public Car(string color, int maxSpeed, int year,string carBrand) // constractor:Car sınıfından oluşturduğum nesnenin özelliklerini kapsamaktadır.
        {
            this.Color = color;          //this fonksiyonu farklı olarak tanımlanan değerilerin birbirleriyle aynı anlama geldiğini ifade etmek içi kullanılmaktadır.
            this.MaxSpeed = maxSpeed;
            this.Year = year;
            this.CarBrand = carBrand;
        }

        public void isSpeedLimit() // void: fonksiyon için dönüş tipinin ya da değerinin olmadığı belirtmek için kullanılır.
        {
            if (currentSpeed > 140)   // if değeri bize sabit hız 140'tan büyük ise
            {
                    Console.WriteLine(carBrand+  " Hızın çok yüksek yavaşla!");  // yavaşla çıktısı verir
            }
            else   // else de tam dersi 140 dan az ise
            {
                    Console.WriteLine(carBrand+   " Hızın normal"); // hızın normal değerde çıktısı verir.
            }
        }
        

        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}

