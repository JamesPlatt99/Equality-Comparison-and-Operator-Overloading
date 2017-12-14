using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Comparison_and_Operator_Overloading
{
    public class Duck
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

        #region "Overrides"
        
        public override int GetHashCode()
        {
            int hash = WeightInGrams;
            hash = hash * 17 + AgeInMonths;
            hash = hash * 13 + Name.ToCharArray().Sum(n => (int)n * 7);
            hash = hash * 23 + Type.ToCharArray().Sum(n => (int)n * 11);
            return hash;
        }

        public override string ToString()
        {
            return String.Format($"Weiging in at {WeightInGrams} grams its {Name}! The {Type} duck aged {AgeInMonths} months!");
        }

        #endregion
    }

}
