using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using chefsNdishes.Models;
using System.Linq;

namespace chefsNdishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("/")]
        public ViewResult Index()
        {
            List<Chef> allChefs = dbContext.Chefs.Include(c => c.CreatedDishes).ToList();
            return View(allChefs);
        }

        [HttpGet]
        [Route("/new")]
        public ViewResult New()
        {
            return View("AddChef");
        }

        [HttpPost]
        [Route("/create/chef")]
        public RedirectToActionResult Create(Chef chef)
        {
            if (ModelState.IsValid)
            {
                Chef newChef = new Chef()
                {
                    FirstName = chef.FirstName,
                    LastName = chef.LastName,
                    Birthday = chef.Birthday,
                };
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Console.WriteLine("Failed To Create Chef!!!!!!!!");
                return RedirectToAction("New");
            }
        }

        [HttpGet]
        [Route("/dish/new")]
        public ViewResult NewDish()
        {
            List<Chef> allChefs = dbContext.Chefs.ToList();
            ViewBag.allChefs = allChefs;
            return View("AddDish");
        }

        [HttpGet]
        [Route("/dishes")]
        public ViewResult ShowDishes()
        {
            List<Dish> allDishes = dbContext.Dishes.Include(d => d.Creator).ToList();
            return View("AllDishes", allDishes);
        }

        [HttpPost]
        [Route("/create/dish")]
        public IActionResult CreateDish(Dish dish)
        {
            Console.WriteLine("Name: " + dish.Name);
            Console.WriteLine("Calories: " + dish.Calories);
            Console.WriteLine("Tastiness: " + dish.Tastiness);
            Console.WriteLine("Chef Id: " + dish.ChefId);
            Console.WriteLine("Description: " + dish.Description);
            if (ModelState.IsValid)
            {
                Chef chef = dbContext.Chefs.Include(chef2 => chef2.CreatedDishes).FirstOrDefault(chef1 => chef1.ChefId == dish.ChefId);
                if (chef == null)
                {
                    Console.WriteLine("*******Failed to find chef Id to fill in dish foreign key*******");
                    return RedirectToAction("NewDish");
                }
                Dish newDish = new Dish()
                {
                    Name = dish.Name,
                    Calories = dish.Calories,
                    Tastiness = dish.Tastiness,
                    Description = dish.Description,
                    ChefId = dish.ChefId,
                    Creator = chef
                };
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                Dish dish3 = dbContext.Dishes.FirstOrDefault(dish4 => dish4.Name == dish.Name);
                Console.WriteLine("Name: " + dish3.Name);
                Console.WriteLine("Calories: " + dish3.Calories);
                Console.WriteLine("Tastiness: " + dish3.Tastiness);
                Console.WriteLine("Chef Id: " + dish3.ChefId);
                Console.WriteLine("Description: " + dish3.Description);
                Console.WriteLine("First Name: " + chef.FirstName);
                Console.WriteLine("Last Name: " + chef.LastName);
                Console.WriteLine("Birthday: " + chef.Birthday);
                Console.WriteLine("Id: " + chef.ChefId);
                Console.WriteLine("Dishes: " + chef.CreatedDishes);
                Console.WriteLine("*******!!!!!!!Success!!!!!!!");
                // List<Dish> chefsDishes = dbContext.Chefs.
                chef.CreatedDishes.Add(dish3);
                return RedirectToAction("ShowDishes");
            }
            else
            {
                Console.WriteLine("ModelState validations failed!!!!!!!");
                return RedirectToAction("NewDish");
            }
        }
        [HttpGet]
        [Route("/delete/{dishId}")]
        public RedirectToActionResult Delete(int dishId)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish1 => dish1.DishId == dishId);
            dbContext.Remove(selectedDish);
            dbContext.SaveChanges();
            return RedirectToAction("ShowDishes");
        }
    }
}