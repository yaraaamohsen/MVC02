using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using WebApplication_.NET_8._0.Models;


namespace WebApplication_.NET_8._0.Controllers
{
    // CLI : Create An Instant Object For MovieController Class 
    public class MovieController : Controller
    {
        // Actions : public Non-static method
        // Actions : Have Special Return types
        // ActionResult 

        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id : {id}";
        //}
        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id : {id}";
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie By ID:  {id}",
        //        ContentType = "text/html"
        //        //ContentType = "object/pdf"
        //    };
        //    return contentResult;
        //}

        //public RedirectResult Test(int id)
        //{
        //    var redirectResult = new RedirectResult("https://www.google.com");
        //    return redirectResult;
        //}

        //public RedirectToActionResult Test(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movie", new {id = 133});
        //    return redirectToActionResult;
        //}

        //[ActionName("GetMovie")]
        ////[HttpPost]
        //public IActionResult GetMovieByIDWithCategoryDramaAndPoster(int id) // As IActionResult interface that Base class implemented it 
        //{
        //    if(id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie By ID:  {id}", ContentType = "text/html" };
        //        return Content( $"Get Movie By ID:  {id}", "text/html" );
        //    }
        //    else if(id == 2)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie By ID:  {id}", ContentType = "object/pdf" };
        //        return Content($"Get Movie By ID:  {id}", "object/pdf");

        //    }
        //    else if(id == 3)
        //    {
        //        //return new RedirectResult("https://www.google.com");
        //        return Redirect("https://www.google.com");
        //    }
        //    else
        //    {
        //        //return new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });
        //        return RedirectToAction("AddMovie", "Movie", new { id = 133 });
        //    }
        //}


        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id : {id}";
        //}

        // Action Parameter Binding
        // 1. Form
        // 2. Segment "{controller=Movie}/{action=GetMovie}/{id?} ---> Segments"
        // 3. Query params ----> Movie/GetMovie?id=12
        // 4. Files

        // if it is Movie/GetMovie/1?id=12 --> by default take '1'

        //public IActionResult GetMovie(Movie movie)
        //{
        //    return Content($"Get Movie By Id : {movie.Id}, Name : {movie.Name} ", "text/html");
        //}
    }
}
