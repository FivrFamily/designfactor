using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerAPI.Models;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
         public IEnumerable<customer> Get()
         {
             
             return new List<customer>
             {
                 new customer {
                     customerID = 1,
                     customerName = "Rajesh Ramamurthy",
                     phoneNumber = "825-456-4561" 
                 },
                 new customer {
                     customerID = 2,
                     customerName = "Ramya Sitaraman",
                     phoneNumber = "825-456-4562" 
                 },
                 new customer {
                     customerID = 3,
                     customerName = "Rohan Ramamurthy",
                     phoneNumber = "825-456-4563" 
                 }
             };
         } 

         
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<customer> Get(int id)
        {
            List<customer> customerlist = new List<customer>
             {
                 new customer {
                     customerID = 1,
                     customerName = "Rajesh Ramamurthy",
                     phoneNumber = "425-214-6510" 
                 },
                 new customer {
                     customerID = 2,
                     customerName = "Ramya Sitaraman",
                     phoneNumber = "425-999-6510" 
                 }
             };
            
            try 
            {
                var customer = customerlist.Where(p => p.customerID==id).First(); 
                return customer;
            }
            catch (Exception)
            {
                return NotFound();
            }
            
            
            
        }
    }
    

}
