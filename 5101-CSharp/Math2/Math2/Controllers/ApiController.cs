using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Math2.Controllers
{
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private int result = 0;

        /// <summary>
        /// add a operand with 10
        /// 
        /// <example>AddTen/21 --> 31</example>
        /// </summary>
        /// 
        /// <param name="operand"></param>
        /// <returns>10 + operand</returns>
        [Route("AddTen/{operand}")]
        public int AddTen(int operand)
        {
            return operand + 10;
        }

        /// <summary>
        /// square a operand sent by user
        /// </summary>
        /// <param name="operand"></param>
        /// <returns>operand * operand</returns>
        [Route("Square/{operand}")]
        public int Square(int operand)
        {
            return operand * operand;
        }

        /// <summary>
        /// just greeting
        /// </summary>
        /// <returns></returns>
        [Route("Greeting")]
        public string Greeting()
        {
            return "Hello World!";
        }

        /// <summary>
        /// greeting with an input param
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Greeting/{id}")]
        public string Greeting(int id)
        {
            return "Greetings to " + id + " people!";
        }

        /// <summary>
        /// I do not know the quest actually
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("NumberMachine/{id}")]
        public int NumberMachine(int id)
        {
            return result + id;
        }

        /// <summary>
        /// calculate the hosting cost
        /// </summary>
        /// <param name="days"></param>
        /// <returns>a list of before hst cost, hst and total cost with hst</returns>
        [Route("HostingCost/{days}")]
        public IEnumerable<string> HostingCost(int days)
        {
            int fortnight = 1 + days / 14;
            double costBeforeHst = Math.Round(5.50 * fortnight, 2);
            double costHst = Math.Round(costBeforeHst * 0.13, 2);
            double costTotal = Math.Round(costBeforeHst + costHst, 2);

            return new[] { fortnight + " fortnights at $5.50/FN = $" + costBeforeHst + " CAD",
                    "HST 13% = $" + costHst + " CAD",
                    "Total = $" + costTotal + " CAD"};
        }
    }
}
