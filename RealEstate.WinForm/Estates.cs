using RealEstate.Application.Dtos.EstateDtos;
using RealEstate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        private List<EstateDto> _estates = new List<EstateDto>();
        private async void Estates_Load(object sender, EventArgs e)
        {
            var user = await _appUserRepository.GetExistingUser();
            _estates = await _estateRepository.GetMyEstates(user.AppUserId);


            _estateTable = new DataTable();
            _estateTable.Columns.Add("Emlak Adı", typeof(string));
            _estateTable.Columns.Add("Fiyat", typeof(decimal));
            _estateTable.Columns.Add("Müşteri Adı", typeof(string));
            _estateTable.Columns.Add("Durum", typeof(string));
            _estateTable.Columns.Add("Emlak Id", typeof(Guid));

            foreach (var estate in _estates)
            {
                _estateTable.Rows.Add(estate.EstateName, estate.Price, estate.CustomerName, estate.Status, estate.EstateId);
            }

            estateDataGridView.DataSource = _estateTable;
            //ComboBox Doldurma Kodları
            var customers = await _customerRepository.GetMyCustomers(user.AppUserId);

            comboBoxCustomers.DataSource = customers;

            comboBoxCustomers.DisplayMember = "CustomerName";
            comboBoxCustomers.ValueMember = "CustomerID";

        }

        private async void btnCreateEstate_Click(object sender, EventArgs e)
        {
            var user = await _appUserRepository.GetExistingUser();

            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EstateImages");
            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }

            List<string> savedImagePaths = new List<string>();

            foreach (var filePath in _selectedImages)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(filePath);
                string destPath = Path.Combine(imagesFolder, fileName);
                File.Copy(filePath, destPath, true);

                savedImagePaths.Add(Path.Combine("EstateImages", fileName));
            }

            CreateEstateDto estateDto = new CreateEstateDto()
            {
                AppUserId = user.AppUserId,
                CustomerId = (Guid)comboBoxCustomers.SelectedValue,
                EstateName = txtEstateName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                ImageUrls = savedImagePaths
            };

            var createdEstate = await _estateRepository.CreateEstate(estateDto);

            _estateTable.Rows.Add(createdEstate.EstateName, createdEstate.Price, comboBoxCustomers.Text, createdEstate.Status, createdEstate.EstateId);

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
        private List<string> _selectedImages = new List<string>();
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImages.AddRange(ofd.FileNames);
                }
            }
        }

        private void estateDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (estateDataGridView.SelectedRows.Count > 0)
            {
                Guid estateId = (Guid)estateDataGridView.SelectedRows[0].Cells[4].Value;
                var estate = _estates.FirstOrDefault(x => x.EstateId == estateId);

                if (estate != null && estate.EstateImages.Any())
                {
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, estate.EstateImages.First().ImageUrl);
                    if (File.Exists(imagePath))
                    {
                        estatePictureBox.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        estatePictureBox.Image = null;
                    }
                }
                else
                {
                    estatePictureBox.Image = null;
                }
            }
        }

        private void txtSearchEstate_TextChanged(object sender, EventArgs e)
        {
            if (_estateTable != null)
            {
                DataView dv = _estateTable.DefaultView;

                dv.RowFilter = string.Format("[Emlak Adı] LIKE '%{0}%'", txtSearchEstate.Text.Replace("'", "''"));

                estateDataGridView.DataSource = dv;
            }
        }

        private void txtSearchEstate_Enter(object sender, EventArgs e)
        {
            txtSearchEstate.Clear();
        }
    }
}