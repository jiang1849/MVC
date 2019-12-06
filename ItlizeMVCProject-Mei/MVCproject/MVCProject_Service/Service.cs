using MVCProject_Repository;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MVCProject_Service
{
    public class Service
    {
        static string val = "metadata = res://*/ItlizeMVCProject.csdl|res://*/ItlizeMVCProject.ssdl|res://*/ItlizeMVCProject.msl;provider=System.Data.SqlClient;provider connection string='data source=LENOVO-PC\\SQLEXPRESS;initial catalog=ItlizeMVCProject;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework;'";
        static DbContext context = new DbContext(val);
        

       

    }
}