using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{


    abstract class Cellphone
    {
        public abstract void sendMessage();
        public abstract void makeCall();
    }

    class MoteCellphone : Cellphone
    {

        public override void sendMessage()
        {
            Console.WriteLine("Mote Send Message");
        }

        public override void makeCall()
        {
            Console.WriteLine("Mote Make Call");
        }
    }

    abstract class Decorator : Cellphone
    {
        Cellphone _phone;

        public Decorator(Cellphone phone)
        {
            this._phone = phone;
        }

        public override void sendMessage()
        {
            _phone.sendMessage();
        }

        public override void makeCall()
        {
            _phone.makeCall();
        }
    }

    class GPSDecorator : Decorator
    {
        public GPSDecorator(Cellphone phone)
            : base(phone)
        {
        }

        public override void sendMessage()
        {
            //GPS OP
            base.sendMessage();
        }

        public override void makeCall()
        {
            //GPS OP
            base.makeCall();
        }
    }

}
