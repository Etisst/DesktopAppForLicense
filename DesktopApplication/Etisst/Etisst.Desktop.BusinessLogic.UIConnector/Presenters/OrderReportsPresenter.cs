namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class OrderReportsPresenter
    {
        #region Private members
        private IOrderReportsView _view;
        #endregion
        #region Constructor
        public OrderReportsPresenter(IOrderReportsView view)
        {
            this._view = view;
        }
        #endregion
    }
}
