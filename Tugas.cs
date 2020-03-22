
using System;


namespace Taxi
{
    class Taxi {

        
        public string DriverName;
        public Boolean OnDuty;
        public int NumPassenger;

        
        public void TaxiInfo () {
            Console.WriteLine("Driver Name : " + this.DriverName);
            if(OnDuty == true) {
                Console.WriteLine("On Duty : yes");
            } else if(OnDuty == false) {
                Console.WriteLine("On Duty : no");
            }
            Console.WriteLine("Number Of Passenger : " + this.NumPassenger);
        }

        public void PickUpPassenger() {
            Console.WriteLine( this.DriverName + " menjemput ");
        }

        public void DropOffPassenger() {
            Console.Write( this.DriverName + " selesai mengantar penumpang");
        }



    }
}



namespace Taxi {
    class Program {

        static void Main(string[] args) {

            Taxi taxi = new Taxi();

            taxi.DriverName = "Yuniar";
            taxi.OnDuty = true;
            taxi.NumPassenger = 999;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();

          
        }

    }

}