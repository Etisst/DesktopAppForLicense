using Etisst.Desktop.BusinessLogic.UIConnector;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmProductCategoryDetails : frmBaseForm, IProductCategoryDetailsView
    {
        #region Private
        ProductCategoryDetailsPresenter _presenter;
        ProductCategory _productCategory;
        #endregion

        #region Constructor
        public frmProductCategoryDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region IProductCategoryDetailsView 

        public int ProductCategoryId { get; set; }
        
        public ProductCategory ProductCategory
        {
            get
            {
                    _productCategory.name = mtbName.Text;
                    _productCategory.slug = mtbSlug.Text;
                    _productCategory.description = rtbDescription.Text;
                return _productCategory;
            }
            set
            {
                _productCategory = value;
                mtbName.Text = _productCategory.name;
                mtbSlug.Text = _productCategory.slug;
                rtbDescription.Text = _productCategory.description;
            }
        }

        public void AttachPresenter(ProductCategoryDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            _presenter.Save(ProductCategory);
            this.Parent.Refresh();
            this.Close();
        }
        #endregion
    }
}
