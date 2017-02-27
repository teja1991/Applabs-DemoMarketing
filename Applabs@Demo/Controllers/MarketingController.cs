using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Applabs_Demo.Models;
using System.Activities.Statements;

namespace Applabs_Demo.Controllers
{
    public class MarketingController : Controller
    {
        private DbContextMarketingProfile db = new DbContextMarketingProfile();

        // GET: Marketing
        public ActionResult Index()
        {
            return View(db.Marketings.ToList());
        }

        // GET: Marketing/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marketing marketing = db.Marketings.Find(id);
            if (marketing == null)
            {
                return HttpNotFound();
            }
            return View(marketing);
        }

        // GET: Marketing/Create
        public ActionResult Create()
        {


            //   new SelectList(db.DepartmentLevels, "DepartmentLevelId", "DepartmentLevelDesc",
            //     departmentlevel.DepartmentLevelId).OrderBy(a => a.Text);

            // this.ViewData["book_id"] = new SelectList(_entities.BookSet.ToList(), "book_id", "Title");
            //  ViewBag.Employee=new SelectList(db.Employees.ToList(), "EmployeeID");
            //var list = new SelectList(Employee, "ID", "Name");
            //ViewBag.Employee = list;

            //var list = new SelectList(Employee, "Id", "Name");
            //ViewBag.countries = list;
            // @Html.DropDownList("countries", ViewBag.Roles as SelectList)

            //ViewBag.employeid = new SelectList(db.Employees, "Id", "First_Name");

            // IEnumerable<SelectListItem> stateList = (from m in _db.mstrstates where m.bstatus == true select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.vstate, Value = m.istateid.ToString() });
            ////  ViewData["Submarkets"] = new SelectList(submarketRep.AllOrdered(), "id", "name");
            //ViewBag.Emp = new  SelectListItem(Employee), "id", "Name");
            //IEnumerable<SelectListItem> Emp1= (from R in db.Employees where R.Is_Internal_Employee == false select R).AsEnumerable().Select(R => new SelectListItem()
            //{
            //    Value = R.First_Name,
            //    Text = R.First_Name,


            //});
            //ViewBag.teja = Emp1;

            IEnumerable<SelectListItem> Emp = (from R in db.Employees where R.Is_Internal_Employee == false select R).AsEnumerable().Select(R => new SelectListItem()
            {
                Value = R.First_Name,
                Text = R.First_Name,
               

            });
            ViewBag.teja = Emp;
            
            IEnumerable<SelectListItem> Marketingemp = (from R in db.Employees where R.Is_Internal_Employee == true select R).AsEnumerable().Select(R => new SelectListItem()
            {
                Value = R.First_Name,
                Text = R.First_Name
            });
            ViewBag.marketingem = Marketingemp;
            // ViewBag Teja = Employees;

            //ViewBag.EmployeId = new SelectList(db.Employees, "Id", "First_Name");
            return View();
           // return View();
        }

        // POST: Marketing/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save([Bind(Include = "Id,Employee_Name,Marketer_name,Start_date,case_status,Close_date")] Marketing marketing)
        {
            if (ModelState.IsValid)
            {
                db.Marketings.Add(marketing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marketing);
        }

        // GET: Marketing/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marketing marketing = db.Marketings.Find(id);
            if (marketing == null)
            {
                return HttpNotFound();
            }
            return View(marketing);
        }

        // POST: Marketing/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Employee_Name,Marketer_name,Start_date,case_status,Close_date")] Marketing marketing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marketing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marketing);
        }

        // GET: Marketing/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marketing marketing = db.Marketings.Find(id);
            if (marketing == null)
            {
                return HttpNotFound();
            }
            return View(marketing);
        }

        // POST: Marketing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Marketing marketing = db.Marketings.Find(id);
            db.Marketings.Remove(marketing);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
