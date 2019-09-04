using Sy.Business.Repository;
using Sy.Core.Entities;
using Sy.Forms.Auth;
using System;
using System.Windows.Forms;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        private Repository<Product, Guid> _productRepo;

        //   private Repository<int, Guid> productRepo; //cagtaya sor hata nedenini classlar IEntity tipinde olmalı o nedenle hata veriyor.
        // base classları genelde abstract tanımlarsın cunku ordan kalıtım alınsın istemessin base classlardan muglak olanları abstract tanımla 

        public Form1()
        {
            InitializeComponent();
            _productRepo =new  Repository<Product, Guid> ();
    }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }
    }
}
