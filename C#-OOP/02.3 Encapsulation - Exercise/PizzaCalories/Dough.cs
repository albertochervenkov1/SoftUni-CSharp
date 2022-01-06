using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int minWeight = 1;
        private const int maxWeight = 200;
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType 
        {
            get => this.flourType;
            private set 
            {
                var valueLowerCase = value.ToLower();
                if (valueLowerCase != "white" && valueLowerCase != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }
        public string BakingTechnique 
        {
            get => this.bakingTechnique;
            private set 
            {
                var valueLowerCase = value.ToLower();
                if (valueLowerCase != "crispy" && valueLowerCase != "chewy" && valueLowerCase != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }
        public int Weight 
        {
            get => this.weight;
            private set 
            {
                if (value<minWeight||value>maxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{minWeight}..{maxWeight}].");
                }
                this.weight = value;
            }
        }
        public double GetCalories()
        {
            var flourTypeModifier = GetFlourTypeCalories();
            var bakingTechniqueModifier = GetBakingTechniqueModifier();

            return (2*Weight) * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetBakingTechniqueModifier() 
        {
            var bakingTechniqueToLower = bakingTechnique.ToLower();
            if (bakingTechniqueToLower== "crispy")
            {
                return 0.9;
            }
            else if (bakingTechniqueToLower=="chewy")
            {
                return 1.1;
            }
            return 1.0;
        }

        private double GetFlourTypeCalories()
        {
            var flourTypeLower = flourType.ToLower();
            if (flourTypeLower=="white")
            {
                return 1.5;
            }
            return 1.0;
        }
        

    }
}
