﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
        string Mood {  get; }
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public void AddSugar(byte amount)
        {

        }

        public abstract void Steam();

        public HotDrink()
        {

        }
        public HotDrink(string brand)
        {

        }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public class Waiter : IMood
    {
        public string name;

        public string Mood { get; }
        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood { get; }
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public override void Steam()
        {
            throw new NotImplementedException();
        }

        public void TakeOrder()
        {
            throw new NotImplementedException();
        }

        public CupOfCoffee(string brand) : base(brand)
        {

        }
    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public override void Steam()
        {
            throw new NotImplementedException();
        }

        public void TakeOrder()
        {
            throw new NotImplementedException();
        }

        public CupOfTea(bool customerIsWealthy)
        {

        }
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public int numCups;
        public bool marshmallows;
        private string source;

        public string Source { set; get; }

        public override void Steam()
        {
            throw new NotImplementedException();
        }

        public void TakeOrder()
        {
            throw new NotImplementedException();
        }

        public void AddSugar(byte amount)
        {
            throw new NotImplementedException();
        }

        public CupOfCocoa(bool marshmallows = false) : base("Expensive")
        {

        }
    }
}
