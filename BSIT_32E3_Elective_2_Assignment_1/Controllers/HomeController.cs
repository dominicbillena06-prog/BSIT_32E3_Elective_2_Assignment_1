
using Microsoft.AspNetCore.Mvc;
using MVCQuiz.Models;

namespace MVCQuiz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Number = 1,
                    Question = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    Options = new List<string>
                    {
                        "A) SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server.",
                        "B) SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON.",
                        "C) SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers.",
                        "D) SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server."
                    },
                    CorrectAnswer = "B",
                    Explanation = "MVC renders HTML views on the server and sends the finished markup to the browser. A Web API primarily provides data, commonly in JSON format."
                },

                new QuizQuestion
                {
                    Number = 2,
                    Question = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                    Options = new List<string>
                    {
                        "A) ControllerBase supports Razor View rendering using View() and ViewData.",
                        "B) ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead.",
                        "C) Controller is obsolete in .NET 8 and cannot handle HTTP POST requests.",
                        "D) ControllerBase automatically creates SQLite database files on application startup."
                    },
                    CorrectAnswer = "B",
                    Explanation = "ControllerBase provides HTTP-related functionality. Controller inherits from ControllerBase and adds MVC view-related functionality."
                },

                new QuizQuestion
                {
                    Number = 3,
                    Question = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    Options = new List<string>
                    {
                        "A) [Route]",
                        "B) [HttpGet]",
                        "C) [ApiController]",
                        "D) [FromQuery]"
                    },
                    CorrectAnswer = "C",
                    Explanation = "[ApiController] automatically handles invalid model state and returns HTTP 400 responses in applicable Web API scenarios."
                },

                new QuizQuestion
                {
                    Number = 4,
                    Question = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    Options = new List<string>
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 404 Not Found"
                    },
                    CorrectAnswer = "B",
                    Explanation = "201 Created indicates that a new resource was successfully created. The Location header can identify its URI."
                },

                new QuizQuestion
                {
                    Number = 5,
                    Question = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    Options = new List<string>
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 400 Bad Request"
                    },
                    CorrectAnswer = "C",
                    Explanation = "204 No Content indicates that the request succeeded and there is no response body."
                },

                new QuizQuestion
                {
                    Number = 6,
                    Question = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
                    Options = new List<string>
                    {
                        "A) GET /api/getAllCourses",
                        "B) GET /api/courses",
                        "C) POST /api/createNewCourseRecord",
                        "D) POST /api/deleteCourseById?id=5"
                    },
                    CorrectAnswer = "B",
                    Explanation = "RESTful URLs use resource names, usually nouns. HTTP methods describe the action being performed."
                },

                new QuizQuestion
                {
                    Number = 7,
                    Question = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    Options = new List<string>
                    {
                        "A) It connects the controller directly to an Entity Framework database context.",
                        "B) It maps incoming URI request paths to the controller class using the class name token.",
                        "C) It encrypts all incoming JSON payloads.",
                        "D) It enables Cross-Origin Resource Sharing (CORS) for external React apps."
                    },
                    CorrectAnswer = "B",
                    Explanation = "The [controller] token is replaced by the controller name without the Controller suffix. CoursesController becomes api/courses."
                },

                new QuizQuestion
                {
                    Number = 8,
                    Question = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    Options = new List<string>
                    {
                        "A) POST",
                        "B) PUT",
                        "C) GET",
                        "D) DELETE"
                    },
                    CorrectAnswer = "C",
                    Explanation = "GET retrieves a resource without intentionally modifying server state. It is both safe and idempotent."
                },

                new QuizQuestion
                {
                    Number = 9,
                    Question = "In ASP.NET Core Web API, what wrapper type allows action methods to return either a strongly typed domain object or standard HTTP status result helpers (such as Ok(), NotFound())?",
                    Options = new List<string>
                    {
                        "A) Task",
                        "B) IActionResult",
                        "C) ActionResult",
                        "D) ActionResult<T>"
                    },
                    CorrectAnswer = "D",
                    Explanation = "ActionResult<T> allows an action method to return either a strongly typed value or an HTTP action result such as Ok() or NotFound()."
                }
            };

            return View(questions);
        }
    }
}
