using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zxczx.Controllers
{
    [ApiController]
    [Route("api/J2/DiceGame/{m}/{n}")]
    public class J2Controller : Controller
    {
        /// <summary>
        /// This code computes number of ways in which two dices can be rolled to obtain a total of 10.
        /// each dice has variable sides.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// GET api/J2/DiceGame/6/8
        /// GET api/J2/DiceGame/12/4
        /// GET api/J2/DiceGame/3/3
        /// GET api/J2/DiceGame/5/5
        /// <returns>Number of ways in which the dice can be rolled to obtain a total of 10</returns>
        [HttpGet]
        public string DiceGame(int m, int n)
        {
            int[] arr1 = new int[m];
            int[] arr2 = new int[n];
            int i;
            int j;
            // variable initialization which will return the total number of ways.
            int k = 0;
            for (i = 0; i < m; i++)
            {
                arr1[i] = i + 1;
            }
            for (j = 0; j < n; j++)
            {
                arr2[j] = j + 1;
            }

            foreach (int a in arr1)
            {
                foreach (int b in arr2)
                {
                    if (a + b == 10)
                    {
                        k = k + 1;
                    }
                }
            }
            return ("There are total " + k.ToString() + " ways to get the sum 10");
        }
    }
} 
