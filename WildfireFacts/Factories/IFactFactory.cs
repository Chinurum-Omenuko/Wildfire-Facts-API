using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WildfireFacts.Models;

namespace WildfireFacts.Factories
{
    public interface IFactFactory
    {
        Fact Create(string value);
    }
}