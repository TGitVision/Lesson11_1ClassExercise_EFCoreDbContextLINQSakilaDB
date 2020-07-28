using System;
using System.Linq;

namespace Lesson11_1ClassExercise_EFCoreDbContextLINQSakilaDB
{
    class Program
    {
        #region Program Outline

        // Adding EntityFramework
        // 1) In a new project, click Tools > NuGet Package Manager > Package Manager Console
        // 2) In the Package Manager Console window type: 
        // PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer

        // 1) Create a new class in C#
        // 2) Add the line using Microsoft.EntityFrameworkCore
        // 3) Edit SakilaContext to inherit from DbContext
        // 4) Add the following method. This method describes how to connect to Sakila.

        // DBSet and Model Class
        // 1) Create a new class called Actor
        // 2) Add 
        //      - using Microsoft.EntityFrameworkCore;
        //      - using System.ComponentModel.dataAnnotations;
        // 3) In the Actor class, create 4 properties that represent the 
        //      table 1. actor_id  2. first_name 3. last_name 4. last_upate 

        // Working with Data
        // 1) Add using System.Linq; to the top of our Program.cs class. We’ll talk about Linq next.
        // 2) In our Main() method, first, we need to create a new context. 
        // 3) Next, create an array of actors and set it equal to context.Actor.ToArray();  
        // What this does is get all of the actor records from the database and put’s them in an array.  
        // 4. Then, loop through the array, printing the name of each actor. 

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson11_1ClassExercise_EFCoreDbContextLINQSakilaDB!");

            SakilaContext context = new SakilaContext();
            Actor[] actors = context.Actor.ToArray();
            foreach (Actor a in actors)
            {

                // Print the name of each actor.
                Console.WriteLine($"{a.first_name} {a.last_name}");
                //Console.WriteLine(a.first_name + " " + a.last_name);

            }

        }
    }
}
