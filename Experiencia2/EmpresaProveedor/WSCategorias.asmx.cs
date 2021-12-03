using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EmpresaProveedor
{
    /// <summary>
    /// Descripción breve de WSCategorias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCategorias : System.Web.Services.WebService
    {

        private string connectionString; public WSCategorias()
        { 
            //Eliminar la marca de comentario de la línea siguiente si utiliza los 
            // componentes diseñados 
            //InitializeComponent();
            connectionString = "Data Source=UNKNOWN\\sqlexpress;Initial Catalog = Northwind; Integrated Security = True"; 
        }

        [WebMethod]
        public DataSet GetCategorias()
        {
            string selectSQL = "SELECT CategoryID,CategoryName, Description FROM Categories"; 
            SqlConnection con = new SqlConnection(connectionString); 
            SqlCommand cmd = new SqlCommand(selectSQL, con); 
            //SqlDataReader reader;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
            DataSet dsCategorias = new DataSet(); 
            // Fill the same table.
            adapter.Fill(dsCategorias, "Categories"); 
            return dsCategorias;
        }

        [WebMethod]
        public DataSet GetProductos()
        {
            string selectSQL = "SELECT ProductID, ProductName,CategoryID, UnitPrice,UnitsInStock FROM Products"; 
            SqlConnection con = new SqlConnection(connectionString); 
            SqlCommand cmd = new SqlCommand(selectSQL, con); 
            //SqlDataReader reader;
            SqlDataAdapter daProductos = new SqlDataAdapter(cmd); 
            DataSet dsProductos = new DataSet(); 
            // Fill the same table.
            daProductos.Fill(dsProductos, "Productos"); return dsProductos; 
        }
    }
}
