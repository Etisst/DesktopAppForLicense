using Etisst.Desktop.BusinessLogic.UIConnector;
using Etisst.Desktop.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmProductCategories : frmBaseForm, IProductCategoriesView
    {
        #region private members
        private ProductCategoriesPresenter _presenter;
        private ProductCategory _selectedProductCategory;
        private List<ProductCategory> _productCategories;
        #endregion

        #region Constructor
        public frmProductCategories()
        {
            InitializeComponent();
        }
        #endregion

        #region IProductCategoriesView
        public List<ProductCategory> ProductCategories
        {
            set
            {
                gridProductCategories.DataSource = value;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "id",
                    "parent",
                    "menu_order",
                    "image",
                    "display"
                };
                if (gridProductCategories.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        gridProductCategories.Columns[column].Visible = false;
                    }
                }
                gridProductCategories.ReadOnly = true;
                LoadingGIF.Visible = false;
                gridProductCategories.Visible = true;
            }
        }
        public ProductCategory SelectedProductCategory
        {
            get { return _selectedProductCategory; }
        }
        public void AttachPresenter(ProductCategoriesPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion

        #region Events
        private void frmProductCategories_Load(object sender, EventArgs e)
        {
            _presenter.InitAsync();
        }

        private void gridProductCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridProductCategories.SelectedRows[0];
            if (row != null && row.DataBoundItem != null)
            {
                _selectedProductCategory = (ProductCategory)row.DataBoundItem;
            }
        }

        private void gridProductCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductCategoryDetails childForm = new frmProductCategoryDetails();
            ProductCategoryDetailsPresenter presenter = new ProductCategoryDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.ProductCategory = SelectedProductCategory;
            //childForm.ProductCategories = categories;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            //this.Close();
        }
        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            if (_selectedProductCategory != null && _selectedProductCategory.id > 0)
            {
                if (MessageBox.Show(this, AppTranslations.DELETE_PRODUCT_CATEGORY, AppTranslations.PRODUCT_CATEGORY, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    await _presenter.DeleteProductCategoryAsync(_selectedProductCategory.id);
                    this.RefreshForm();
                }
            }
            else
            {
                MessageBox.Show(this, AppTranslations.MUST_SELECT_PRODUCT, AppTranslations.PRODUCT, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            frmProductCategoryDetails childForm = new frmProductCategoryDetails();
            ProductCategoryDetailsPresenter presenter = new ProductCategoryDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.ProductCategory = SelectedProductCategory;
            //childForm.ProductCategories = categories;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            // this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductCategoryDetails childForm = new frmProductCategoryDetails();
            ProductCategoryDetailsPresenter presenter = new ProductCategoryDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.ProductCategory = new ProductCategory();
            //childForm.ProductCategories = categories;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            //this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshForm();
        }
        #endregion

        #region Private Methods
        private void RefreshForm()
        {
            gridProductCategories.Visible = false;
            LoadingGIF.Visible = true;
            _presenter.InitAsync();
        }


        #endregion


    }
}
