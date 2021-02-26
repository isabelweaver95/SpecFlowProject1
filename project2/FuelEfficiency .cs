using System;

namespace sharedLib
{
    public class FuelEfficiency 
    {
        public float calc_mpg(float miles, float gallons)
        {
            return miles / gallons;
        }

        public bool gasHog(int miles, int gallons)
        {
            
            if (miles <= 100 && gallons >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public float calcGallons(float mpg, float miles)
        {
            return miles / mpg;
 
        }

        public float calcMiles(float mpg, float gallons)
        {
            return mpg * gallons;
        }

        public float calcFuelUse(float gallons, float tank)
        {
            return gallons / tank;
        }

        public float calcPay(float price, float card)
        {
            if(card <= price)
            {
                return 0;
            }
            return card / price;
        }


    }
}
