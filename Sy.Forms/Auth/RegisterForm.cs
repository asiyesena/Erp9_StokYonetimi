using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.Enums;
using Sy.Core.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sy.Forms.Auth
{
    public partial class RegisterForm : Form
    {
       // private readonly Repository<Client, int> _clientRepository;
        private readonly IRepository<Client, int> _clientRepository; //polimorfizm

        public RegisterForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            // modeli olusturduk
            var model = new RegisterViewModel()
        {   Email = txtMail.Text,
            Name = txtAd.Text,
            Surname = txtSoyad.Text,
            Password = txtSifre.Text
        };
            // email var mı kontrol edelim 
            var kontrol = _clientRepository
                .Query(predicate: x => x.Email == model.Email).Any();
            if (kontrol)
            {
                MessageBox.Show(/*Text :*/"Bu Email adresi kullanılmaktadır.");
                return;
            }

            //benzersiz email kontrolunden sonra kişiyi kaydedilim
            // base kalıtım  aldıgımız kalıtımı işaret eder.
            var adminMi = !_clientRepository.Query().Any();

            _clientRepository.Insert (new Client()
            {
                Email = model.Email,
                Name = model.Name,
                Surname = model.Surname,
                Password = model.Password,

                ApplicationRole =adminMi ? ApplicationRole.admin : ApplicationRole.customer
                //uygulama rolü müşteri mi yonetici mi
            });
            MessageBox.Show($"Kayıt işleminiz başarılıdır.\n  { model.Name}  { model.Surname}");
            this.Close();
        }
    }
}
