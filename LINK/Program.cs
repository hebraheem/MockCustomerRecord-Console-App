﻿using System;

namespace LINK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Samples ViewModel
            // SamplesViewModel vm = new SamplesViewModel
            SalesSampleModelView vm = new SalesSampleModelView
            {
                // Use Query or Method Syntax?
                UseQuerySyntax = false
            };

            // Call a sample method
            vm.AggregateGroup();

            // Display Product Collection
            foreach (var item in vm.Products)
            {
                Console.Write(item.ToString());
            }

            // Display Result Text
            Console.WriteLine(vm.ResultText);
        }
    }
}
