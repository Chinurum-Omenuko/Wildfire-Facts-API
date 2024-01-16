using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WildfireFacts.Models;
using WildfireFacts.Factories;

namespace WildfireFacts.Factories
{
    public class FactFactory : IFactFactory
    {
        public Fact Create(string value)
        {
            return new Fact { Value = value };
        }
    }

}