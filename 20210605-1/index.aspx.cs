using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _20210605_1
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CarSharingConnectionString"].ConnectionString);
        SqlCommand cmd = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string sSql = "";
            if (DropDownList1.SelectedValue == "SELECT-FROM-WHERE")
                sSql = "SELECT * FROM EMPLOYEE WHERE department_id = 'D02' ";
            else if (DropDownList1.SelectedValue == "DELETE")
                sSql = "DELETE FROM CAR WHERE owner_id='E0016'; SELECT * FROM CAR ";
            else if (DropDownList1.SelectedValue == "INSERT")
                sSql = "INSERT INTO CAR VALUES ('C009', 'E0016', 5); SELECT * FROM CAR ";
            else if (DropDownList1.SelectedValue == "UPDATE")
                sSql = "UPDATE CAR SET capacity=7 WHERE owner_id = 'E0016'; SELECT * FROM CAR ";
            else if (DropDownList1.SelectedValue == "IN")
                sSql = "SELECT * FROM EMPLOYEE WHERE live_city IN ('屏東縣', '高雄市')";
            else if (DropDownList1.SelectedValue == "NOT IN")
                sSql = "SELECT * FROM EMPLOYEE WHERE live_city NOT IN ('屏東縣', '高雄市')";
            else if (DropDownList1.SelectedValue == "EXISTS")
                sSql = "SELECT * FROM EMPLOYEE WHERE EXISTS(SELECT* FROM TAKE_CAR WHERE employee_id = participant AND meeting_id = 'M0001' AND car_id = 'C003')";
            else if (DropDownList1.SelectedValue == "NOT EXISTS")
                sSql = "SELECT * FROM EMPLOYEE WHERE NOT EXISTS(SELECT* FROM TAKE_CAR WHERE employee_id = participant AND meeting_id = 'M0001')";
            else if (DropDownList1.SelectedValue == "COUNT")
                sSql = "SELECT COUNT(participant) AS count_participant FROM TAKE_CAR WHERE meeting_id = 'M0001' ";
            else if (DropDownList1.SelectedValue == "SUM")
                sSql = "SELECT SUM(capacity) AS sum_capacity FROM CAR ";
            else if (DropDownList1.SelectedValue == "MAX")
                sSql = "SELECT MAX(age) as max_age FROM EMPLOYEE ";
            else if (DropDownList1.SelectedValue == "MIN")
                sSql = "SELECT MIN(age) as min_age FROM EMPLOYEE ";
            else if (DropDownList1.SelectedValue == "AVG")
                sSql = "SELECT AVG(age) as avg_age FROM EMPLOYEE ";
            else if (DropDownList1.SelectedValue == "HAVING")
                sSql = "SELECT meeting_id,COUNT(participant) AS 參與人數 FROM TAKE_CAR GROUP BY meeting_id HAVING COUNT(participant)> 4";
            else if (DropDownList1.SelectedValue == "SQL")
                sSql = TextBox1.Text;
            //string sSql = "select " + TextBox1.Text + " from Meeting; ";
            //string sSql = "select date from Meeting";
            connection.Open();
            cmd = new SqlCommand(sSql, connection);
            //執行此SQL查詢
            SqlDataReader dr = cmd.ExecuteReader();
            //指定GV的資料是查到的SQL
            GridView1.DataSource = dr;
            //資料連接
            GridView1.DataBind();
            //顯示執行的指令
            Label1.Text = sSql;
            //release物件與資源
            connection.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}