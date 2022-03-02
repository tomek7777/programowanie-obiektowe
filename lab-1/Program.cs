using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = Person.Of("Aleks");
            Console.WriteLine(person.Name);
            DateTime dateTime = DateTime.Parse("03-02-2022");
            Console.WriteLine(dateTime);
            DateTime newDate = dateTime.AddDays(2);
            Console.WriteLine(newDate + " " + dateTime);
            string name = "adam";
            string v = name.Substring(0, 2);
            Console.WriteLine("adam" == name);
        }
    }
}



class Person
{
    private string _name;
    private Person(string name)
    {
        _name = name;
    }

    public static Person Of(string name)
    {
        if (name != null && name.Length >= 2)
        {
            return new Person(name);
        }
        else
        {
            throw new ArgumentOutOfRangeException("Imię zbyt krótkie!");

        }
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value != null && value.Length >= 2)
            {
                _name = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Imię zbyt krótkie");
            }
        }
    }

    public enum Currency
    {
        PLN = 1,
        USD = 2,
        EUR = 3
    }
    public class Money
    {
        private readonly decimal _value;
        private readonly Currency _currency;
        private Money(decimal value, Currency currency)
        {
            _value = value;
            _currency = currency;
        }
        public static Money? Of(decimal value, Currency currency)
        {
            return value < 0 ? null : new Money(value, currency);
        }
        
    }


}