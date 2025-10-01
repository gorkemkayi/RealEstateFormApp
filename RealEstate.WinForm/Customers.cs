using RealEstate.Application.Dtos.CustomerDtos;
using RealEstate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstate.WinForm.Functions;

namespace RealEstate.WinForm
{
    public partial class Customers : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAppUserRepository _appUserRepository;
        public Customers(ICustomerRepository customerRepository, IAppUserRepository appUserRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _appUserRepository = appUserRepository;
        }

        private DataTable _customersTable;
        private int customerCount = 0;
        private async void Customers_Load(object sender, EventArgs e)
        {
            var user = await _appUserRepository.GetExistingUser();
            var customers = await _customerRepository.GetMyCustomers(user.AppUserId);
            _customersTable = new DataTable();
            _customersTable.Columns.Add("#", typeof(int));
            _customersTable.Columns.Add("Müşteri Id", typeof(Guid));
            _customersTable.Columns.Add("Müşteri Adı", typeof(string));
            _customersTable.Columns.Add("Müşteri Soyadı", typeof(string));
            _customersTable.Columns.Add("Müşterinin Cinsiyeti", typeof(string));
            _customersTable.Columns.Add("Müşteri Numarası", typeof(string));



            foreach (var customer in customers)
            {
                customerCount++;
                _customersTable.Rows.Add(customerCount, customer.CustomerID, customer.CustomerName, customer.CustomerSurname, customer.Gender, customer.PhoneNumber);
            }
            customersDataGrid.DataSource = _customersTable;
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            customerCount++;
            var appUser = await _appUserRepository.GetExistingUser();
            var customer = new AddCustomerDto
            {
                CustomerName = addCustomerNameTextBox.Text,
                CustomerSurname = addCustomerSurnameTextBox.Text,
                AppUserId = appUser.AppUserId,
                Gender = comboBoxGender.SelectedItem.ToString(),
                PhoneNumber = txtPhoneNumber.Text

            };
            var createdCustomer = await _customerRepository.AddCustomer(customer);

            _customersTable.Rows.Add(customerCount, createdCustomer.CustomerId, createdCustomer.CustomerName, createdCustomer.CustomerSurname, createdCustomer.Gender, createdCustomer.PhoneNumber);

            addCustomerNameTextBox.Clear();
            addCustomerSurnameTextBox.Clear();

        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DataRowView rowView = customersDataGrid.SelectedRows[0].DataBoundItem as DataRowView;

            Guid customerId = (Guid)rowView["Müşteri Id"];

            await _customerRepository.DeleteCustomer(customerId);

            rowView.Delete();
        }

        private Guid _selectedCustomerId;
        private async void customersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (customersDataGrid.SelectedRows.Count > 0)
            {
                _selectedCustomerId = (Guid)customersDataGrid.SelectedRows[0].Cells[1].Value;
                var customer = await _customerRepository.GetCustomerById(_selectedCustomerId);

                txtCustomerNote.Text = customer.Note;
            }
        }

        private async void btnUpdateNote_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId != Guid.Empty)
            {
                await _customerRepository.UpdateCustomer(new UpdateCustomerNoteDto
                {
                    CustomerId = _selectedCustomerId,
                    Note = txtCustomerNote.Text
                });
                var updatedCustomer = await _customerRepository.GetCustomerById(_selectedCustomerId);
                txtCustomerNote.Text = updatedCustomer.Note;
                MessageBox.Show("Müşteri Notu Güncellendi.");
            }
            else
            {
                btnUpdateNote.Enabled = false;
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_customersTable != null)
            {
                DataView dv = _customersTable.DefaultView;

                dv.RowFilter = string.Format("[Müşteri Adı] LIKE '%{0}%' OR [Müşteri Soyadı] LIKE '%{0}%'", txtCustomerSearch.Text.Replace("'", "''"));

                customersDataGrid.DataSource = dv;
            }
        }

        private void txtCustomerSearch_Enter(object sender, EventArgs e)
        {
            txtCustomerSearch.Text = "";
        }

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd=new SaveFileDialog())
            {
                sfd.Filter = "PDF dosyası|*.pdf";
                sfd.FileName = "MüşteriListesi.pdf";

                if (sfd.ShowDialog()==DialogResult.OK)
                {
                    MyFunctions myFunctions = new MyFunctions();
                    myFunctions.CustomersExportToPdf(_customersTable, sfd.FileName);

                    MessageBox.Show("PDF başarıyla oluşturuldu!");
                }
            }
        }
    }
}
