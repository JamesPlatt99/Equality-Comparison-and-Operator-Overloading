using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Comparison_and_Operator_Overloading
{
    public class Duck : IComparable
    {
        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }

        #region "Properties"
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }
        #endregion
        
        #region "Public Methods"
        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            if (obj.GetType() == this.GetType())
            {
                return this.AgeInMonths - ((Duck)obj).AgeInMonths;
            }
            return 0;
        }
        #endregion

        #region "Overrides"

        public override int GetHashCode()
        {
            int hash = WeightInGrams;
            hash = hash * 17 + AgeInMonths;
            hash = hash * 13 + Name.ToCharArray().Select((n,i) => (int)n * i * 7).Sum();
            hash = hash * 23 + Type.ToCharArray().Select((n, i) => (int)n * i * 11).Sum();
            return hash;
        }

        public override bool Equals(object obj)
        {
            return (obj != null && this.GetHashCode() == obj.GetHashCode());
        }

        public override string ToString()
        {
            return String.Format($"Weiging in at {WeightInGrams} grams its {Name}! The {Type} duck aged {AgeInMonths} months!");
        }

        #endregion

        #region "Operators"
        public static bool operator ==(Duck left, Duck right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Duck left, Duck right)
        {
            return !Equals(left, right);
        }

        public static bool operator <(Duck left, Duck right)
        {
            return left.AgeInMonths < right.AgeInMonths;
        }

        public static bool operator >(Duck left, Duck right)
        {
            return left.AgeInMonths > right.AgeInMonths;
        }
        #endregion
    }

}
