﻿using Sy.Business.Repository;
using Sy.Core.ComplexTypes;
using Sy.Core.Entities;
using Sy.Core.Enums;
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
            grpbxBtn.Visible = true;
            lblGirisBilgi.Visible = false;
            menuStrip1.Visible = false;
            
    }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //form 1 deki group bax ve label içindekielrin gorunur olma durumları
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (StockSettings.UserInfo ==null)
            {
                grpbxBtn.Visible = true;
                lblGirisBilgi.Visible = false;
            }
            else
            {
                grpbxBtn.Visible = false;
                lblGirisBilgi.Visible = true;
                lblGirisBilgi.Text = StockSettings.UserInfo.Display;
                menuStrip1.Visible = true;
                if (StockSettings.UserInfo.ApplicationRole == ApplicationRole.customer)
                {
                    ürünlerToolStripMenuItem.Visible = false;
                    müşterilerToolStripMenuItem.Visible = false;
                    
                }
               

            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm frmp = new ProductForm();
            frmp.Show();
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm frmO = new OrderForm();
            frmO.Show();
        }
    }
}
