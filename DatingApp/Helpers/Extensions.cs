using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Helpers
{
    public static class Extensions //because we dont want to create a new instant for this class when we want to use on of its method cuz it will be in the extension menu we made it statis
    {
        public static void AddApplicationError(this HttpResponse responce,string message)
        {
            responce.Headers.Add("Application-Error", message);
            responce.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            responce.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}
