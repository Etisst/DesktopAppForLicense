using Etisst.Desktop.BusinessLogic.UIConnector;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmProductTagDetails : frmBaseForm, IProductTagDetailsView
    {
        #region Private
        ProductTagDetailsPresenter _presenter;
        ProductTag _productTag;
        #endregion

        #region Constructor
        public frmProductTagDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region IProductTagDetailsView 

        public int ProductTagId { get; set; }

        public ProductTag ProductTag
        {
            get
            {
                _productTag.name = mtbName.Text;
                _productTag.slug = mtbSlug.Text;
                _productTag.description = rtbDescription.Text;
                return _productTag;
            }
            set
            {
                _productTag = value;
                mtbName.Text = _productTag.name;
                mtbSlug.Text = _productTag.slug;
                rtbDescription.Text = _productTag.description;
            }
        }

        public void AttachPresenter(ProductTagDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            _presenter.Save(ProductTag);
            this.Parent.Refresh();
            this.Close();
        }
        #endregion
    }
}
