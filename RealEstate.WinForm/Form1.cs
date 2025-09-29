using AutoMapper;
using RealEstate.Application.Dtos.AppUserDtos;
using RealEstate.Application.Interfaces;
using RealEstate.Infrastructure.Context;
using RealEstate.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace RealEstate.WinForm
{
    public partial class Form1 : Form
    {
        private readonly IAppUserRepository _repository;
        public Form1(IAppUserRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            var registerUserDto = new RegisterUserDto
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text
            };

            try
            {
                await _repository.RegisterUser(registerUserDto);
                MessageBox.Show("User registered successfully.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
