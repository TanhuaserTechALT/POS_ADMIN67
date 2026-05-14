using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace REGULLANO_OOPL01E_CPE_201
{
    internal class payrol_variable
    {
        public double tax;
        public double basic_netincome = 0.00,
                      basic_numhrs = 0.00,
                      basic_rate = 0.00,
                      hono_netincome = 0.00,
                      hono_numhrs = 0.00,
                      hono_rate = 0.00,
                      other_netincome = 0.00,
                      other_numhrs = 0.00,
                      other_rate = 0.00;

        public double netincome = 0.00,
                      grossincome = 0.00,
                      sss_contrib = 0.00,
                      pagibig_contrib = 0.00,
                      philhealth_contrib = 0.00,
                      tax_contrib = 0.00;

        public double sss_loan = 0.00,
                      pagibig_loan = 0.00,
                      salary_loan = 0.00,
                      salary_savings = 0.00,
                      faculty_sav_loan = 0.00,
                      other_deduction = 0.00,
                      total_deduction = 0.00,
                      total_contrib = 0.00,
                      total_loan = 0.00;
    }                
}
