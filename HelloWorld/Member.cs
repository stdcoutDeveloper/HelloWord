using System;

namespace HelloWorld
{
    internal class Member
    {
        private readonly int memberID_;
        private readonly int memberSince_;

        private readonly string name_;
        protected int annualFee_;

        public Member()
        {
            Console.WriteLine("Parent constructor with no parameter");
        }

        public Member(string name, int memberID, int memberSince)
        {
            Console.WriteLine("Parent constructor with 3 parameters");

            name_ = name;
            memberID_ = memberID;
            memberSince_ = memberSince;
        }

        public virtual void CalculateAnnualFee()
        {
            annualFee_ = 0;
        }

        public override string ToString()
        {
            return "\nName: " + name_ + "\nMember ID: " + memberID_ + "\nMember Since: " + memberSince_ +
                   "\nTotal Annual Fee: " + annualFee_;
        }
    }
}