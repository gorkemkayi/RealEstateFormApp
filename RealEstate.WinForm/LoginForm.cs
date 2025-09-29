using RealEstate.Application.Dtos.AppUserDtos;
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
    public partial class LoginForm : Form
    {
        private readonly IAppUserRepository _repository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IEstateRepository _estateRepository;
        public LoginForm(IAppUserRepository repository, ICustomerRepository customerRepository, IEstateRepository estateRepository)
        {
            InitializeComponent();
            _repository = repository;
            _customerRepository = customerRepository;
            _estateRepository = estateRepository;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var loginUser = new LoginUserDto
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text
            };
            try
            {
                await _repository.LoginUser(loginUser);
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                var mainPage = new MainPage(_customerRepository, _repository, _estateRepository);
                mainPage.Show();
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var form1 = new Form1(_repository))
            {
                form1.ShowDialog();
            }
        }

       
    }
}
