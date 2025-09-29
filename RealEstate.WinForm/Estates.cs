using RealEstate.Application.Dtos.EstateDtos;
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
    public partial class Estates : Form
    {
        private readonly IEstateRepository _estateRepository;
        private readonly IAppUserRepository _appUserRepository;
        private readonly ICustomerRepository _customerRepository;
        public Estates(IEstateRepository estateRepository, IAppUserRepository appUserRepository, ICustomerRepository customerRepository)
        {
            InitializeComponent();
            _estateRepository = estateRepository;
            _appUserRepository = appUserRepository;
            _customerRepository = customerRepository;
        }
        DataTable _estateTable;
        private async void Estates_Load(object sender, EventArgs e)
        {
            var user = await _appUserRepository.GetExistingUser();
            var estates = await _estateRepository.GetMyEstates(user.AppUserId);
            //_estates = new BindingList<EstateDto>(estates);

            _estateTable = new DataTable();
            _estateTable.Columns.Add("Emlak Adı", typeof(string));
            _estateTable.Columns.Add("Fiyat", typeof(decimal));
            _estateTable.Columns.Add("Müşteri Adı", typeof(string));
            _estateTable.Columns.Add("Durum", typeof(string));
            _estateTable.Columns.Add("Emlak Id", typeof(Guid));

            foreach (var estate in estates)
            {
                _estateTable.Rows.Add(estate.EstateName, estate.Price, estate.CustomerName, estate.Status,estate.EstateId);
            }

            estateDataGridView.DataSource = _estateTable;
            estateDataGridView.Columns["Emlak Id"].Visible = false;
            //ComboBox Doldurma Kodları
            var customers = await _customerRepository.GetMyCustomers(user.AppUserId);

            comboBoxCustomers.DataSource = customers;

            comboBoxCustomers.DisplayMember = "CustomerName";
            comboBoxCustomers.ValueMember = "CustomerID";

        }

        private async void btnCreateEstate_Click(object sender, EventArgs e)
        {
            var user = await _appUserRepository.GetExistingUser();

            CreateEstateDto estateDto = new CreateEstateDto()
            {
                AppUserId = user.AppUserId,
                CustomerId = (Guid)comboBoxCustomers.SelectedValue,
                EstateName = txtEstateName.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };

            var createdEstate = await _estateRepository.CreateEstate(estateDto);

            _estateTable.Rows.Add(createdEstate.EstateName, createdEstate.Price, comboBoxCustomers.Text, createdEstate.Status,createdEstate.EstateId);

            txtEstateName.Clear();
            txtPrice.Clear();
        }

        private async void btnDeleteEstate_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = estateDataGridView.SelectedRows[0].DataBoundItem as DataRowView;

            Guid estateId = (Guid)dataRowView["Emlak Id"];
            await _estateRepository.RemoveEstate(estateId);

            dataRowView.Delete();
        }
    }
}