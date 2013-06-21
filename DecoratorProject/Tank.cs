using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorProject
{
    public interface ITank
    {
        void ShowTankInfo();
    }

    public class Tank : ITank
    {
        public void ShowTankInfo()
        {
            Console.WriteLine("I am a normal tank!");
        }
    }


    public abstract class TankAbility : ITank
    {
        private ITank tank;

        public TankAbility(ITank tank)
        {
            this.tank = tank;
        }

        public virtual void ShowTankInfo()
        {
            tank.ShowTankInfo();
        }
    }

    public class BulletAbility : TankAbility
    {
        public BulletAbility(ITank tank) : base(tank) { }

        public void GetAbility()
        {
            Console.WriteLine("Now, I get the bullet ability!");
        }

        public override void ShowTankInfo()
        {
            base.ShowTankInfo();
            GetAbility();
        }
    }

    public class ArmourAbility : TankAbility
    {
        public ArmourAbility(ITank tank) : base(tank) { }

        public void GetAbility()
        {
            Console.WriteLine("Now, I get the armour ability!");
        }

        public override void ShowTankInfo()
        {
            base.ShowTankInfo();
            GetAbility();
        }
    }

    public class FlyAbility : TankAbility
    {
        public FlyAbility(ITank tank) : base(tank) { }

        public void GetAbility()
        {
            Console.WriteLine("Now, I get the fly ability!");
        }

        public override void ShowTankInfo()
        {
            base.ShowTankInfo();
            GetAbility();
        }
    }

    public class InvisibleAbility : TankAbility
    {
        public InvisibleAbility(ITank tank) : base(tank) { }

        public void GetAbility()
        {
            Console.WriteLine("Now, I get the invisible ability!");
        }

        public override void ShowTankInfo()
        {
            base.ShowTankInfo();
            GetAbility();
        }
    }

}
