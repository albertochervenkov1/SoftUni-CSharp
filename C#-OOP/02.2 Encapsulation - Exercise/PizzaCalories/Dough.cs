using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int minWeight = 1;
        private const int maxWeight= 200;

        private string flourtype;
        private string bakingtechnique;
        private int weight;
        public Dough(string flourType,string bakingtechnique,int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingtechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourtype;
            private set 
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "white" && valueAsLower != "wholegrain")
                {
                    throw new ArgumentException("Invaild type of dough.");
                }
                this.flourtype = value;
            }
        }
        public string BakingTechnique 
        {
            get => this.bakingtechnique;
            private set 
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "chewy" && valueAsLower != "crispy" && valueAsLower != "homemade")
                {
                    throw new ArgumentException("Invaild type of dough.");
                }
                this.bakingtechnique = value;
            }
        }
        public int Weight 
        {
            get => this.weight;
            private set 
            {
                Validator.IfNumberIsNotInRange(minWeight, maxWeight, value, $"Dough weight should be in the range [{minWeight}..{maxWeight}].");
                this.weight = value;
            }
        }

        public double GetCalories() 
        {
            var flourTypeModifier = GetDoubleModifier();
            var bakingTechniqueModifier=GetBakingTechniqueModifier();

            return this.Weight * 2 * flourTypeModifier * bakingTechniqueModifier;
        }

        public double GetDoubleModifier() 
        {
            var flourTypeLower = this.FlourType.ToLower();
            if (flourTypeLower=="white")
            {
                return 1.5;
            }
            return 1;
        }

        public double GetBakingTechniqueModifier() 
        {
            var bakingTechniqueLower = this.BakingTechnique.ToLower();

            if (bakingTechniqueLower=="crispy")
            {
                return 0.9;
            }
            if (bakingTechniqueLower=="chewy")
            {
                return 1.1;
            }
            return 1;
        }
    }
}
