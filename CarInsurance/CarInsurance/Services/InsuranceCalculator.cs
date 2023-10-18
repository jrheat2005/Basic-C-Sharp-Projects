using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Services
{
    public class InsuranceCalculator
    {
        public decimal CalculateQuote(Insuree insuree)
        {
            decimal monthlyTotal = 50;

            // Age-based adjustments
            if (insuree.DateOfBirth.Year >= DateTime.Now.Year - 18)
            {
                monthlyTotal += 100;
            }
            else if (insuree.DateOfBirth.Year >= DateTime.Now.Year - 25)
            {
                monthlyTotal += 50;
            }
            else
            {
                monthlyTotal += 25;
            }

            // Car year-based adjustments
            if (insuree.CarYear < 2000)
            {
                monthlyTotal += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                monthlyTotal += 25;
            }

            // Car make and model-based adjustments
            if (insuree.CarMake == "Porsche")
            {
                monthlyTotal += 25;
                if (insuree.CarModel == "911 Carrera")
                {
                    monthlyTotal += 25;
                }
            }

            // Speeding ticket and DUI adjustments
            monthlyTotal += insuree.SpeedingTickets * 10;
            if (insuree.DUI)
            {
                monthlyTotal *= 1.25m;
            }

            // Full coverage adjustment
            if (insuree.CoverageType == "Full")
            {
                monthlyTotal *= 1.5m;
            }

            return monthlyTotal;
        }
    }
}