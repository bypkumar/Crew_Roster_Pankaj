using Crew_Roster.Constants;
using Crew_Roster_EntityAccesslayer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;


namespace Crew_Roster.Controllers
{
    public class UserController : Controller
    {

        public ActionResult login()
        {
            return View();
        }

        public ActionResult loginForm()
        {
            return View();
        }


        [HttpPost]
        public JsonResult submitLogin(string username, string password, int ecn)
        {

            // login API Call
            string returnJsonString = "";
            using (HttpClient httpClient = new HttpClient())
            {
                string queryremitter = "https://ent.spicejet.com/ldapauth/api/ldap_api/authenticateAPI";

                ApiParams ApiKeys = new ApiParams()
                {
                    ECN = ecn,
                    password = password,
                    username = username
                };

                // string depositor = "{username: 'ANKR101610845'," + "apikey:'" + 101736595743 + "',mobile:'" + 9881054074 + "'}";

                // Serialize the logon options object.
                string requestBodyAsString = JsonConvert.SerializeObject(ApiKeys);
                // Prepare the request content
                StringContent content =
                    new StringContent(
                        requestBodyAsString,
                        Encoding.UTF8,
                        "application/json"
                    );
                returnJsonString = string.Empty;
                using (var response = httpClient.PostAsync(queryremitter, content).Result)
                {
                    returnJsonString = response.Content.ReadAsStringAsync().Result;
                    var json_res = JsonConvert.DeserializeObject<Responce>(returnJsonString);
                    if (json_res.status == true)
                    {
                        Session["Username"] = json_res.username;
                    }
                }
            }

            return Json(returnJsonString, JsonRequestBehavior.AllowGet);
        }



        public ActionResult Logout()
        {
           // if (String.IsNullOrEmpty(Convert.ToString(Session["UserName"])))
             //   return RedirectToAction("Login", "User");

            Session["Username"] = null;

            return RedirectToAction("Login", "User");

        }
    }
}