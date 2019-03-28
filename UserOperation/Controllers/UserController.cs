using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserOperation.Interfaces;
using UserOperation.Models;

namespace UserOperation.Controllers
{
    public class UserController : Controller
    {

        private  IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            _userRepository.CreateUsers();
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create( User newUser)
        {
            _userRepository.CreateNewUsers(newUser);
            return RedirectToAction("List");
        }


        public IActionResult Delete(int id) 
        {
            var ab = _userRepository.GetUsers();
            var a = ab.Where(s => s.UserId == id).FirstOrDefault();
            return View(a);
          
        }
        
        [HttpPost]

        public IActionResult Delete(User std)
        {
            _userRepository.DeleteUsers(std.UserId);
            return RedirectToAction("List");
        }
        
        public IActionResult Details(int id)
        {
            var ab = _userRepository.GetUsers();
            var a =ab.Where(s => s.UserId == id).FirstOrDefault();
            return View(a);
        }
        public IActionResult Edit(int id)
        {
            var ab = _userRepository.GetUsers();
            var a = ab.Where(s => s.UserId == id).FirstOrDefault();
            return View(a);
        }
        [HttpPost]        
        public IActionResult Edit(User std)
        {
            _userRepository.SetUsers(std);
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            var ab = _userRepository.GetUsers();
            return View(ab);
        }

    }
}