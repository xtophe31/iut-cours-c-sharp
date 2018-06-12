using System.Web.Mvc;

namespace Cours.MVC.Tuto1.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        //public string Index(int? id)
        //{
        //    return String.Format("Nombre {0}", id);
        //}

//        public string Index(string id)
//        {
//            if (string.IsNullOrEmpty(id)) id = "l'inconnu";
//            return String.Format(@"
//            <html>
//            <head>
//                <title>Hello World</title>
//            </head>
//            <body>
//                <h1>Hello World</h1>
//                <p>Bonjour <strong>{0}</strong></p>
//            </body>
//            </html>
//            ", id);
//        }

    }
}