using Asp.Net_MVC_Session2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_MVC_Session2.Controllers
{
    // MVC Controller 
    public class MoviesController : Controller
    {
        // Actions => public non-static methods 
        // Actions => Have Special Specific Return Types
        // ActionResult 

        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id : {id}";
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id : {id}";
        //}

        // ContentResul:
        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id : {id}",
        //        ContentType = "text/html", // "object/pdf"
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}

        //RedirectResult => Take URL To Redirect on it :
        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectresult = new RedirectResult("https://www.google.co.uk/");

        //    return redirectresult;
        //}   

        // RedirectToActionResult => Redirect On Method :
        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult(nameof(AddMovie),"Movies",new {id = 133});

        //    return redirectToActionResult;
        //}

        // Action Result => For Mixed Data

        //[ActionName("GetMovie")]
        ////[HttpGet]
        ////[HttpPost]
        //public IActionResult GetMovieByIdWithCategoryDramaAndPoster(int id )
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With Id : {id}", ContentType = "text/html" };
        //       // Helper :
        //        return Content($"Get Movie With Id : {id}", "text/html");
        //    }
        //    else if (id == 2)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With Id : {id}", ContentType = "object/pdf" };
        //        return Content($"Get Movie With Id : {id}", "object/pdf") ;
        //    }
        //    else if (id == 3)
        //    {
        //       //return new RedirectResult("https://www.google.co.uk/");
        //       return Redirect("https://www.google.co.uk/");
        //    }
        //    else
        //    {
        //        //return new RedirectToActionResult(nameof(AddMovie), "Movies", new { id = 133 });
        //        return RedirectToAction(nameof(AddMovie), "Movies", new { id = 133 });
        //    }

        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id : {id}";
        //}

        // Action Parameter Binding :
        // 1. Form
        // 2. Segment
        // 3. Query (Params) String  [?id=12] => {Must Be The Same Name in Method}
        // 4. File

        //public IActionResult GetMovie(int id)
        //{
        //    return Content($"Get Movie With Id : {id}", "text/html");
        //}

        // Binding By Simple Data (Data In Class Movies [proprties]) Not Complex
          public IActionResult GetMovie(Movies movies)
        {
            return Content($"Get Movie With Id : {movies.Id} , Name : {movies.Name}", "text/html");
        }

    }
}
