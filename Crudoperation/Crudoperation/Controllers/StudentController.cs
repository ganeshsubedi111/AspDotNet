using Crudoperation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Crudoperation.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _Db;

        public StudentController(StudentContext Db)
        {
            _Db = Db;
        }

        public IActionResult StudentList()
        {
            try
            {
                var stdList = _Db.Students.ToList();
                return View(stdList);
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                return View();
            }
        }

        public IActionResult Create(Student obj)
        {
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStudent(Student obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.Id == 0)
                    {
                        _Db.Students.Add(obj);
                        await _Db.SaveChangesAsync();

                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("StudentList");
                }
                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("StudentList");
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var std = await _Db.Students.FindAsync(id);
                if (std != null)
                {
                    _Db.Students.Remove(std);
                    await _Db.SaveChangesAsync();
                }
                return RedirectToAction("StudentList");

            }
            catch (Exception ex)
            {
                return RedirectToAction("StudentList");
            }
          

            }




        

    }

    }     

    
