using Sy.Business.Repository;
using Sy.Core.Entities;
using Sy.Core.Enums;
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
    public partial class OrderForm : Form
    {
        private readonly Repository<Product, Guid> _productRepo;
        private readonly Repository<ProductStockAction, long> _productActionRepo;
        public OrderForm()
        {
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();
            _productActionRepo = new Repository<ProductStockAction,long>();
            ListeyiDoldur();
        }
        private void ListeyiDoldur(string search = "")
        {

            var data = _productRepo.Query(predicate: x => x.ProductName.Contains(search)).Select(x => new ProductViewModel()
            {
                Id = x.Id,
                UnitPrice = x.UnitPrice,
                CritickStock = x.CritickStock,
                ProductName = x.ProductName,
                /* UnitsInStock = x.ProductStockAction.Where(y=>y.StockActionType == StockActionType.Incoming).Sum(y=>y.Quantity) - x.ProductStockAction.Where(y => y.StockActionType == StockActionType.OutGoing).Sum(y => y.Quantity)
             }).ToList();
             lstUrunler.DataSource = data;
             lstUrunler.DisplayMember = "Display";
             */
            }).ToList();

            foreach (var item in data)
            {
                var actionList = _productActionRepo.Query(x => x.ProductId == item.Id).ToList();
                if (!actionList.Any()) continue;

                var girenAdet = actionList.Where(x => x.StockActionType == StockActionType.Incoming)
                    .Sum(x => x.Quantity);
                var cikanAdet = actionList.Where(x => x.StockActionType == StockActionType.OutGoing)
                    .Sum(x => x.Quantity);
                item.UnitsInStock = girenAdet - cikanAdet;
            }
            lstUrunler.DataSource = data;
            lstUrunler.DisplayMember = "Display";
        }
        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            ListeyiDoldur(txtArama.Text);
        }
        private ProductViewModel seciliUrun;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            seciliUrun = lstUrunler.SelectedItem as ProductViewModel;
            lblUrunAdi.Text = seciliUrun.ProductName;
            LblStokMiktari.Text = seciliUrun.UnitsInStock.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _productActionRepo.Insert(new ProductStockAction()
                {
                    ProductId = seciliUrun.Id,
                    Quantity = Convert.ToInt32(nEklencekMik.Value),
                    UnitPrice = nAlis.Value,
                    StockActionType = StockActionType.Incoming



                });
                MessageBox.Show("stok ekleme işlemi başarılı.");
                ListeyiDoldur();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
