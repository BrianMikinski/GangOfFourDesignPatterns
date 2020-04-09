using System;
using System.Collections.Generic;
using GangOfFourDesignPatterns.Creational;

namespace GangOfFourDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Gang of Four Design Patterns! \n");

            var insurancePolicies = CreationalPatterns();
        }

        public static IEnumerable<InsurancePolicy> CreationalPatterns()
        {
            // constructor creational pattern
            var stevesInsurancePolicy = new InsurancePolicy("Steve", 50);
            stevesInsurancePolicy.PrintPolicy();

            // creational pattern by static method
            var billsInsurancePolicy = InsurancePolicy.NewActiveInsurancePolicy("Bill", 75);
            billsInsurancePolicy.PrintPolicy();

            // creation by factory
            IPolicyFactory policyFactory = new PolicyFactory();
            var marysInsurancePolicy = policyFactory.BuildNewInsurancePolicy("Mary", 300, true, "1000 Main Street", "Apartment 1000");

            marysInsurancePolicy.PrintPolicy();

            return new List<InsurancePolicy>(){
                stevesInsurancePolicy,
                billsInsurancePolicy,
                marysInsurancePolicy
            };
        }

        public static void StructuralPatterns()
        {

        }

        public static void BehavioralPatterns()
        {

        }


    }
}
