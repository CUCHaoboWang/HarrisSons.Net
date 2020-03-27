using HarrisSons.Net.Data;
using HarrisSons.Net.Data.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HarrisSons.Net.WinForm
{
    public partial class EditEmployee : Form
    {
        private HarrisSonsDbContext _context = new HarrisSonsDbContext();
        private readonly IEnumerable<Position> _positions;
        private readonly IEnumerable<Department> _departments;
        private readonly int _employeeID;
        private vwBusinessContactDetail _data;


        public EditEmployee(int id)
        {
            _positions = _context.Positions.OrderBy(i => i.PositionID);
            _departments = _context.Departments.OrderBy(i => i.DepartmentID);
            _employeeID = id;
            _data = _context.vwBusinessContactDetails.Find(_employeeID);
            InitializeComponent();
            InitializeDropDownList();
            InitializeFields();
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

        private void InitializeFields()
        {
            tbFirstName.Text = _data.FirstName;
            tbLastName.Text = _data.LastName;
            tbBirthDate.Value = _data.BirthDate;
            tbEmail.Text = _data.EmailAddress;
            tbPosition.Text = _data.Position;
            tbDepartment.Text = _data.Department;
            tbTelephone.Text = _data.Telephone;
            tbBusinessTelephone.Text = _data.BusinessTelephone;
            tbAddressLine1.Text = _data.AddressLine1;
            tbAddressLine2.Text = _data.AddressLine2;
            tbCity.Text = _data.City;
            tbState.Text = _data.State;
            tbCountry.Text = _data.Country;
            tbPostalCode.Text = _data.PostalCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var isValid = ValidateInput();
            if (isValid)
            {
                try
                {
                    Employee employee = _context.Employees.Find(_employeeID);
                    employee.FirstName = tbFirstName.Text;
                    employee.LastName = tbLastName.Text;
                    employee.BirthDate = tbBirthDate.Value;
                    employee.PositionID = _positions.FirstOrDefault(i => i.Name == tbPosition.Text).PositionID;
                    _context.Employees.Update(employee);

                    BusinessContact contact = _context.BusinessContacts.Find(employee.BusinessContactID);
                    contact.EmailAddress = tbEmail.Text;
                    contact.Telephone = tbTelephone.Text;
                    contact.BusinessTelephone = tbBusinessTelephone.Text;
                    _context.BusinessContacts.Update(contact);

                    Address address = _context.Addresses.Find(contact.AddressID);
                    address.AddressLine1 = tbAddressLine1.Text;
                    address.AddressLine2 = tbAddressLine2.Text;
                    address.City = tbCity.Text;
                    address.State = tbState.Text;
                    address.Country = tbCountry.Text;
                    address.PostalCode = tbPostalCode.Text;
                    _context.Addresses.Update(address);
                    _context.SaveChanges();
                    MessageBox.Show("Employee Updated!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
