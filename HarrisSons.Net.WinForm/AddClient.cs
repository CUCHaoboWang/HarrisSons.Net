using HarrisSons.Net.Data;
using HarrisSons.Net.Data.Tools;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HarrisSons.Net.WinForm
{
    public partial class AddClient : Form
    {
        private HarrisSonsDbContext _context = new HarrisSonsDbContext();

        public AddClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

                    PersonalContact contact = new PersonalContact
                    {
                        EmailAddress = tbEmail.Text,
                        Telephone = tbTelephone.Text,
                        HomeTelephone = tbHomeTelephone.Text,
                        AddressID = addressID
                    };
                    _context.PersonalContacts.Add(contact);
                    _context.SaveChanges();
                    int contactID = _context.PersonalContacts.Select(i => i.PersonalContactID).Max();

                    Client client = new Client()
                    {
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        BirthDate = tbBirthDate.Value,
                        FirstContactDate = DateTime.Now,
                        LastContactDate = null,
                        PersonalContactID = contactID
                    };
                    _context.Clients.Add(client);
                    _context.SaveChanges();
                    MessageBox.Show("New Client Added!", "New Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields.", "New Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
