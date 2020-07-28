using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lesson11_1ClassExercise_EFCoreDbContextLINQSakilaDB
{
    // DBSet and Model Class
    // 1) Create a new class called Actor
    // 2) Add 
    //      - using Microsoft.EntityFrameworkCore;
    //      - using System.ComponentModel.dataAnnotations;
    // 3) In the Actor class, create 4 properties that represent the 
    //      table 1. actor_id  2. first_name 3. last_name 4. last_upate 
    class Actor
    {
        [Key]
        public int actor_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime last_update { get; set; }
    }

}
