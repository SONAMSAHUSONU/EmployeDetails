using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeDetails.Models
{
    public class EmployeModelManager
    {
        public List<EmployeModel> GetEmploye()
        {
            List<EmployeModel> employeModels = new List<EmployeModel>();
            string scn = ConfigurationManager.ConnectionStrings["scn"].ConnectionString;
            SqlConnection cn = new SqlConnection(scn);
            SqlCommand cmd = new SqlCommand("",cn);

            return null;
        }
    }
}