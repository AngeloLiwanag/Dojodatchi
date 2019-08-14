using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace dojodachi.Controllers
{
    public class HomeController : Controller
    {
        // private int? fullness
        // {
        //     get { return HttpContext.Session.GetInt32("full");}
        //     set{
        //         if(value !=null)
        //         {
        //             HttpContext .Session.SetInt32("full", (int)value);
        //         }
        //     }
        // }
        // private int? happiness
        // {
        //     get { return HttpContext.Session.GetInt32("happy");}
        //     set{
        //         if(value !=null)
        //         {
        //             HttpContext .Session.SetInt32("happy", (int)value);
        //         }
        //     }
        // }        
        // private int? meals
        // {
        //     get { return HttpContext.Session.GetInt32("meal");}
        //     set{
        //         if(value !=null)
        //         {
        //             HttpContext .Session.SetInt32("meal", (int)value);
        //         }
        //     }
        // }        
        // private int? energy
        // {
        //     get { return HttpContext.Session.GetInt32("energy");}
        //     set{
        //         if(value !=null)
        //         {
        //             HttpContext .Session.SetInt32("energy", (int)value);
        //         }
        //     }
        // }
        public IActionResult Index(Pet x)
        {
            int? fullness = HttpContext.Session.GetInt32("full");
            int? happiness = HttpContext.Session.GetInt32("happy");
            int? meals = HttpContext.Session.GetInt32("meal");
            int? energy = HttpContext.Session.GetInt32("energy");
            string message = HttpContext.Session.GetString("message");

            if(fullness == null)
            {
                HttpContext.Session.SetInt32("full", x.Fullness);
            }

            if (happiness == null)
            {
                HttpContext.Session.SetInt32("happy", x.Happiness);
            }

            if (meals == null)
            {
                HttpContext.Session.SetInt32("meal", x.Meals);
            }

            if (energy == null)
            {
                HttpContext.Session.SetInt32("energy", x.Energy);
            }
            HttpContext.Session.SetString("message", "Play with me !");

            System.Console.WriteLine("**************************************************");
            System.Console.WriteLine($"Fullness is {x.Fullness}");
            System.Console.WriteLine($"Happiness is {x.Happiness}");
            System.Console.WriteLine($"Meals is {x.Meals}");
            System.Console.WriteLine($"Energy is {x.Energy}");


            ViewBag.full = fullness;
            ViewBag.happy = happiness;
            ViewBag.meal = meals;
            ViewBag.energy = energy;
            ViewBag.message = message;

            return View(x);
        }

        [HttpGet("Feed")]
        public IActionResult Feed()
        {
            int? meals = HttpContext.Session.GetInt32("meal");
            int? fullness = HttpContext.Session.GetInt32("full");
            string message = HttpContext.Session.GetString("message");
            HttpContext.Session.SetString("message", "");
            Random random = new Random();
            int luck = random.Next(1,5);
            if(meals == 0)
            {
                message = "You have no more meals...";
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }
            if(luck == 1)
            {
                meals --;
                message = "Your Dojodachi didnt like that...";
                HttpContext.Session.SetInt32("meal", (int)meals);
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }
            else{
                meals --;
                int num = random.Next(5,11);
                fullness += num;
                message = $"Your fed your Dojodachi! Fullness +{num}, Meal -1";
                HttpContext.Session.SetInt32("full", (int)fullness);
                HttpContext.Session.SetInt32("meal", (int)meals);
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }

        }

        [HttpGet("Play")]
        public IActionResult Play()
        {
            int? energy = HttpContext.Session.GetInt32("energy");
            int? happiness = HttpContext.Session.GetInt32("happy");
            string message = HttpContext.Session.GetString("message");
            HttpContext.Session.SetString("message", "");
            Random random = new Random();
            int luck = random.Next(1,5);
            
            if(energy ==0)
            {
                message = "You have no more energy...";
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }
            if(luck == 1)
            {
                energy -= 5;
                message = "Your Dojodachi didnt like that...";
                HttpContext.Session.SetInt32("energy", (int)energy);
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }
            else{
                energy -= 5;
                int num = random.Next(5,11);
                happiness += num;
                message = $"Your played your Dojodachi! Happiness +{num}, energy -5";
                HttpContext.Session.SetInt32("energy", (int)energy);
                HttpContext.Session.SetInt32("happy", (int)happiness);
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("Work")]
        public IActionResult Work()
        {
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meal");
            string message = HttpContext.Session.GetString("message");
            HttpContext.Session.SetString("message", "");
            Random random = new Random();
            int num = random.Next(1,4);
            
            if(energy ==0)
            {
                message = "You have no more energy...";
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }else{
                energy -= 5;
                meals += num;
                message = $"Working... Meals +{num}, energy -5";
                HttpContext.Session.SetInt32("meal", (int)meals);
                HttpContext.Session.SetInt32("energy", (int)energy);
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }
        }  

        [HttpGet("Sleep")]
        public IActionResult Sleep()
        {
            int? energy = HttpContext.Session.GetInt32("energy");
            int? happiness = HttpContext.Session.GetInt32("happy");
            int? fullness = HttpContext.Session.GetInt32("full");
            string message = HttpContext.Session.GetString("message");

            if(happiness ==0 || fullness ==0)
            {
                message = "Your Dojodatchi died... You lose!!";
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }else{
                energy += 15;
                happiness -= 5;
                fullness -= 5;
                message = $"Sleeping... Energy +15, happiness -5, fullness 5";
                HttpContext.Session.SetInt32("energy", (int)energy);
                HttpContext.Session.SetInt32("happy", (int)happiness);
                HttpContext.Session.SetInt32("full", (int)fullness);
                HttpContext.Session.SetString("message", message);
                return RedirectToAction("Index");
            }

        }

        [HttpGet("Reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
