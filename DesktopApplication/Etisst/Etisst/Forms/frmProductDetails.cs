using Etisst.Desktop.BusinessLogic.UIConnector;
using Etisst.Desktop.Common;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmProductDetails : frmBaseForm , IProductDetailsView
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

        public List<ProductCategory> ProductCategories
        {
            set
            {
                if(value!=null)
                {
                    foreach(ProductCategory productCategory in value)
                    {
                        cblCategories.Items.Add((object)productCategory.name);
                    }

                    foreach (ProductCategoryLine categoryLine in _product.categories)
                    {
                        var index = cblCategories.Items.IndexOf((object)categoryLine.name);
                        cblCategories.SetItemChecked(index, true);
                    }
                }
            }
        }

        public List<ProductTag> ProductTags
        {
            set
            {
                if (value != null)
                {
                    foreach (ProductTag productTag in value)
                    {
                        cblTags.Items.Add((object)productTag.name);
                    }

                    foreach (ProductTagLine categoryTag in _product.tags)
                    {
                        var index = cblTags.Items.IndexOf((object)categoryTag.name);
                        cblTags.SetItemChecked(index, true);
                    }
                }
            }
        }

        private Product _product;
        public Product Product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
                if (_product.images.Count > 0)
                {
                    if (_product.images[0] != null)
                        pictureBox1.LoadAsync(_product.images[0].src);
                    if (_product.images[1] != null)
                        pictureBox2.LoadAsync(_product.images[1].src);
                    if (_product.images[2] != null)
                        pictureBox3.LoadAsync(_product.images[2].src);
                }
                mtbName.Text = _product.name;
                rtbShortDescriptionHTML.Text = _product.short_description;
                mtbSKU.Text = _product.sku;
                //_product.regular_price;
                //_product.sale_price;
                mtbStatus.Text = _product.status;
                mtbURL.Text = _product.permalink;
                rtbDescriptionHTML.Text = _product.description;
                mdtDateCreated.Value = _product.date_created ?? DateTime.Now;
                mdtDateModified.Value = _product.date_modified ?? DateTime.Now;
                wbShortDescription.DocumentText = string.Format("{0}{1}", AppTranslations.PRODUCT_SHORT_DESCRIPTION , _product.short_description);
                wbDescription.DocumentText = string.Format("{0}{1}", AppTranslations.PRODUCT_DESCRIPTION , _product.description);
                nActualPrice.Value = _product.price ?? 0;
                
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(_product.price_html);

                var initialPrice = doc.DocumentNode.SelectNodes("//span[@class='woocommerce-Price-amount amount']")//this xpath selects all span tag having its class as hidden first
                                  .Select(p => p.InnerText)
                                  .ToList();
                initialPrice[0] = initialPrice[0].Substring(0, initialPrice[0].IndexOf('&'));
                initialPrice[0] = initialPrice[0].Replace(',', '.');
                nInitialPrice.Value = decimal.Parse(initialPrice[0]);
                mtbShippingClass.Text = _product.shipping_class;
                mtbDimensions.Text = string.Format("{0} x {1} x {2}", _product.dimensions.height, _product.dimensions.width, _product.dimensions.width);

               
            }
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

        private void btnAttributesPanel_Click(object sender, EventArgs e)
        {
            this.SetHeight(ref panelAttributes);
        }

        private async void frmProductDetails_LoadAsync(object sender, EventArgs e)
        {
            await _presenter.InitAsync();
        }
        #endregion

        #region Private Methods
        private bool SetHeight(ref System.Windows.Forms.Panel panel, int height=500)
        {
            if (panel.Height == btnGeneralPanel.Height)
            {
                InitializePanelsHeight();
                while (panel.Height < height)
                {
                    panel.Height += 4;
                }
                return true;
            }
            else
            {
                panel.Height = btnGeneralPanel.Height;
                return false;
            }
        }
        private void InitializePanelsHeight()
        {
            panelGeneral.Height = btnGeneralPanel.Height;
            panelImages.Height = btnGeneralPanel.Height;
            panelAttributes.Height = btnAttributesPanel.Height;
        }

        #endregion
    }
}
