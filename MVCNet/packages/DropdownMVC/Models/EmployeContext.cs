using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DropdownMVC.Models
{
    public class EmployeContext
    {

        string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();
        public  List<EmployeDetail>GetEmployeDetails()

       {
            List<EmployeDetail> EmployeDetailsList = new List<EmployeDetail>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpGetEmploye", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd .ExecuteReader();
            while (dr.Read())
            {

                EmployeDetail emp = new EmployeDetail();
                emp.ID = Convert.ToInt32(dr.GetValue(0).ToString());
                emp.Name = dr.GetValue(1).ToString();
                emp.Address = dr.GetValue(2).ToString();
                emp.Email = dr.GetValue(3).ToString();
                emp.Gender = dr["Gender"] == DBNull.Value ? true : Convert.ToBoolean(dr["Gender"].ToString());
                emp.StateID = Convert.ToInt32(dr.GetValue(5).ToString());
                emp.StateName = dr.GetValue(6).ToString();
                emp.CityID = Convert.ToInt32(dr.GetValue(7).ToString());
                emp.CityName = dr.GetValue(8).ToString();
                emp.DepartmentID = Convert.ToInt32(dr.GetValue(9).ToString());
                emp.DepartmentName = dr.GetValue(10).ToString();
                EmployeDetailsList.Add(emp);


            }
            con.Close();

            return EmployeDetailsList;


        }

        public bool insertEmployeDetail(EmployeDetail emp)
        {
            string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpEmployeInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Address", emp.Address);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@StateID", emp.StateID);
          //  cmd.Parameters.AddWithValue("@StateName", emp.StateName);
            cmd.Parameters.AddWithValue("@CityID", emp.CityID);
          //  cmd.Parameters.AddWithValue("@CityName", emp.CityName);
            cmd.Parameters.AddWithValue("@DepartmentID", emp.DepartmentID);
           // cmd.Parameters.AddWithValue("@DepartmentName", emp.DepartmentName);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdateEmployeDetail(EmployeDetail emp)
        {
            string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpEmployeUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", emp.ID);
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Address", emp.Address);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@StateID", emp.StateID);
            //  cmd.Parameters.AddWithValue("@StateName", emp.StateName);
            cmd.Parameters.AddWithValue("@CityID", emp.CityID);
            //  cmd.Parameters.AddWithValue("@CityName", emp.CityName);
            cmd.Parameters.AddWithValue("@DepartmentID", emp.DepartmentID);
            // cmd.Parameters.AddWithValue("@DepartmentName", emp.DepartmentName);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DeleteEmployeDetail(int id)
        {
            string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpEmployeDelete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public static List<State> GetStates()
        {
            string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet State = new DataSet();
            List<State> StateList = new List<State>();
            try
            {
                SqlDataAdapter obj = new SqlDataAdapter(cmd);
                obj.Fill(State);
                StateList = State.Tables[0].AsEnumerable().Select(dr => new State() 
                {
                    StateID = dr.Field<int>("StateID"),
                    StateName = dr.Field<string>("StateName"),
                }).ToList();
            }

            catch (Exception)
            {

            }
            con.Close();
            return StateList;

        }


        public static List<City> GetCitys(int StateID)
        {
            string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpCity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@StateID", StateID);
            DataSet City = new DataSet();
            cmd.Parameters.Add(param);
            List<City> CityList = new List<City>();
            try
            {
              SqlDataAdapter obj = new SqlDataAdapter(cmd);
                obj.Fill(City);
                DataTable dt = City.Tables[0];

                CityList = City.Tables[0].AsEnumerable().Select(dr => new City()
                {
                    CityID = dr.Field<int>("CityID"),
                    CityName = dr.Field<string>("CityName")
                }).ToList();
            }

            catch (Exception ex)
            {
                string a = ex.ToString();
            }
             //con.Close();
            return CityList;

        }



        public static List<Department> GetDepartment()
        {
            string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpDepartment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet Department = new DataSet();
            List<Department> DepartmentList = new List<Department>();
            try
            {
                SqlDataAdapter obj = new SqlDataAdapter(cmd);
                obj.Fill(Department);
                DepartmentList = Department.Tables[0].AsEnumerable().Select(dr => new Department()
                {
                    DepartmentID  = dr.Field<int>("DepartmentID"), 
                    DepartmentName = dr.Field<string>("DepartmentName")
                }).ToList();
            }

            catch (Exception)
            {

            }
           // con.Close();
            return DepartmentList;

        }










    }
}
    



