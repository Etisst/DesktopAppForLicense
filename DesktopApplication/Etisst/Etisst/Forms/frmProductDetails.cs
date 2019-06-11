using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmProductDetails : MetroFramework.Forms.MetroForm , IProductDetailsView
    {


        #region private members
        private ProductDetailsPresenter _presenter;
        #endregion

        #region Constructor
        public frmProductDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region IProductDetailsViewMembers
        public int ProductId { get; set; }
        public Product Product
        {
            get;
            set;
        }

        public void AttachPresenter(ProductDetailsPresenter presenter)
        {
            _presenter = presenter;
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
