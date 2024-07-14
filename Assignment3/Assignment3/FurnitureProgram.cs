using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

     class Furniture
    {
        public int OrderId;
        public DateTime OrderDate;
        public string FurnitureType;
        public int Qty;
        public double TotalAmt;
        public string PaymentMode;

        public void GetData()
        {
            Console.Write("Enter Order ID: ");
            OrderId = int.Parse(Console.ReadLine());
            Console.Write("Enter Order Date (yyyy-mm-dd): ");
            OrderDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Furniture Type (Chair/Cot): ");
            FurnitureType = Console.ReadLine();
            Console.Write("Enter Quantity: ");
            Qty = int.Parse(Console.ReadLine());
            Console.Write("Enter Payment Mode (Credit/Debit): ");
            PaymentMode = Console.ReadLine();
        }
        public void ShowData()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
            Console.WriteLine($"Furniture Type: {FurnitureType}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
        }
    }


    class Chair:Furniture
    {
        public string ChairType;
        public string Purpose;
        public string WoodChair;
        public string SteelChair;
        public string PlasticColor;
        public double Rate;

        public void GetData()
        {
            base.GetData();
            Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();
            Console.Write("Enter Purpose (Office/Home): ");
            Purpose = Console.ReadLine();
            Console.Write("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());
            if(ChairType == "Wood")
            {
                Console.Write("Enter Wood Chair Type: ");
                WoodChair = Console.ReadLine();
            }
            else if(ChairType == "Steel")
            {
                Console.Write("Enter Steel Chair Type: ");
                SteelChair = Console.ReadLine();
            }
            else if(ChairType == "Plastic")
            {
                Console.Write("Enter Plastic Chair Color: ");
                PlasticColor = Console.ReadLine();
            }
            TotalAmt = Rate * Qty;
        }

        public void showData()
        {
            base.ShowData();
            Console.WriteLine($"Chair Type: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");
            Console.WriteLine($"Rate: {Rate}");
            if(ChairType == "Wood")
            {
                Console.WriteLine($"Wood Chair Type: {WoodChair}");
            }
            else if(ChairType == "Steel")
            {
                Console.WriteLine($"Steel Chair Type: {SteelChair}");
            }
            else if(ChairType == "Plastic")
            {
                Console.WriteLine($"Plastic Chair Color: {PlasticColor}");
            }
        }

    }
    class Cot : Furniture
    {
        public string CotType;
        public string WoodCot;
        public string SteelCot;
        public int Capacity;
        public double Rate;

        public void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter CotType (Wood/Steel)");
            CotType = Console.ReadLine();
            if( CotType == "Wood")
            {
                Console.WriteLine("Choose Wood Type (Teak/Rose)");
                WoodCot = Console.ReadLine();
            }
            else if ( CotType == "Steel")
            {
                Console.WriteLine("Choose Steel Type (Gray Steel/Green Steel/Brown Steel\r\n)");
                SteelCot = Console.ReadLine();
            }
            Console.Write("Enter Capacity (Single/Double): ");
            Capacity = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());
            TotalAmt = Rate * Qty;
        }
        public  void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Cot Type: {CotType}");

            if (CotType == "Wood")
            {
                Console.WriteLine($"Wood Type: {WoodCot}");
            }
            else if (CotType == "Steel")
            {
                Console.WriteLine($"Steel Type: {SteelCot}");
            }

            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
        }

    }

    class FurnitureProgram { 
        static void Main()
        {
            Chair chair= new Chair();
            Cot cot = new Cot();
            Console.Write("Enter Furniture Type for order (Chair/Cot): ");
            string furnitureType = Console.ReadLine();
            if (furnitureType == "Chair")
            {
                chair.GetData();
                chair.showData();
            }
            else if ( furnitureType == "Cot")
            {
                cot.GetData();
                cot.GetData();  
            }
            else
            {
                Console.WriteLine("Invalid type");
            }
            
        }
    }


}
