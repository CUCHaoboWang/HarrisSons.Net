using HarrisSons.Net.Data;
using HarrisSons.Net.Data.Tools;
using HarrisSons.Net.WinForm.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HarrisSons.Net.WinForm
{
    public partial class DashBoard : Form
    {
        private HarrisSonsDbContext _context = new HarrisSonsDbContext();
        private int _id;
        private Address _address;
        private IEnumerable<vwPersonalContactDetail> _personalContactDetails;
        private IEnumerable<vwBusinessContactDetail> _businessContactDetails;
        private IEnumerable<vwPersonalContact> _personalContacts;
        private IEnumerable<vwBusinessContact> _businessContacts;

        public DashBoard()
        {
            InitializeComponent();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            if (tabControlContact.SelectedTab.Name == "tabPagePersonalContact")
            {
                _personalContactDetails = _context.vwPersonalContactDetails.OrderBy(i => i.ClientID);
                _personalContacts = _personalContactDetails
                    .Select(i => new vwPersonalContact
                    { 
                        ClientID = i.ClientID,
                        FirstName = i.FirstName,
                        LastName = i.LastName,
                        BirthDate = i.BirthDate,
                        ContactDate = i.ContactDate,
                        EmailAddress = i.EmailAddress,
                        Telephone = i.Telephone,
                        HomeTelephone = i.HomeTelephone
                    });
                dgvContactTable.DataSource = _personalContacts.ToList().ToDataTable();
            }

            if (tabControlContact.SelectedTab.Name == "tabPageBusinessContact")
            {
                _businessContactDetails = _context.vwBusinessContactDetails.OrderBy(i => i.EmployeeID);
                _businessContacts = _businessContactDetails
                    .Select(i => new vwBusinessContact
                    {
                        EmployeeID = i.EmployeeID,
                        FirstName = i.FirstName,
                        LastName = i.LastName,
                        BirthDate = i.BirthDate,
                        HireDate = i.HireDate,
                        Position = i.Position,
                        Department = i.Department,
                        EmailAddress = i.EmailAddress,
                        Telephone = i.Telephone,
                        BusinessTelephone = i.BusinessTelephone
                    });
                dgvContactTable.DataSource = _businessContacts.ToList().ToDataTable();
            }
        }

        private void UpdateAddressPanel()
        {
            richTextBoxAddressLine1.Text = _address.AddressLine1;
            richTextBoxAddressLine2.Text = _address.AddressLine2;
            richTextBoxCity.Text = _address.City;
            richTextBoxState.Text = _address.State;
            richTextBoxCountry.Text = _address.Country;
            richTextBoxPostalCode.Text = _address.PostalCode;
        }

        private void btnBusinessContactAdd_Click(object sender, EventArgs e)
        {
            using (AddEmployee form = new AddEmployee())
            {
                form.ShowDialog();
            }
            UpdateDataGridView();
        }

        private void btnBusinessContactEdit_Click(object sender, EventArgs e)
        {
            using (EditEmployee form = new EditEmployee(_id))
            {
                form.ShowDialog();
            }
            _context = new HarrisSonsDbContext();
            UpdateDataGridView();
        }

        private void btnBusinessContactDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var employeeID = _id;
                var employee = _context.Employees.Find(employeeID);
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                UpdateDataGridView();
            }
        }

        private void btnBusinessContactSearch_Click(object sender, EventArgs e)
        {
            string text = textBoxBusinessContactSearch.Text;
            if (string.IsNullOrEmpty(text))
            {
                UpdateDataGridView();
            }
            else
            {
                dgvContactTable.DataSource = _businessContacts
                    .Where(i => i.FirstName.Contains(text) || i.LastName.Contains(text) || i.EmailAddress.Contains(text) || i.Telephone.Contains(text) || i.BusinessTelephone.Contains(text))
                    .OrderBy(i => i.EmployeeID).ToList().ToDataTable();
            }
        }

        private void btnPersonalContactAdd_Click(object sender, EventArgs e)
        {
            using (AddClient form = new AddClient())
            {
                form.ShowDialog();
            }
            UpdateDataGridView();
        }

        private void btnPersonalContactEdit_Click(object sender, EventArgs e)
        {
            using (EditClient form = new EditClient(_id))
            {
                form.ShowDialog();
            }
            _context = new HarrisSonsDbContext();
            UpdateDataGridView();
        }

        private void btnPersonalContactDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this client?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var clientID = _id;
                var client = _context.Clients.Find(clientID);
                _context.Clients.Remove(client);
                _context.SaveChanges();
                UpdateDataGridView();
            }
        }

        private void btnPersonalContactSearch_Click(object sender, EventArgs e)
        {
            string text = textBoxPersonContactSearch.Text;
            if (string.IsNullOrEmpty(text))
            {
                UpdateDataGridView();
            }
            else
            {
                dgvContactTable.DataSource = _personalContacts
                    .Where(i => i.FirstName.Contains(text) || i.LastName.Contains(text) || i.EmailAddress.Contains(text) || i.Telephone.Contains(text) || i.HomeTelephone.Contains(text))
                    .OrderBy(i => i.ClientID).ToList().ToDataTable();
            }
        }

        private void dgvContactTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContactTable.SelectedRows.Any())
            {
                _id = int.Parse(dgvContactTable.SelectedRows[0].Cells[0].Value.ToString());

                if (tabControlContact.SelectedTab.Name == "tabPagePersonalContact")
                {
                    var contact = _personalContactDetails.FirstOrDefault(i => i.ClientID == _id);
                    _address = new Address
                    {
                        AddressID = 0,
                        AddressLine1 = contact.AddressLine1,
                        AddressLine2 = contact.AddressLine2,
                        City = contact.City,
                        State = contact.State,
                        Country = contact.Country,
                        PostalCode = contact.PostalCode
                    };
                    UpdateAddressPanel();
                }

                if (tabControlContact.SelectedTab.Name == "tabPageBusinessContact")
                {
                    var contact = _businessContactDetails.FirstOrDefault(i => i.EmployeeID == _id);
                    _address = new Address
                    {
                        AddressID = 0,
                        AddressLine1 = contact.AddressLine1,
                        AddressLine2 = contact.AddressLine2,
                        City = contact.City,
                        State = contact.State,
                        Country = contact.Country,
                        PostalCode = contact.PostalCode
                    };
                    UpdateAddressPanel();
                }
            }
        }

        private void tabControlContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
