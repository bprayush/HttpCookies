using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HttpCookies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * CHECK IF THE BROWSER HAS COOKIE ENABLED OR NOT
             * ALSO CHECKS IF THE BROWSER SUPPORTS COOKIE
             */
            checkCookieSupport();
        }

        /*
         * FUNCTION TO ADD COOKIE
         */ 
        protected void AddCookie(object sender, EventArgs e)
        {
            /*
             * INITIALIZE HTTP COOKIE OBJECT
             * CONSTRUCTOR TAKES ONE ARG: COOKIE NAME
             * OVERLOADED CONSTRUCTOR TAKES SECOND ATTRIBUTE i.e. STRING VALUE
             */
            HttpCookie cookie = new HttpCookie(CookieName.Text);
            /*
             * RESPONSE TYPE FOR COOKIE (SECURE/INSECURE)
             * i.e. SSL(secure)
             * cookie.Secure = true; SETS THE TRANSMISISON MODE TO USE SSL/TLS
             */
            cookie.Secure = false;
            /*
             * ASSIGN VALUES (Key value pairs) 
             */
            cookie["user"] = User.Text;
            cookie["email"] = Email.Text;
            /*
             * cookie.Expires PROPERTY IS USED TO SET THE COOKIE EXPIRATION DATE
             * DEFAULT IS AFTER THE BROWSER CLOSES
             */ 
            cookie.Expires = DateTime.Now.AddDays(30);
            /*
             * ADD THE COOKIE TO THE BROWSER USING Response.Cookies.Add() method
             */ 
            Response.Cookies.Add(cookie);

            CookieNameLabel.Text = "";
            StatusLabel.Text = "Cookie added!";
            emptyData();
        }

        /*
         * FUNCTION TO READ COOKIE
         */
        protected void ReadCookie(object sender, EventArgs e)
        {
            /*
             * TO GET THE COOKIE WE USE THE Request.Cookies attribute
             */ 
            HttpCookie cookie = Request.Cookies[CookieName.Text];
            /*
             * CHECK IF THE COOKIE EXISTS OR NOT
             */ 
            if (cookie != null)
            {
                CookieNameLabel.Text = CookieName.Text;
                /*
                 * GET THE COOKIE DATA
                 */ 
                CookieUserLabel.Text = cookie["user"];
                CookieEmailLabel.Text = cookie["email"];
                StatusLabel.Text = "Cookie Read!";
            }
            else
            {
                CookieNameLabel.Text = CookieName.Text;
                emptyData();
                StatusLabel.Text = "Could not find cookie data!";
            }
        }

        /*
         * FUNCTION TO DELETE COOKIE
         */ 
        protected void DeleteCookie(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies[CookieName.Text];
            /*
             * CHECK IF THE COOKIE EXISTS OR NOT
             */ 
            if (cookie != null)
            {
                /*
                 * SETTING THE DAY TO PREVIOUS DAY EXPIRES THE COOKIE
                 */
                cookie.Expires = DateTime.Now.AddDays(-1);
                CookieNameLabel.Text = CookieName.Text;
                emptyData();
                StatusLabel.Text = "Cookie deleted successfully!";
                /*
                 * DON'T FORGET TO UPDATE THE COOKIE!
                 */ 
                Response.Cookies.Add(cookie);
            }
            else
            {
                CookieNameLabel.Text = CookieName.Text;
                emptyData();
                StatusLabel.Text = "Could not find cookie data!";
            }
        }


        /*
         * FUNCTION TO DISPLAY BROWSER COOKIE SUPPORT
         */ 
        protected void checkCookieSupport()
        {
            /*
             * Request.Browser.Cookies RETURNS TRUE IF BROWSER SUPPORTS COOKIES OR NOT
             */
            if (Request.Browser.Cookies)
            {
                CookieEnabledLabel.Text = "Cookies supported!";
            }
            else
            {
                CookieEnabledLabel.Text = "Your browser doesn't support cookies!";
            }
        }

        /*
         * FUNCTION TO EMPTY THE RESULT LABELS
         */ 
        protected void emptyData()
        {
            CookieUserLabel.Text = "";
            CookieEmailLabel.Text = "";
        }
    }
}