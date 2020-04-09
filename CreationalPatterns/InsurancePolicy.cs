
using System;

namespace GangOfFourDesignPatterns.Creational
{
    public class InsurancePolicy
    {
        // creational factory by static method on class
        public static InsurancePolicy NewActiveInsurancePolicy(string policyHolder, double amount)
        {
            return new InsurancePolicy(policyHolder, amount, false);
        }

        private InsurancePolicy(string policyHolder, double amount, bool isActive)
            : this(policyHolder, amount)
        {
            Cost = amount;
        }

        public InsurancePolicy(string policyHolder, double amount, bool isActive, Address address)
            : this(policyHolder, amount)
        {
            Cost = amount;
            Address = address;
        }

        // most basic creational pattern - the object constructor!
        public InsurancePolicy(string policyHolder, double amount)
        {
            PolicyHolder = policyHolder;
            Cost = amount;
        }

        public string PolicyHolder { get; private set; }

        public double Cost { get; private set; }

        public bool? IsActive { get; private set; }

        public Address Address { get; private set; }

        public void PrintPolicy()
        {
            Console.WriteLine("Printing Policy Data...\n");
            Console.WriteLine($"Policy Holder: {PolicyHolder}");
            Console.WriteLine($"Cost: {Cost}");
            Console.WriteLine($"Is Active: {IsActive}\n");
        }
    }
}