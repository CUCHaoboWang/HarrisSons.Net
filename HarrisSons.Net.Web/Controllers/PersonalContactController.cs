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
    public class PersonalContactController : Controller
    {
        private readonly HarrisSonsDbContext _context;

        public PersonalContactController(HarrisSonsDbContext context)
        {
            _context = context;
        }

        // GET: PersonalContact
        public async Task<IActionResult> Index()
        {
            return View(await _context.vwPersonalContactDetails.ToListAsync());
        }

        // GET: PersonalContact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vwPersonalContactDetail = await _context.vwPersonalContactDetails
                .FirstOrDefaultAsync(m => m.ClientID == id);
            if (vwPersonalContactDetail == null)
            {
                return NotFound();
            }

            return View(vwPersonalContactDetail);
        }

        // GET: PersonalContact/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonalContact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientID,FirstName,LastName,BirthDate,EmailAddress,Telephone,HomeTelephone,AddressLine1,AddressLine2,City,State,Country,PostalCode")] vwPersonalContactDetail vwPersonalContactDetail)
        {
            if (ModelState.IsValid)
            {
                var model = vwPersonalContactDetail;

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

                PersonalContact contact = new PersonalContact
                {
                    EmailAddress = model.EmailAddress,
                    Telephone = model.Telephone,
                    HomeTelephone = model.HomeTelephone,
                    AddressID = addressID
                };
                _context.PersonalContacts.Add(contact);
                _context.SaveChanges();
                int contactID = _context.PersonalContacts.Select(i => i.PersonalContactID).Max();

                Client client = new Client()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = model.BirthDate,
                    FirstContactDate = DateTime.Now,
                    LastContactDate = null,
                    PersonalContactID = contactID
                };
                _context.Clients.Add(client);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            return View(vwPersonalContactDetail);
        }

        // GET: PersonalContact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vwPersonalContactDetail = await _context.vwPersonalContactDetails.FindAsync(id);
            if (vwPersonalContactDetail == null)
            {
                return NotFound();
            }
            return View(vwPersonalContactDetail);
        }

        // POST: PersonalContact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientID,FirstName,LastName,BirthDate,EmailAddress,Telephone,HomeTelephone,AddressLine1,AddressLine2,City,State,Country,PostalCode")] vwPersonalContactDetail vwPersonalContactDetail)
        {
            if (id != vwPersonalContactDetail.ClientID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var model = vwPersonalContactDetail;

                try
                {
                    Client client = _context.Clients.Find(id);
                    client.FirstName = model.FirstName;
                    client.LastName = model.LastName;
                    client.BirthDate = model.BirthDate;
                    _context.Clients.Update(client);

                    PersonalContact contact = _context.PersonalContacts.Find(client.PersonalContactID);
                    contact.EmailAddress = model.EmailAddress;
                    contact.Telephone = model.Telephone;
                    contact.HomeTelephone = model.HomeTelephone;
                    _context.PersonalContacts.Update(contact);

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
                    if (!vwPersonalContactDetailExists(vwPersonalContactDetail.ClientID))
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
            return View(vwPersonalContactDetail);
        }

        // GET: PersonalContact/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vwPersonalContactDetail = await _context.vwPersonalContactDetails
                .FirstOrDefaultAsync(m => m.ClientID == id);
            if (vwPersonalContactDetail == null)
            {
                return NotFound();
            }

            return View(vwPersonalContactDetail);
        }

        // POST: PersonalContact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var address = _context.Clients.Where(i => i.ClientID == id)
                .Include(i => i.PersonalContact)
                .ThenInclude(i => i.Address)
                .Select(i => i.PersonalContact.Address).FirstOrDefault();
            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool vwPersonalContactDetailExists(int id)
        {
            return _context.vwPersonalContactDetails.Any(e => e.ClientID == id);
        }
    }
}
