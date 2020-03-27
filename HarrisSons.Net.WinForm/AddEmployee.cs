using Bogus;
using HarrisSons.Net.Data;
using HarrisSons.Net.Data.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HarrisSons.Net.WinForm
{
    public partial class AddEmployee : Form
    {
        private HarrisSonsDbContext _context = new HarrisSonsDbContext();
        private readonly IEnumerable<Position> _positions;
        private readonly IEnumerable<Department> _departments;

        public AddEmployee()
        {
            _positions = _context.Positions.OrderBy(i => i.PositionID);
            _departments = _context.Departments.OrderBy(i => i.DepartmentID);
            InitializeComponent();
            InitializeDropDownList();
        }

        private void InitializeDropDownList()
        {
            var positions = _positions.Select(i => i.Name).ToArray();
            var departments = _departments.Select(i => i.Name).ToArray();
            tbPosition.Items.AddRange(positions);
            tbPosition.AutoCompleteCustomSource.AddRange(positions);
            tbDepartment.Items.AddRange(departments);
            tbDepartment.AutoCompleteCustomSource.AddRange(departments);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var faker = new Faker("en");
            var isValid = ValidateInput();
            if (isValid)
            {
                try
                {
                    Address address = new Address
                    {
                        AddressLine1 = tbAddressLine1.Text,
                        AddressLine2 = tbAddressLine2.Text,
                        City = tbCity.Text,
                        State = tbState.Text,
                        Country = tbCountry.Text,
                        PostalCode = tbPostalCode.Text
                    };
                    _context.Addresses.Add(address);
                    _context.SaveChanges();
                    int addressID = _context.Addresses.Select(i => i.AddressID).Max();

                    BusinessContact contact = new BusinessContact
                    {
                        EmailAddress = tbEmail.Text,
                        Telephone = tbTelephone.Text,
                        BusinessTelephone = tbBusinessTelephone.Text,
                        AddressID = addressID
                    };
                    _context.BusinessContacts.Add(contact);
                    _context.SaveChanges();
                    int contactID = _context.PersonalContacts.Select(i => i.PersonalContactID).Max();

                    Employee employee = new Employee()
                    {
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        BirthDate = tbBirthDate.Value,
                        NationalInsuranceNumber = faker.Internet.Mac(),
                        HireDate = DateTime.Now,
                        PositionID = _positions.FirstOrDefault(i => i.Name == tbPosition.Text).PositionID,
                        BusinessContactID = contactID
                    };
                    _context.Employees.Add(employee);
                    _context.SaveChanges();
                    MessageBox.Show("New Employee Added!", "New Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields.", "New Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPosition_SelectedValueChanged(object sender, EventArgs e)
        {
            var departmentID = _positions.FirstOrDefault(i => i.Name == tbPosition.SelectedItem.ToString()).DepartmentID;
            var department = _departments.FirstOrDefault(i => i.DepartmentID == departmentID).Name;
            tbDepartment.Text = department;
        }

        private bool ValidateInput()
        {
            if (tbFirstName.Text.Length == 0 ||
                tbLastName.Text.Length == 0 ||
                tbBirthDate.Value == null ||
                tbEmail.Text.Length == 0 ||
                tbPosition.Text.Length == 0 ||
                tbDepartment.Text.Length == 0 ||
                tbTelephone.Text.Length == 0 ||
                tbBusinessTelephone.Text.Length == 0 ||
                tbCity.Text.Length == 0 ||
                tbState.Text.Length == 0 ||
                tbCountry.Text.Length == 0 ||
                tbPostalCode.Text.Length == 0
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
