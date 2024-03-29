﻿using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private,ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary,Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; private set; }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine($"Corps: {Corps}");

            return builder.ToString().TrimEnd();
        }
    }
}
