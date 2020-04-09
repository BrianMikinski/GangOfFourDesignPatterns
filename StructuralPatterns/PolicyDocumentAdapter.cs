



namespace GangOfFourDesignPatterns.Structural
{
    public class PolicyDocumentAdapter : IDocument
    {
        private InsurancePolicy Policy;

        public void SetPolicy(InsurancePolicy policy)
        {
            Policy = policy;
        }

        public string PolicyHolder()
        {
            return Policy.PolicyHolder;
        }

        public string PolicyHolderAddress()
        {
            return $"{Policy?.Address?.Line1}\n {Policy?.Address?.Line2}"; 
        }

        public string PolicyAmount()
        {
              return $"{Policy.Amount}"; 
        }
    }
}