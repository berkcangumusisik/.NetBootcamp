﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public enum  SalaryType
    {
        Manager = 1,
        Developer = 2,
        Tester = 3 
    }

    public class SuperSalaryCalculator
    {
        public decimal GoodCalculate(int workingHours, int childCount, Func<int, int, decimal> calculateDelegate)
        {
            var salary = calculateDelegate(workingHours, childCount);

            return salary;
        }
    }


    public class SalaryCalculator
    {
        public static decimal ManagerCalculate(int workingHours, int childCount)
        {
            return workingHours * childCount * 100;
        }

        public static decimal DeveloperCalculate(int workingHours, int childCount)
        {
            return workingHours * childCount * 50;
        }

        public static decimal TesterCalculate(int workingHours, int childCount)
        {
            return workingHours * childCount * 30;
        }

        public decimal JuniorCalculate(int workingHours, int childCount)
        {
            return workingHours * childCount * 2;
        }

        public decimal GoodCalculate(int workinghours, int childCount, Func<SalaryType, int, int, decimal> calculate)
        {
            return calculate(SalaryType.Manager, workinghours, childCount);
        }
        public decimal Calculate(SalaryType salaryType, int workingHours, int childCount)
        {
            decimal salary = 0;

            switch (salaryType)
            {
                case SalaryType.Manager:
                    salary = workingHours * 100 * childCount;
                    break;
                case SalaryType.Developer:
                    salary = workingHours * 50 * childCount;
                    break;
                case SalaryType.Tester:
                    salary = workingHours * 30 * childCount;
                    break;
                default:
                    break;
            }

            return salary;
        }
    }
}
