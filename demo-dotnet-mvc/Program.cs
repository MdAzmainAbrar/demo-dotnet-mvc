var builder = WebApplication.CreateBuilder(args); //why? because it sets up the web application with default configurations,
                                                  //services, and middleware. It simplifies the process of creating a web
                                                  //application by providing a fluent API for configuring services and the application's
                                                  //request pipeline. This allows developers to focus on building their application rather
                                                  //than dealing with the underlying infrastructure.

builder.Services.AddControllersWithViews(); //this line adds support for MVC (Model-View-Controller) architecture to the web
                                            //application. It registers the necessary services for handling controllers and views,
                                            //allowing you to create a structured web application with separation of concerns.
                                            //This enables you to define controllers that handle HTTP requests and return views
                                            //as responses, facilitating the development of dynamic web applications.

var app = builder.Build(); //this line builds the web application using the configurations and services defined in the builder.
                           //It compiles the application's request pipeline and prepares it to handle incoming HTTP requests.
                           //After this line, you can define routes, middleware, and other configurations before running the application.
app.UseStaticFiles(); //this line enables the application to serve static files (like HTML, CSS, JavaScript, images, etc.)
                      //from the wwwroot folder.
                      //This allows you to include and serve static content in your web application, which is essential
                      //for building a complete web experience.

app.MapDefaultControllerRoute(); //This line sets up the default routing for the application, which follows the pattern
                                 //"{controller=Home}/{action=Index}/{id?}".
                                 //This means that if a request is made to the root URL ("/"), it will be directed to the
                                 //"Home" controller and the "Index" action by default.
                                 //You can customize this routing pattern as needed, but this provides a simple starting point
                                 //for handling requests in an MVC application.

app.Run(); //this line starts the web application and begins listening for incoming HTTP requests. It will keep the application
           //running until it is stopped, allowing it to handle requests and send responses as defined in the routes and
           //middleware configured earlier.
