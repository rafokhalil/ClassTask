using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{

    public class Car
    {

        public double Id { get; set; }
        public string Model { get; set; } = String.Empty;
        public string Vendor { get; set; } = String.Empty;
        public string Volume { get; set; } = String.Empty;
        public DateTime ProduceYear { get; set; } = DateTime.Now;
        public Car(in double id, in string model, in string vendor, in string volume, in DateTime produceYear)
        {
            Id = id;
            Model = model;
            Vendor = vendor;
            Volume = volume;
            ProduceYear = produceYear;
        }
        public double Age
        {
            get
            {
                var years = DateTime.Now.Year - ProduceYear.Year;
                return years;
            }
        }
        public void Show()
        {
            Console.WriteLine($"Car ID: {Id}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Car Vendor: {Vendor}");
            Console.WriteLine($"Car Volume: {Volume}");
            Console.WriteLine($"Car Produce Year: {ProduceYear.ToString("F")}");
            Console.WriteLine($"Car Age: {Age}");
        }
    }
}
