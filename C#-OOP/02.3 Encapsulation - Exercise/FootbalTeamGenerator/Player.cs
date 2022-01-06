using System;
using System.Collections.Generic;
using System.Text;

namespace FootbalTeamGenerator
{
    //are endurance, sprint, dribble, passing and shooting
    public class Player
    {
        private string name;
        private double endurance;
        private double sprdouble;
        private double dribble;
        private double passing;
        private double shooting;
        private double skillLevel;

        public Player(string name, double endurance, double sprdouble, double dribble, double passing, double shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprdouble = sprdouble;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            this.skillLevel = (endurance + sprdouble + dribble + passing + shooting) / 5;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }
        public double SkillLevel { get { return this.skillLevel; } }
        public double Endurance 
        {
            get => this.endurance;
            private set 
            {

                Validator.ThrowException("Endurance", value);
                this.endurance = value;
            }
        }
        public double Sprdouble 
        {
            get => this.sprdouble;
            private set
            {
                Validator.ThrowException("Sprdouble", value);
                this.sprdouble = value;
            }
        }
        public double Dribble
        {
            get => this.dribble;
            private set 
            {
                Validator.ThrowException("Dribble", value);
                this.dribble = value;
            }
        }
        public double Passing
        {
            get => this.passing;
            private set 
            {
                Validator.ThrowException("Passing", value);
                this.passing = value;
            }
        }
        public double Shooting
        {
            get => this.shooting;
            private set 
            {
                Validator.ThrowException("Shoting", value);
                this.shooting = value;
            }
        }

        

        
    }
}
