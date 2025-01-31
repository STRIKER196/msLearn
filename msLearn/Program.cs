using System;

namespace msLearn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             You'll start with code that uses an if-elseif-else construct to evaluate the components of a product SKU.
            The SKU (Stock Keeping Unit) is formatted using three coded values: 
            <product #>-<2-letter color code>-<size code>. For example, a SKU value of 01-MN-L 
            corresponds to (sweat shirt)-(maroon)-(large), and the code outputs a description 
            that appears as "Product: Large Maroon Sweat shirt".
             */
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }
    }
}