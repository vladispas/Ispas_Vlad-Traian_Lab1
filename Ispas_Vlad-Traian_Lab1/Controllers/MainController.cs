﻿using Microsoft.AspNetCore.Mvc;

namespace Ispas_Vlad_Traian_Lab1.Controllers
{
    public class MainController : Controller
    {
        public String Index()
        {
            return "Bun venit!";
            return SayHello();
            return PrintData("String Example", 8);
        }

        public String SayHello()
        {
            return "Hello!";
        }

        public String PrintData(String exampleString, int exampleInteger)
        {
            return "These are the parameters: " + exampleString + " " + exampleInteger;
        }

    }
}