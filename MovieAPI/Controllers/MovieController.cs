using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieAPI.Controllers
{
    [Route("Movie")]
    [ApiController]
    public class MovieController : Controller
    {
        [HttpGet]
        public List<Movie> Index()
        {
            List<Movie> mlist = Movie.Read();
            return mlist;
            
        }
        [HttpGet("Category")]
        public List<string> Categories()
        {
            List<string> mcategory = Movie.ReadCategory();
            return mcategory;
        }
        //[HttpGet("Category/{category}")]
        //public List<Movie> Movie(string category)
        //{
        //    List<Movie> mlist = Movie.Read(category);
        //    return mlist;

        //}
    }
}
