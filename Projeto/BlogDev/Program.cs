﻿using System;
using BlogDev.Models;
using System.Data.SqlClient;

namespace BlogDev
{
    class Program
    {

        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";
        static void Main(string[] args)
        {

            Console.WriteLine("awdawda wd");





        }

        public static void ReadUsers()
        {
            using var connection = new SqlConnection(CONNECTION_STRING)
            {








            };
       


        }

    }

}

