using AutoMapper;
using Product_Management_System.DTOs;
using Product_Management_System.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Product_Management_System.Controllers
{
    public class RegistrationController : Controller
    {
        PMSEntities db= new PMSEntities();

        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            return new Mapper(config);
        }

        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            return View(new CustomerDTO());
        }

        [HttpPost]
        public ActionResult Index(CustomerDTO c)
        {
            if (ModelState.IsValid)
            {
                var customer = GetMapper().Map<Customer>(c);

                //Both password match here
                //if(customer.Password==c.ConformPassword)
                //{
                //    customer.Password = CreateMD5(customer.Password);
                //    db.Customers.Add(customer);
                //    db.SaveChanges();
                //}
                //else
                //{
                //    TempData["msg"] = "Password Dont match";
                //    return View(new CustomerDTO());
                //}

                //By custom Validation
                customer.Password = CreateMD5(customer.Password);
                db.Customers.Add(customer);
                db.SaveChanges();

                TempData["msg"] = "Account created succcessfully";
                return RedirectToAction("Login");
                
            }
            return View(c);
        }

        public ActionResult Login()
        {
            return View();
        }


        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }


    }
}