﻿using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.DataContext
{
    static class DbContext //crud
    {
        public static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        static DbContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();

        }
    }
}
