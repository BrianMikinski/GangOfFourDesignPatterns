namespace GangOfFourDesignPatterns.Creational
{
    public interface IPolicyFactory
    {
        InsurancePolicy BuildNewInsurancePolicy(string policyHolder, double amount, bool isActive, string addressLine1, string addressLine2);
    }
}