
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
using System.Windows.Forms.DataVisualization.Charting;

namespace RealEstate.WinForm
{
    public partial class MainPage : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IEstateRepository _estateRepository;
        public MainPage(ICustomerRepository customerRepository, IAppUserRepository appUserRepository, IEstateRepository estateRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _appUserRepository = appUserRepository;
            _estateRepository = estateRepository;
        }


        private void müşterilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var customerForm = new Customers(_customerRepository, _appUserRepository))
            {
                customerForm.ShowDialog();
            }
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void emaklarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var estateForm = new Estates(_estateRepository, _appUserRepository, _customerRepository))
            {
                estateForm.ShowDialog();
            }
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {
            var user = await _appUserRepository.GetExistingUser();
            txtUsername.Text=user.Username;
            txtName.Text= user.Name;
            txtSurname.Text = user.Surname;


            #region Estate'ler için Pie Chart
            var estates = await _estateRepository.GetMyEstates(user.AppUserId);
            
            var activeEstatesCount=estates.Count(e => e.Status == "İlanda");
            var rentedEstatesCount=estates.Count(e => e.Status == "Kiralandı");
            var selledEstatesCount=estates.Count(e => e.Status == "Satıldı");


            pieCharEstates.Series.Clear();
            pieCharEstates.Titles.Clear();

            var series = pieCharEstates.Series.Add("Estates");
            series.ChartType = SeriesChartType.Pie;
            series.Points.AddXY("İlanda", activeEstatesCount);
            series.Points.AddXY("Kiralandı", rentedEstatesCount);
            series.Points.AddXY("Satıldı", selledEstatesCount);

            series.LegendText= "#VALX (#PERCENT{P0})";
            #endregion

            #region Müşteriler için Pie Chart
            var customers = await _customerRepository.GetMyCustomers(user.AppUserId);
            var maleCustomersCount=customers.Count(g=>g.Gender== "Erkek");
            var femaleCustomerCount=customers.Count(g=>g.Gender== "Kadın");

            pieChartCustomers.Series.Clear();
            pieChartCustomers.Titles.Clear();

            var customerSeries = pieChartCustomers.Series.Add("Customers");
            customerSeries.ChartType = SeriesChartType.Pie;
            customerSeries.Points.AddXY("Erkek", maleCustomersCount);
            customerSeries.Points.AddXY("Kadın", femaleCustomerCount);

            customerSeries.LegendText = "#VALX (#PERCENT{P0})";
            #endregion

            #region Genel İstatistikler
            lblEstateCount.Text = estates.Count.ToString();
            lblCustomerCount.Text = customers.Count.ToString();
            lblActiveEstateCount.Text = activeEstatesCount.ToString();
            lblRentedEstateCount.Text = rentedEstatesCount.ToString();
            lblSelledEstates.Text = selledEstatesCount.ToString();
            #endregion


        }


    }
}
