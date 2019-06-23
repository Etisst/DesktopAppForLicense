

using Etisst.Desktop.BusinessLogic.UIConnector;

namespace Etisst
{
    public partial class frmLookups : frmBaseForm
    {
        public frmLookups()
        {
            InitializeComponent();
        }

        private void btnCategories_Click(object sender, System.EventArgs e)
        {
            frmProductCategories childForm = new frmProductCategories();
            ProductCategoriesPresenter presenter = new ProductCategoriesPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            this.Close();
        }

        private void btnTags_Click(object sender, System.EventArgs e)
        {
            frmProductTags childForm = new frmProductTags();
            ProductTagsPresenter presenter = new ProductTagsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            this.Close();
        }
    }
}
