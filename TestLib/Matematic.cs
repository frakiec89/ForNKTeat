﻿namespace TestLib
{
    public class Matematic
    {
        public double DelA_B (int  a , int b )
        {
            try
            {
                return  (double) a / (double)b ;
            }
            catch 
            {
               throw new System.Exception("Error");
            }
           
        }
    }
   
}
