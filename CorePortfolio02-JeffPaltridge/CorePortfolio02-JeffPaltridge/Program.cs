using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio02_JeffPaltridge
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Purpose: Calulate the cost of the gravel with price determined by weight and add delivery fee if delivery required
             *  Input: total weight of gravel and if the customer wants it delivered or not
             *  Process(es): if/else , switch, readline, writeline
             *  Output: example:
             *
             *               Welcome to Stoney Gravel Pit! 
             *
             *              Please enter the weight of gravel required: 2500 
             *              Do you require delivery (Y/N)? y 
             *
             *              The charge for 2500 lb of gravel is $0.35 per lb. 
             *
             *              Subtotal:       $875.00 
             *              Delivery:        $26.25
             *              GST:             $45.06
             *              -----------------------
             *              Total:          $946.31 
             *
             *              Thank you for your purchase! We hope your day rocks. 
             *              
             *              
             * Author: Jeff Paltridge
             * Last modified: 2020.02.05 
             */

            string inputWeight, deliveryInput;
            double deliveryCost = 0;
            string deliveryMsg = " ";
            double totalWeight, totalGst, totalCost, gravelCost, gravelPrice;
            
            const double PRICE1 = 0.55;
            const double PRICE2 = 0.45;
            const double PRICE3 = 0.35;
            const double PRICE4 = 0.25;
            const double PRICE5 = 0.15;
            const double PRICE6 = 0.10;
            const double GST = 0.05;
            const double WEIGHT1 = 1000;
            const double WEIGHT2 = 2000;
            const double WEIGHT3 = 3000;
            const double WEIGHT4 = 4000;
            const double WEIGHT5 = 5000;
            const double DELIVERYFEE = 0.03;
            const double DELIVERYDEFAULT = 0.00;

            Console.WriteLine("Welcome to Stoney Gravel Pit!");
            Console.WriteLine();
            
            Console.Write("Please enter the weight of gravel required: ");
            inputWeight = Console.ReadLine();
            totalWeight = double.Parse(inputWeight);

            if (totalWeight < WEIGHT1)
            {
                gravelPrice = PRICE1;
            }

                else if (totalWeight >= WEIGHT1 && totalWeight < WEIGHT2)
                {
                    gravelPrice = PRICE2;
                }

                else if (totalWeight >= WEIGHT2 && totalWeight < WEIGHT3)
                {
                    gravelPrice = PRICE3;
                }
                else if (totalWeight >= WEIGHT3 && totalWeight < WEIGHT4)
                {
                    gravelPrice = PRICE4;
                }

                else if (totalWeight >= WEIGHT4 && totalWeight < WEIGHT5)
                {
                    gravelPrice = PRICE5;
                }

            else
            {
                gravelPrice = PRICE6;            
            }

            gravelCost = totalWeight * gravelPrice;

            Console.Write("Do you require delivery (Y/N)? ");
            deliveryInput = Console.ReadLine();
            

            Console.WriteLine();
            Console.WriteLine($"The charge for {totalWeight:0} lb of gravel is ${gravelPrice:0.00} per lb.");


            
            switch (deliveryInput.ToUpper())
            {

                case "Y":
                    {
                        if (totalWeight <= 4800)
                        {
                            deliveryCost = gravelCost * DELIVERYFEE;
                        }

                        else
                        {
                            deliveryCost = DELIVERYDEFAULT;
                            deliveryMsg = "(free delivery)";
                        }

                    }
                    break;

                default:
                    break;
            }//eos

          
            totalGst = (gravelCost + deliveryCost) * GST;
            totalCost = gravelCost + deliveryCost + totalGst;
            Console.WriteLine();
            Console.WriteLine("Subtotal:{0,13:$0.00}", gravelCost);
            Console.WriteLine("Delivery:{0,13:$0.00} {1}", deliveryCost, deliveryMsg);
            Console.WriteLine("GST:{0,18:$0.00}", totalGst);
            Console.WriteLine("----------------------");
            Console.WriteLine("Total:{0,16:$0.00}", totalCost);
            Console.WriteLine();
            Console.WriteLine("Thank you for your purchase! We hope your day rocks.");


            Console.ReadKey();

        }
    }
}
