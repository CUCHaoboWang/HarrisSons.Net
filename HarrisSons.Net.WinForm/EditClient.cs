using HarrisSons.Net.Data;
using HarrisSons.Net.Data.Tools;
using System;
using System.Windows.Forms;

namespace HarrisSons.Net.WinForm
{
    public partial class EditClient : Form
    {
        private HarrisSonsDbContext _context = new HarrisSonsDbContext();
        private readonly int _clientID;
        private vwPersonalContactDetail _data;

        public EditClient(int id)
        {
            _clientID = id;
            _data = _context.vwPersonalContactDetails.Find(_clientID);
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            tbFirstName.Text = _data.FirstName;
            tbLastName.Text = _data.LastName;
            tbBirthDate.Value = _data.BirthDate;
            tbEmail.Text = _data.EmailAddress;
            tbTelephone.Text = _data.Telephone;
            tbHomeTelephone.Text = _data.HomeTelephone;
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
                    Client client = _context.Clients.Find(_clientID);
                    client.FirstName = tbFirstName.Text;
                    client.LastName = tbLastName.Text;
                    client.BirthDate = tbBirthDate.Value;
                    _context.Clients.Update(client);

                    PersonalContact contact = _context.PersonalContacts.Find(client.PersonalContactID);
                    contact.EmailAddress = tbEmail.Text;
                    contact.Telephone = tbTelephone.Text;
                    contact.HomeTelephone = tbHomeTelephone.Text;
                    _context.PersonalContacts.Update(contact);

                    Address address = _context.Addresses.Find(contact.AddressID);
                    address.AddressLine1 = tbAddressLine1.Text;
                    address.AddressLine2 = tbAddressLine2.Text;
                    address.City = tbCity.Text;
                    address.State = tbState.Text;
                    address.Country = tbCountry.Text;
                    address.PostalCode = tbPostalCode.Text;
                    _context.Addresses.Update(address);
                    _context.SaveChanges();
                    MessageBox.Show("Client Updated!", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields.", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateInput()
        {
            if (tbFirstName.Text.Length == 0 ||
                tbLastName.Text.Length == 0 ||
                tbBirthDate.Value == null ||
                tbEmail.Text.Length == 0 ||
                tbTelephone.Text.Length == 0 ||
                tbHomeTelephone.Text.Length == 0 ||
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
