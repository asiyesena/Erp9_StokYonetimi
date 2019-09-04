using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private readonly IRepository<Client, int> _clientRepository;
        public LoginForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // modeli olusturduk
            var model = new RegisterViewModel()
            {
                Email =txtMailGiris.Text,
                Password = txtSifreGiris.Text
            };
            // email var mı kontrol edelim 
            var kontrol = _clientRepository
                .Query(predicate: x => x.Email == model.Email).Any();
            if (kontrol)
            {
                MessageBox.Show(/*Text :*/"Bu Email adresi kullanılmaktadır.");
                return;
            }
        }
    }
}
