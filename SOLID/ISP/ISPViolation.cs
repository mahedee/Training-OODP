﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Violation
{
    public interface IReportBAL
    {
        //For Employee
        void GeneratePFReport();
        void GenerateESICReport();

        //Manager = Employee + Own
        void GenerateResourcePerformanceReport();
        void GenerateProjectSchedule();

        //Admin = Employee + Manager + Own
        void GenerateProfitReport();
    }
    public class ReportBAL : IReportBAL
    {
        public void GeneratePFReport()
        {/*...............*/}

        public void GenerateESICReport()
        {/*...............*/}

        public void GenerateResourcePerformanceReport()
        {/*...............*/}

        public void GenerateProjectSchedule()
        {/*...............*/}

        public void GenerateProfitReport()
        {/*...............*/}
    }
    public class EmployeeUI
    {
        public void DisplayUI()
        {
            IReportBAL objBal = new ReportBAL();
            objBal.GenerateESICReport();
            objBal.GeneratePFReport();
        }
    }
    public class ManagerUI
    {
        public void DisplayUI()
        {
            IReportBAL objBal = new ReportBAL();
            objBal.GenerateESICReport();
            objBal.GeneratePFReport();
            objBal.GenerateResourcePerformanceReport();
            objBal.GenerateProjectSchedule();
        }
    }
    public class AdminUI
    {
        public void DisplayUI()
        {
            IReportBAL objBal = new ReportBAL();
            objBal.GenerateESICReport();
            objBal.GeneratePFReport();
            objBal.GenerateResourcePerformanceReport();
            objBal.GenerateProjectSchedule();
            objBal.GenerateProfitReport();
        }
    }

}
