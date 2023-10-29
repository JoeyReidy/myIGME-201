using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lax
{
    internal class Program
    {
        public abstract class LacrossePlayer
        {
            public string name;
            public Stick stick;

            public abstract void PlayLax();
            public void WallBall(int reps)
            {
                Console.WriteLine(name + " does wallball for " + reps + " reps");
            }
        }

        public interface ILaxPlayer
        {
            void practice();
        }

        public abstract class Stick
        {
            public string mesh;
            public string head;
            public string shaft;
        }

        public interface IStick
        {
            void Catch();
            void Throw();
            void Shoot();
        }

        public class ShortStick : Stick, IStick
        {
            public void Catch()
            {

            }

            public void Throw()
            {

            }

            public void Shoot()
            {

            }

            public void SwimDodge()
            {

            }
        }

        public class DPole : Stick, IStick
        {
            public void Catch()
            {

            }

            public void Throw()
            {

            }

            public void Shoot()
            {

            }

            public void PokeCheck()
            {

            }
        }

        public class AttackPlayer : LacrossePlayer, ILaxPlayer
        {
            public override void PlayLax()
            {
                
            }

            public void practice()
            {

            }

            public void Score()
            {

            }
        }

        public class DefencePlayer : LacrossePlayer, ILaxPlayer
        {
            public override void PlayLax()
            {

            }

            public void practice()
            {

            }

            public void CauseTurnover()
            {

            }
        }


        static void Main(string[] args)
        {
            AttackPlayer attackmen = new AttackPlayer();
            DefencePlayer defencemen = new DefencePlayer();
            ShortStick shortStick = new ShortStick();
            DPole dPole = new DPole();

            PlayLacrosse(attackmen);
            PlayLacrosse(defencemen);
        }

        static void PlayLacrosse(object obj)
        {
            if (obj is LacrossePlayer)
            {
                LacrossePlayer player = (LacrossePlayer) obj;
                player.PlayLax();

                if(obj is AttackPlayer)
                {
                    AttackPlayer attackman = (AttackPlayer) obj;
                    attackman.Score();
                }
                else if (obj is DefencePlayer)
                {
                    DefencePlayer defenceman = (DefencePlayer) obj;
                    defenceman.CauseTurnover();
                }
            }
        }

    }
}
