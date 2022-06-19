using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prj1091613.Models;
using PagedList;
using System.Web.Security;

namespace prj1091613.Controllers
{
    public class HomeController : Controller
    {
        dbEntities db = new dbEntities();

        int pageSize = 15;
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tell()
        {
            return View();
        }

        public ActionResult IndexIn()
        {
            return View();
        }

        //----------------------------簡介----------------------------------
        public ActionResult Interduce(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var people = db.TableIntroductions1091613.OrderBy(m => m.IDate).ToList();
            var result = people.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult InCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InCreate(TableIntroductions1091613 people)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Error = false;
                var temp = db.TableIntroductions1091613
                    .Where(m => m.IName == people.IName)
                    .FirstOrDefault();
                if (temp != null)
                {
                    ViewBag.Error = true;
                    return View(people);
                }
                db.TableIntroductions1091613.Add(people);
                db.SaveChanges();
                return RedirectToAction("Interduce");
            }
            return View(people);
        }

        public ActionResult InEdit(string IName)
        {
            var people = db.TableIntroductions1091613
                .Where(m => m.IName == IName).FirstOrDefault();
            return View(people);
        }

        [HttpPost]
        public ActionResult InEdit(TableIntroductions1091613 people)
        {
            if (ModelState.IsValid)
            {
                var temp = db.TableIntroductions1091613
                    .Where(m => m.IName == people.IName)
                    .FirstOrDefault();
                temp.IID = people.IID;
                temp.IGrander = people.IGrander;
                temp.IMail = people.IMail;
                temp.IDate = people.IDate;
                temp.ISchool = people.ISchool;
                temp.Iabout = people.Iabout;
                db.SaveChanges();
                return RedirectToAction("Interduce");
            }
            return View(people);
        }

        public ActionResult InDelete(string IName)
        {
            var people = db.TableIntroductions1091613
                .Where(m => m.IName == IName).FirstOrDefault();
            db.TableIntroductions1091613.Remove(people);
            db.SaveChanges();
            return RedirectToAction("Interduce");
        }

        //----------------------------行程----------------------------------

