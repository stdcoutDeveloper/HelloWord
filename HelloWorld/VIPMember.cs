using System;

namespace HelloWorld
{
    internal class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee_ = 1200;
        }
    }
}