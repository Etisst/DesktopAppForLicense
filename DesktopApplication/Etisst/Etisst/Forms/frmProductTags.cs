using Etisst.Desktop.BusinessLogic.UIConnector;
using Etisst.Desktop.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmProductTags : frmBaseForm, IProductTagsView
    {
        #region private members
        private ProductTagsPresenter _presenter;
        private ProductTag _selectedProductTag;
        #endregion

        #region Constructor
        public frmProductTags()
        {
            InitializeComponent();
        }
        #endregion

        #region IProductTagsView
        public List<ProductTag> ProductTags
        {
            set
            {
                gridProductTags.DataSource = value;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "id"
                };
                if (gridProductTags.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        gridProductTags.Columns[column].Visible = false;
                    }
                }
                gridProductTags.ReadOnly = true;
                LoadingGIF.Visible = false;
                gridProductTags.Visible = true;
            }
        }
        public ProductTag SelectedProductTag
        {
            get { return _selectedProductTag; }
        }
        public void AttachPresenter(ProductTagsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion

        #region Events
        private void frmProductTags_Load(object sender, EventArgs e)
        {
            _presenter.InitAsync();
        }

        private void gridProductTags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridProductTags.SelectedRows[0];
            if (row != null && row.DataBoundItem != null)
            {
                _selectedProductTag = (ProductTag)row.DataBoundItem;
            }
        }

        private void gridProductTags_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductTagDetails childForm = new frmProductTagDetails();
            ProductTagDetailsPresenter presenter = new ProductTagDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.ProductTag = SelectedProductTag;
            //childForm.ProductTags = Tags;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            //this.Close();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            frmProductTagDetails childForm = new frmProductTagDetails();
            ProductTagDetailsPresenter presenter = new ProductTagDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.ProductTag = SelectedProductTag;
            //childForm.ProductTags = Tags;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            // this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshForm();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductTagDetails childForm = new frmProductTagDetails();
            ProductTagDetailsPresenter presenter = new ProductTagDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.ProductTag = new ProductTag();
            //childForm.ProductCategories = categories;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            //this.Close();
        }

        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            if (_selectedProductTag != null && _selectedProductTag.id > 0)
            {
                if (MessageBox.Show(this, AppTranslations.DELETE_PRODUCT_TAG, AppTranslations.PRODUCT_TAG, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    await _presenter.DeleteProductTagAsync(_selectedProductTag.id);
                    this.RefreshForm();
                }
            }
            else
            {
                MessageBox.Show(this, AppTranslations.MUST_SELECT_PRODUCT_TAG, AppTranslations.PRODUCT_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Methods
        private void RefreshForm()
        {
            gridProductTags.Visible = false;
            LoadingGIF.Visible = true;
            _presenter.InitAsync();
        }

        #endregion
    }
}
