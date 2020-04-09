using System;
using System.Collections.Generic;
using GangOfFourDesignPatterns.Creational;
using GangOfFourDesignPatterns.Structural;

namespace GangOfFourDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Gang of Four Design Patterns! \n");

            var insurancePolicies = CreationalPatterns();

            StructuralPatterns(insurancePolicies);


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

        public static void StructuralPatterns(IEnumerable<InsurancePolicy> policies)
        {
            var printer = new DocumentPrinter();
            var policyAdapter = new PolicyDocumentAdapter();

            foreach(var policy in policies)
            {
                policyAdapter.SetPolicy(policy);
                printer.PrintDocument(policyAdapter);
            }
        }

        public static void BehavioralPatterns()
        {

        }
    }
}
