using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace demo
{
    internal class Car
    {

        private int  id;
        private int speed;
        private string model;


        #region Prop
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        #endregion

        //public  String Address { get; set; } // prop

       

        public override string ToString()
        {
            return $"Id : {Id} :: Speed: {Speed} :: Model: {Model} ";
        }

        public Car(int id, int speed, string model ) : this(id , speed)
        {
            //Id = id;
            //Speed = speed;
            Model = model;
        }

        public Car(int id , int speed) : this(id)
        {
            //Id = id;
            Speed = speed;
        }

        public Car(int id)
        {
            Id = id;
        }



    }
}
