using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using IncreasingView.Controllers;



namespace IncreasingView
{
    public partial class Counter : System.Web.UI.Page
    {
        HomeController hc = new HomeController();
        
        protected void Page_Load()
        {
            Response.Write("Có" + Application["countOnline"].ToString() + " người đang truy cập.");
        }
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //write your handler implementation here.
        }

        #endregion
    }
}
