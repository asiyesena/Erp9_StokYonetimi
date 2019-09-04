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




namespace Sy.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IRepository<Product,Guid> _productRepo;
        public ProductForm()
        {
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();
            ListeyiDoldur();

        }

        private void ListeyiDoldur(string search = " ")
        {

            var data = _productRepo.Query(predicate: x => x.ProductName.Contains(search)).Select(x => new ProductViewModel()
            {
                Id = x.Id,
                UnitPrice = x.UnitPrice,
                CritickStock = x.CritickStock,
                ProductName = x.ProductName
            }).ToList();
            listUrunler.DataSource = data;
            listUrunler.DisplayMember = "Display";

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _productRepo.Insert(new Product()
                {
                    ProductName = txtAd.Text,
                    UnitPrice = nFiyat.Value,
                    CritickStock = Convert.ToInt32(nStok.Value)


                });
                MessageBox.Show("Ürün ekleme işlemi başarılı.");
                ListeyiDoldur();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            ListeyiDoldur(txtAra.Text);
            //listeyi doldur metodunun altında yaptıklarımıza ek burada cagırmamız gerekiyor search işlemini yapabilmemiz için
        }
    }
}
