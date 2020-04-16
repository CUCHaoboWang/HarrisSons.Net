using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HarrisSons.Net.Data;
using HarrisSons.Net.Data.Tools;

namespace HarrisSons.Net.Web.Controllers
{
    public class BusinessContactController : Controller
    {
        private readonly HarrisSonsDbContext _context;

        public BusinessContactController(HarrisSonsDbContext context)
        {
            _context = context;
        }

        // GET: BusinessContact
        public async Task<IActionResult> Index()
        {
            return View(await _context.vwBusinessContactDetails.ToListAsync());
        }

        // GET: BusinessContact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vwBusinessContactDetail = await _context.vwBusinessContactDetails
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (vwBusinessContactDetail == null)
            {
                return NotFound();
            }

            return View(vwBusinessContactDetail);
        }

        // GET: BusinessContact/Create
        public IActionResult Create()
        {
            ViewData["Position"] = new SelectList(_context.Positions, "Name", "Name");
            return View();
        }

        // POST: BusinessContact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeID,FirstName,LastName,BirthDate,Position,EmailAddress,Telephone,BusinessTelephone,AddressLine1,AddressLine2,City,State,Country,PostalCode")] vwBusinessContactDetail vwBusinessContactDetail)
        {
            if (ModelState.IsValid)
            {
                var model = vwBusinessContactDetail;
                var vwPosition = _context.vwPositions.FirstOrDefault(i => i.Position == model.Position);
                int positionID = vwPosition.PositionID;
                int departmentID = vwPosition.DepartmentID;

                Address address = new Address
                {
                    AddressLine1 = model.AddressLine1,
                    AddressLine2 = model.AddressLine2,
                    City = model.City,
                    State = model.State,
                    Country = model.Country,
                    PostalCode = model.PostalCode
                };
                _context.Addresses.Add(address);
                _context.SaveChanges();
                int addressID = _context.Addresses.Select(i => i.AddressID).Max();

                BusinessContact contact = new BusinessContact
                {
                    EmailAddress = model.EmailAddress,
                    Telephone = model.Telephone,
                    BusinessTelephone = model.BusinessTelephone,
                    AddressID = addressID
                };
                _context.BusinessContacts.Add(contact);
                _context.SaveChanges();
                int contactID = _context.BusinessContacts.Select(i => i.BusinessContactID).Max();

                Employee employee = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = model.BirthDate,
                    NationalInsuranceNumber = "c6:8a:24:1f:f7:25",
                    HireDate = DateTime.Now,
                    PositionID = positionID,
                    BusinessContactID = contactID
                };
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewData["Position"] = new SelectList(_context.Positions, "Name", "Name", vwBusinessContactDetail.Position);
            return View(vwBusinessContactDetail);
        }

        // GET: BusinessContact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vwBusinessContactDetail = await _context.vwBusinessContactDetails.FindAsync(id);
            if (vwBusinessContactDetail == null)
            {
                return NotFound();
            }

            ViewData["Position"] = new SelectList(_context.Positions, "Name", "Name", vwBusinessContactDetail.Position);
            return View(vwBusinessContactDetail);
        }

        // POST: BusinessContact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeID,FirstName,LastName,BirthDate,Position,EmailAddress,Telephone,BusinessTelephone,AddressLine1,AddressLine2,City,State,Country,PostalCode")] vwBusinessContactDetail vwBusinessContactDetail)
        {
            if (id != vwBusinessContactDetail.EmployeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var model = vwBusinessContactDetail;

                try
                {
                    var vwPosition = _context.vwPositions.FirstOrDefault(i => i.Position == model.Position);
                    int positionID = vwPosition.PositionID;
                    int departmentID = vwPosition.DepartmentID;

                    Employee employee = _context.Employees.Find(id);
                    employee.FirstName = model.FirstName;
                    employee.LastName = model.LastName;
                    employee.BirthDate = model.BirthDate;
                    employee.PositionID = positionID;
                    _context.Employees.Update(employee);

                    BusinessContact contact = _context.BusinessContacts.Find(employee.BusinessContactID);
                    contact.EmailAddress = model.EmailAddress;
                    contact.Telephone = model.Telephone;
                    contact.BusinessTelephone = model.BusinessTelephone;
                    _context.BusinessContacts.Update(contact);

                    Address address = _context.Addresses.Find(contact.AddressID);
                    address.AddressLine1 = model.AddressLine1;
                    address.AddressLine2 = model.AddressLine2;
                    address.City = model.City;
                    address.State = model.State;
                    address.Country = model.Country;
                    address.PostalCode = model.PostalCode;
                    _context.Addresses.Update(address);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!vwBusinessContactDetailExists(vwBusinessContactDetail.EmployeeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["Position"] = new SelectList(_context.Positions, "Name", "Name", vwBusinessContactDetail.Position);
            return View(vwBusinessContactDetail);
        }

        // GET: BusinessContact/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vwBusinessContactDetail = await _context.vwBusinessContactDetails
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (vwBusinessContactDetail == null)
            {
                return NotFound();
            }

            return View(vwBusinessContactDetail);
        }

        // POST: BusinessContact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var address = _context.Employees.Where(i => i.EmployeeID == id)
                .Include(i => i.BusinessContact)
                .ThenInclude(i => i.Address)
                .Select(i => i.BusinessContact.Address).FirstOrDefault();
            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool vwBusinessContactDetailExists(int id)
        {
            return _context.vwBusinessContactDetails.Any(e => e.EmployeeID == id);
        }
    }
}