        public ActionResult Travel(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var locate = db.TableTravel1091613.OrderBy(m => m.TNo).ToList();
            var result = locate.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult TraCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TraCreate(TableTravel1091613 tra)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Error = false;
                var temp = db.TableTravel1091613
                    .Where(m => m.TId == tra.TId)
                    .FirstOrDefault();
                if (temp != null)
                {
                    ViewBag.Error = true;
                    return View(tra);
                }
                db.TableTravel1091613.Add(tra);
                db.SaveChanges();
                return RedirectToAction("Travel");
            }
            return View(tra);
        }

        public ActionResult TraEdit(string TId)
        {
            var people = db.TableTravel1091613
                .Where(m => m.TId == TId).FirstOrDefault();
            return View(people);
        }

        [HttpPost]
        public ActionResult TraEdit(TableTravel1091613 people)
        {
            if (ModelState.IsValid)
            {
                var temp = db.TableTravel1091613
                    .Where(m => m.TId == people.TId)
                    .FirstOrDefault();
                temp.TNo = people.TNo;
                temp.TName = people.TName;
                temp.TDateStart = people.TDateStart;
                temp.TDateEnd = people.TDateEnd;
                db.SaveChanges();
                return RedirectToAction("Travel");
            }
            return View(people);
        }

        public ActionResult TraDelete(string TId)
        {
            var people = db.TableTravel1091613
                .Where(m => m.TId == TId).FirstOrDefault();
            db.TableTravel1091613.Remove(people);
            db.SaveChanges();
            return RedirectToAction("Travel");
        }
        //----------------------------收購----------------------------------
        public ActionResult Buy(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var people = db.TableAcquisition1091613.OrderBy(m => m.AId).ToList();
            var result = people.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult BuyCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuyCreate(TableAcquisition1091613 people)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Error = false;
                var temp = db.TableAcquisition1091613
                    .Where(m => m.AId == people.AId)
                    .FirstOrDefault();
                if (temp != null)
                {
                    ViewBag.Error = true;
                    return View(people);
                }
                db.TableAcquisition1091613.Add(people);
                db.SaveChanges();
                return RedirectToAction("Buy");
            }
            return View(people);
        }

        public ActionResult BuyEdit(string AId)
        {
            var people = db.TableAcquisition1091613
                .Where(m => m.AId == AId).FirstOrDefault();
            return View(people);
        }

        [HttpPost]
        public ActionResult BuyEdit(TableAcquisition1091613 people)
        {
            if (ModelState.IsValid)
            {
                var temp = db.TableAcquisition1091613
                    .Where(m => m.AId == people.AId)
                    .FirstOrDefault();
                temp.AName = people.AName;
                temp.ANo = people.ANo;
                temp.APrice = people.APrice;
                temp.ARemark = people.ARemark;
                db.SaveChanges();
                return RedirectToAction("Buy");
            }
            return View(people);
        }

        public ActionResult BuyDelete(string AId)
        {
            var people = db.TableAcquisition1091613
                .Where(m => m.AId == AId).FirstOrDefault();
            db.TableAcquisition1091613.Remove(people);
            db.SaveChanges();
            return RedirectToAction("Buy");
        }

        //----------------------------推推明星----------------------------------
        public ActionResult Star(int scid = 1)
        {
            ViewBag.SC = db.TableSClass1091613
                .Where(m => m.SCId == scid)
                .FirstOrDefault().SCName + "類別";
            SCEmp vm = new SCEmp()
            {
                SClass = db.TableSClass1091613.ToList(),
                Star = db.TableStar1091613
                .Where(m => m.SCId == scid).ToList()
            };
            return View(vm);
        }

        public ActionResult SCCreate()
        {
            return View(db.TableSClass1091613.ToList());
        }

        [HttpPost]
        public ActionResult SCCreate(TableStar1091613 emp)
        {
            try
            {
                db.TableStar1091613.Add(emp);
                db.SaveChanges();
                return RedirectToAction
                    ("Star", new { scid = emp.SCId });
            }
            catch(Exception ex)
            {}
            return View(emp);
        }

        public ActionResult SCDelete(string SCId)
        {
            var emp = db.TableStar1091613.Where(m => m.StrId == SCId).FirstOrDefault();
            db.TableStar1091613.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Star", new { scid = emp.SCId });
        }

        //-------------------------------系統內部增加類別用--------------------------------
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TableSClass1091613 people)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Error = false;
                var temp = db.TableSClass1091613
                    .Where(m => m.SCId == people.SCId)
                    .FirstOrDefault();
                if (temp != null)
                {
                    ViewBag.Error = true;
                    return View(people);
                }
                db.TableSClass1091613.Add(people);
                db.SaveChanges();
                return RedirectToAction("Star");
            }
            return View(people);
        }

        //-------------------------------推劇--------------------------------

        public ActionResult Drama(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var people = db.TableDrama1091613.OrderBy(m => m.DId).ToList();
            var result = people.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult DramaCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DramaCreate(TableDrama1091613 people)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Error = false;
                var temp = db.TableDrama1091613
                    .Where(m => m.DId == people.DId)
                    .FirstOrDefault();
                if (temp != null)
                {
                    ViewBag.Error = true;
                    return View(people);
                }
                db.TableDrama1091613.Add(people);
                db.SaveChanges();
                return RedirectToAction("Drama");
            }
            return View(people);
        }

        public ActionResult DramaEdit(int DId)
        {
            var people = db.TableDrama1091613
                .Where(m => m.DId == DId).FirstOrDefault();
            return View(people);
        }

        [HttpPost]
        public ActionResult DramaEdit(TableDrama1091613 people)
        {
            if (ModelState.IsValid)
            {
                var temp = db.TableDrama1091613
                    .Where(m => m.DId == people.DId)
                    .FirstOrDefault();
                temp.DClass = people.DClass;
                temp.DName = people.DName;
                db.SaveChanges();
                return RedirectToAction("Drama");
            }
            return View(people);
        }

        public ActionResult DramaDelete(int DId)
        {
            var people = db.TableDrama1091613
                .Where(m => m.DId == DId).FirstOrDefault();
            db.TableDrama1091613.Remove(people);
            db.SaveChanges();
            return RedirectToAction("Drama");
        }

        //------------------------登入----------------------------------------

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string UId, string Pwd)
        {
            var member = db.TableAccount1091613
                .Where(m => m.Account == UId && m.Password == Pwd)
                .FirstOrDefault();
            if(member == null)
            {
                ViewBag.Message = "帳密錯誤，登入失敗";
                return View();
            }
            Session["Welcome"] = "會員 " + member.Account + " 您好" ;

            FormsAuthentication.RedirectFromLoginPage(UId, true);
            return RedirectToAction("IndexIn", member);
        }

        //--------------------註冊-----------------------------

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(TableAccount1091613 pmember)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }
            var member = db.TableAccount1091613
                .Where(m => m.Account == pmember.Account)
                .FirstOrDefault();
            if(member == null)
            {
                db.TableAccount1091613.Add(pmember);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            ViewBag.Message = "此帳號以有人使用，註冊失敗";
            return View();
        }

        //-------------------登出-----------------------
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }

    }
}