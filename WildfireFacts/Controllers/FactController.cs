using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WildfireFacts.Models;
using WildfireFacts.Factories;
using Newtonsoft.Json;

namespace WildfireFacts.Controllers
{
    [Route("[controller]")]
    public class FactController : Controller
    {
        private readonly ILogger<FactController> _logger;
        private readonly IFactFactory _factFactory;
        private readonly List<Fact> Facts;



        public FactController(ILogger<FactController> logger, IFactFactory factFactory)
        {
            _logger = logger;
            _factFactory = factFactory;
            Facts = new List<Fact>
            {
                _factFactory.Create("Wildfires can cover a large area quickly, up to 100 miles per hour."),
                _factFactory.Create("Wildfires can travel upwards of 1,000 feet into the air."),
                _factFactory.Create("Wildfires can be started by humans, lightning, heat from the sun, even insects."),
                _factFactory.Create("Wildfires can be contained if they are detected early enough."),
                _factFactory.Create("Wildfires can last for days or weeks, and their intensity can fluctuate."),
                _factFactory.Create("Wildfires can cause loss of life, injuries, and damage to homes and businesses."),
                _factFactory.Create("Wildfires can also affect animals and the environment."),
                _factFactory.Create("Wildfires can produce their own wind, known as a fire breeze."),
                _factFactory.Create("Wildfires can be controlled by humans through methods like back burning, line cutting, and water dropping."),
                _factFactory.Create("Some wildfires are natural and occur every year."),
                _factFactory.Create("Wildfires can cause air pollution and contribute to climate change."),
                _factFactory.Create("Wildfires can spread rapidly due to strong winds."),
                _factFactory.Create("Wildfires can create a smoky haze that can affect visibility and respiratory health."),
                _factFactory.Create("Wildfires can produce dangerous smoke and gases."),
                _factFactory.Create("Wildfires can destroy large areas of forest and vegetation."),
                _factFactory.Create("Wildfires can lead to soil erosion and water pollution."),
                _factFactory.Create("Wildfires can create opportunities for new plant growth."),
                _factFactory.Create("Wildfires can play a role in certain animal migrations."),
                _factFactory.Create("Wildfires can be caused by human activities such as campfires, building construction, and arson."),
                _factFactory.Create("Wildfires can affect local economies by causing damage to infrastructure and property."),
                _factFactory.Create("Wildfires can be predicted and managed with careful planning and resources."),
                _factFactory.Create("Wildfires can be prevented through proper land management practices."),
                _factFactory.Create("Wildfires are caused by lightning strikes approximately 30% of the time."),
                _factFactory.Create("The average wildfire in the U.S. burns for 3 days."),
                _factFactory.Create("The average firefighter spends 12 hours per day fighting fires."),
                _factFactory.Create("Some wildfires are intentionally started by humans."),
                _factFactory.Create("In 2020, wildfires burned over 12 million acres in the U.S."),
                _factFactory.Create("Wildfires can be controlled by reducing flammable vegetation around homes."),
                _factFactory.Create("Wildfires can cause air pollution, leading to health problems."),
                _factFactory.Create("Some animals have adapted to survive in wildfire zones."),
                _factFactory.Create("Small fires can quickly become large wildfires if not managed properly."),
                _factFactory.Create("Wildfires can change local climate conditions."),
                _factFactory.Create("Wildfires can impact local economies, particularly those dependent on tourism."),
                _factFactory.Create("Wildfires can lead to increased property insurance costs."),
                _factFactory.Create("Wildfires can damage infrastructure, including roads and bridges."),
                _factFactory.Create("Wildfires can affect biodiversity by altering habitats."),
                _factFactory.Create("Wildfires can release carbon dioxide into the atmosphere."),
                _factFactory.Create("Wildfires can be prevented through careful management of landscapes."),
                _factFactory.Create("Some wildfires can be controlled by applying water or other chemicals."),
                _factFactory.Create("Wildfires can be extinguished by controlled burns."),
                _factFactory.Create("Wildfires can be monitored using satellites."),
                _factFactory.Create("Wildfires can be mitigated through early detection and prompt response."),
                _factFactory.Create("Wildfires can be predicted using climate models."),
                _factFactory.Create("Wildfires can be fought using ground crews, aircraft, and bulldozers.")
            };
        }


        [HttpGet]
        public IEnumerable<Fact> AllFacts()
        {
            return Facts;
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}