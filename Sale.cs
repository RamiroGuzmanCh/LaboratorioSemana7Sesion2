using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSale
{
    public class Sale
    {
        public Sale() { 
        
        }

        //RETURN PRICE APPLYING DISCOUNT OR PRICE ORIGINAL
        public double GetFulllDiscount(double priceOriginal, bool valideDiscount)
        {

            double fullDiscount = 20;
            if (valideDiscount == true)
            {
                double applyDiscount = priceOriginal * fullDiscount / 100;
                fullDiscount = priceOriginal - applyDiscount;

                return fullDiscount;
            }
            else
            {
                fullDiscount = priceOriginal - 0;
                return fullDiscount;

            }

        }


        //RETURN PRICE ADDING TAXES OR PRICE ORIGINAL
        public double GetFullTaxes(double priceOriginal, bool taxes)
        {
            double priceTaxes = 1;
            if (taxes == true) // validate if the product is affected
            {
                priceOriginal = priceOriginal + priceTaxes * 0.18;//adding taxes IGV
                return priceOriginal;
            }
            else
            {
                priceOriginal = priceTaxes + 0; // no tax added
                return priceOriginal;

            }
        }



    }
    
}
