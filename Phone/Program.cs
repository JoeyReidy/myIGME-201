using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    internal class Program
    {
        public abstract class Phone
        {
            private string phoneNumber;
            public string address;

            public string PhoneNumber;
            public abstract void Connect();
            public abstract void Disconnect();
        }

        public interface PhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();
        }

        public class RotaryPhone : Phone, PhoneInterface
        {
            public void Answer()
            {

            }
            public void MakeCall()
            {

            }
            public void HangUp()
            {

            }

            public override void Connect()
            {

            }
            public override void Disconnect()
            {

            }
        }

        public class PushButtonPhone : Phone, PhoneInterface
        {
            public void Answer()
            {

            }
            public void MakeCall()
            {

            }
            public void HangUp()
            {

            }

            public override void Connect()
            {

            }
            public override void Disconnect()
            {

            }
        }

        public class Tardis : RotaryPhone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSideKick;
            public double exteriorSurfaceArea;
            public double interiorVolume;

            public byte WhichDrWho { get; }
            public string FemaleSideKick { get; }

            public void TimeTravel()
            {

            }

            public override bool Equals(object obj)
            {
                if (obj is Tardis)
                {
                    Tardis other = (Tardis)obj;
                    return (this.WhichDrWho == other.WhichDrWho);
                }
                else
                {
                    return false;
                }
            }
            public static bool operator <(Tardis tardis, Tardis other)
            {
                if(tardis.WhichDrWho == 10 && other.WhichDrWho != 10)
                {
                    return tardis > other;
                }
                else if (tardis.WhichDrWho != 10 && other.WhichDrWho == 10)
                {
                    return tardis < other;
                }
                return tardis.WhichDrWho < other.WhichDrWho;
            }
            public static bool operator >(Tardis tardis, Tardis other)
            {
                if (tardis.WhichDrWho == 10 && other.WhichDrWho != 10)
                {
                    return tardis > other;
                }
                else if (tardis.WhichDrWho != 10 && other.WhichDrWho == 10)
                {
                    return tardis < other;
                }
                return tardis.WhichDrWho > other.WhichDrWho;
            }
            public static bool operator <=(Tardis tardis, Tardis other)
            {
                if (tardis.WhichDrWho == 10 && other.WhichDrWho != 10)
                {
                    return tardis > other;
                }
                else if (tardis.WhichDrWho != 10 && other.WhichDrWho == 10)
                {
                    return tardis < other;
                }
                return tardis.WhichDrWho <= other.WhichDrWho;
            }
            public static bool operator >=(Tardis tardis, Tardis other)
            {
                if (tardis.WhichDrWho == 10 && other.WhichDrWho != 10)
                {
                    return tardis > other;
                }
                else if (tardis.WhichDrWho != 10 && other.WhichDrWho == 10)
                {
                    return tardis < other;
                }
                return tardis.WhichDrWho >= other.WhichDrWho;
            }
            public static bool operator ==(Tardis tardis, Tardis other)
            {
                return tardis.WhichDrWho == other.WhichDrWho;
            }
            public static bool operator !=(Tardis tardis, Tardis other)
            {
                return tardis.WhichDrWho != other.WhichDrWho;
            }
        }

        public class PhoneBooth : PushButtonPhone
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;

            public void OpenDoor()
            {

            }
            public void CloseDoor()
            {

            }
        }
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth booth = new PhoneBooth();
        }

        static void UsePhone(object obj)
        {
            if (obj is PhoneInterface)
            {
                PhoneInterface phone = (PhoneInterface)obj;

                if(obj is Tardis)
                {
                    Tardis tardis = (Tardis)obj;
                    tardis.TimeTravel();
                }
                else if (obj is PhoneBooth)
                {
                    PhoneBooth booth = (PhoneBooth)obj;
                    booth.OpenDoor();
                }

                phone.MakeCall();
                phone.HangUp();
            }
            else
            {
                Console.WriteLine("you cannot make a phone call without a phone.");
            }
        }
    }
}
