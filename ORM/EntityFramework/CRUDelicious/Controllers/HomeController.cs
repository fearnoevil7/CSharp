using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;
using System.Linq;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet]

        [Route("")]
        public IActionResult Index()
        {
            // List<Dish> AllDishes = dbContext.Dishes.ToList();
            Dish dish1 = dbContext.Dishes.FirstOrDefault();
            List <Dish> allDishes = dbContext.Dishes.ToList();
            ViewBag.dish = dish1.chef;
            Console.WriteLine("Testing!!!!!", dish1);
            Console.WriteLine(allDishes);
            
            return View(allDishes);
        }

        [HttpGet]
        [Route("/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Dish dish)
        {
            if (ModelState.IsValid)
            {
                Dish newDish = new Dish()
                {
                    name = dish.name,
                    chef = dish.chef,
                    calories = dish.calories,
                    tastiness = dish.tastiness,
                    description = dish.description,
                };
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return View("New");
            }
            else
            {
                return View("New");
            }
        }
        [HttpGet]
        [Route("/show/{dishid}")]
        public ViewResult Show(int dishid)
        {
            Console.WriteLine(dishid);
            Console.WriteLine("Show method id!!!!!!!", dishid);
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish1 => dish1.id == dishid);
            return View("Show", selectedDish);
        }

        [HttpGet]
        [Route("/edit/{dishid}")]
        public ViewResult Edit(int dishid)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish1 => dish1.id == dishid);
            return View("Edit", selectedDish);
        }

        [HttpPost]
        [Route("/update/{dishid}")]
        public IActionResult Update(int dishid, Dish dish)
        {
            if (ModelState.IsValid)
            {
                Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish1 => dish1.id == dishid);
                selectedDish.name = dish.name;
                selectedDish.chef = dish.chef;
                selectedDish.calories = dish.calories;
                selectedDish.tastiness = dish.tastiness;
                selectedDish.description = dish.description;
                dbContext.SaveChanges();
                return RedirectToAction("Edit", new {dishid = selectedDish.id});
            }
            else
            {
                int id = dishid;
                Console.WriteLine("********* Update failed!!!!!!!!*********");
                return RedirectToAction("Edit", new {dishid = id});
            }
        }

        [HttpGet]
        [Route("/delete/{dishId}")]
        public RedirectToActionResult Delete(int dishId)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish1 => dish1.id == dishId);
            dbContext.Dishes.Remove(selectedDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}