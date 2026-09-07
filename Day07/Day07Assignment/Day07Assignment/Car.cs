using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Assignment
{
    internal class Car : IMovable
    {
        #region attributes
        private int id { get; set; }
        private string brand { get; set; }
        public int price { get; set; }
        #endregion

        #region constructors
        public Car() { }

        public Car(int id)
        {
            this.id = id;
        }

        public Car(int id, string brand)
        {
            this.id = id;
            this.brand = brand;
        }

        public Car(int id, string brand, int price)
        {
            this.id = id;
            this.brand = brand;
            this.price = price;
        } 
        #endregion

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

    }
}
