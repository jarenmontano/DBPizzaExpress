/* Order.cs
 * Author: Jaren Montano
 * Date: 10/26/2023
 * Purpose: This holds the data
 * for the users pizza order from the gui
 */



using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    internal class Order
    {
        public string[] pizzaSize = new string[]
        {
            "Small (8\") - $8.50",
            "Medium (12\") - $12.50",
            "Large (16\") - $16.50"
        };
        public decimal[] pizzaPrice = new decimal[]
        {
            8.50m,12.50m,16.50m
        };

        public string[] otherItems = new string[]
        {
            "Nothing",
            "Wings - $5.00",
            "Cheese Sticks - $4.00",
            "Garlic Bread - $3.00"
        };
        public decimal[] otherItemsPrice = new decimal[] 
        {
            0.00m,
            5.00m,
            4.00m,
            3.00m
        };


        // toppings cost 1.50 each
        public string[] toppings = new string[]
        {
            "Pepperoni",
            "Extra Cheese",
            "Onions",
            "Garlic",
            "Green Peppers",
            "Green Olives",
            "Mushrooms",
            "Sausage",
            "Italian Sausage",
            "Ham",
            "Chicken",
            "Salt",
            "Pepper",
            "Oregano"
        };

        public string Size { get; set; }// goes with pizza size
        public decimal Price { get; set; } //goes with pizza price
        public string Crust { get; set; }//just pulls from the form
        public string Sauce { get; set; }// just pulls from the form

        public string SpecialtyPizzas { get; set; }// just pulls from the form
        public int Waters { get; set; } // just pulls from form
        public decimal Sodas { get; set; } // pulls from form then must be multiplied 
        public bool[] Toppings { get; set; }// still havent figured this one out,
           // may need to be an array

        //still need to add the specialty items----------------
        public string OtherItemSelected { get; set; }
        public decimal OtherItemPriceSelected { get; set; }

        
        //-----------------------------------------------

        //this is the customer info
        public string Name { get; set; }
        public string DeliveryAddress { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        
        public Order() 
        { 
            Size = string.Empty;
            Price = 0;
            Crust = string.Empty;
            Sauce = string.Empty;
            SpecialtyPizzas = string.Empty;
            Waters = 0;
            Sodas = 0;
            Toppings = new bool[] { 
            false, false,false, false,false, false,false, false,false, false,false, false,false, false,
            }; // only 11 possible toppings, should probably use an arraylist

            Name = string.Empty;
            DeliveryAddress = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            OtherItemPriceSelected = 0m;
            OtherItemSelected = string.Empty;
        
        }

        public void SetOtherItemPrice()
        {
            for (int i = 0; i < otherItems.Length; i++)
            {
                if (otherItems[i] == OtherItemSelected)
                {
                    OtherItemPriceSelected = otherItemsPrice[i];
                }
            }
        }
        //once size is selcted it is storing the price
        public void SetPizzaPrice()
        {
            for (int i = 0; i < pizzaSize.Length; i++)
            {
                if (pizzaSize[i] == Size)
                {
                    Price = pizzaPrice[i];
                }
            }
        }
        public void SetToppings(int index)
        {
            Toppings[index] = true;

        }
        //this will return an array of true or false
        public decimal DetermineToppingsCost()
        {
            decimal count = 0.0m;
            for (int i = 0; i < Toppings.Length; i++)
            {
                if (Toppings[i]) { count++; }
            }


            return count * 1.50m;    
        }

        public string DetermineToppings()
        {
            string toppingsSelected ="";
            for (int i = 0; i < Toppings.Length; i++)
            {
                if (Toppings[i]) {
                    toppingsSelected += "\n" + toppings[i] ; 
                }
            }

            return toppingsSelected;
            
        }

        public decimal DetermineTotalCharges()
        {
            SetOtherItemPrice();
            SetPizzaPrice();
            return DetermineToppingsCost() + Price + (Sodas * 1.75m) + OtherItemPriceSelected;

        }


        //will need to overide the to string to return 
        //all of the data formated correctly.
        public override string ToString()
        {
            return 
                  "Total Cost: " + DetermineTotalCharges().ToString("C2");

        }


    }
}
