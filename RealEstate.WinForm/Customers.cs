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
            _customersTable.Columns.Add("Müşterinin Cinsiyeti",typeof(string));
            _customersTable.Columns.Add("Müşteri Numarası",typeof(string));



            foreach (var customer in customers)
            {
                customerCount++;
                _customersTable.Rows.Add(customerCount,customer.CustomerID, customer.CustomerName, customer.CustomerSurname,customer.Gender,customer.PhoneNumber);
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
                Gender= comboBoxGender.SelectedItem.ToString(),
                PhoneNumber=txtPhoneNumber.Text

            };
            var createdCustomer=await _customerRepository.AddCustomer(customer);
            
            _customersTable.Rows.Add(customerCount,createdCustomer.CustomerId,createdCustomer.CustomerName, createdCustomer.CustomerSurname,createdCustomer.Gender,createdCustomer.PhoneNumber);

            addCustomerNameTextBox.Clear();
            addCustomerSurnameTextBox.Clear();

        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
           DataRowView rowView = customersDataGrid.SelectedRows[0].DataBoundItem as DataRowView;

            Guid customerId=(Guid)rowView["Müşteri Id"];

            await _customerRepository.DeleteCustomer(customerId);

            rowView.Delete();
        }
    }
}
