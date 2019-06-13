using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
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

        #endregion

        #region Events
        private void btnGeneralPanel_Click(object sender, EventArgs e)
        {
            this.SetHeight(ref panelGeneral);
        }

        private void btnImagesPanel_Click(object sender, EventArgs e)
        {
            this.SetHeight(ref panelImages);
        }



        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            var a = Product;
        }
        #endregion
        #region Private Methods
        private void SetHeight(ref System.Windows.Forms.Panel panel)
        {
            if (panel.Height == btnGeneralPanel.Height)
            {
                InitializePanelsHeight();
                while (panel.Height < 500)
                {
                    panel.Height += 3;
                }
            }
            else
            {
                panel.Height = btnGeneralPanel.Height;
            }
        }
        private void InitializePanelsHeight()
        {
            panelGeneral.Height = btnGeneralPanel.Height;
            panelImages.Height = btnGeneralPanel.Height;
        }
        #endregion

    }
}
