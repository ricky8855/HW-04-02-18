using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_04_02_18.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NumInfo(double num)
        {
            ViewBag.theNumber = num;
            bool isInteger = (double)((int)num) == (double)num;
            ViewBag.isInteger = isInteger;
            bool isEven = (isInteger) ? (((int)num) % 2) == 0 : false;
            ViewBag.isEven = isEven;
            return View();
        }

        public ActionResult StringInfo(string str)
        {
            ViewBag.theStr = str;
            if (str != null)
            {
                ViewBag.reverseStr = new string(str.ToCharArray().Reverse().ToArray());
                ViewBag.upperStr = str.ToUpper();
                ViewBag.lowerStr = str.ToLower();
                ViewBag.length = str.Length;
            }
            return View();
        }

        //3.	StringInfo – פונקציה המקבלת מחרוזת ומחזירה דף אחד המכיל את המידע הבא:
        //●	המחרוזת המקורית שנשלחה
        //●	המחרוזת שנשלחה – בהצגה של revers(מהסוף להתחלה)
        //●	המחרוזת שנשלחה – בתצוגה של upper case
        //●	המחרוזת שנשלחה – בתצוגה של lower case
        //●	אורך המחרוזת שנשלחה(מספר התווים שיש במחרוזת)




    }
}