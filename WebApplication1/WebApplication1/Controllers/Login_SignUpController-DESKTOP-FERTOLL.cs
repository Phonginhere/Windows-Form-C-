using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Login_SignUpController : Controller
    {
        // GET: WhatTheTest
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetLogin(String tk, String mk)
        {
            String name = tk;
            String pass = mk;
            int i = 0;
            i++;
            //ViewBag.tk = name;
            //ViewBag.mk = pass;
            return View();
        }
        public ActionResult GetSignUp(String tk, String mk, String fn, String em)
        {
            String name = tk;
            String pass = mk;
            String fulln = fn;
            String email = em;
            int i = 0;
            i++;
            ViewBag.tk = name;
            ViewBag.mk = pass;
            ViewBag.fn = fulln;
            ViewBag.em = email;
            return View();
        }
    }
}