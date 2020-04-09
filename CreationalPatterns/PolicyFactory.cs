

namespace GangOfFourDesignPatterns.Creational
{
    public class PolicyFactory : IPolicyFactory
    {
        public InsurancePolicy BuildNewInsurancePolicy(string policyHolder, double amount, bool isActive, string addressLine1, string addressLine2)
        {
            var address = new Address(addressLine1, addressLine2);

            return new InsurancePolicy(policyHolder, amount, isActive, address);
        }
    }
}