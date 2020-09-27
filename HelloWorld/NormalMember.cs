using System;

namespace HelloWorld
{
    internal class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }

        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID,
            memberSince)
        {
            Console.WriteLine("Child constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public NormalMember(string remarks) : base("Jamie", 1, 2015)
        {
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public override void CalculateAnnualFee()
        {
            annualFee_ = 100 + 12 * 30;
        }
    }
}