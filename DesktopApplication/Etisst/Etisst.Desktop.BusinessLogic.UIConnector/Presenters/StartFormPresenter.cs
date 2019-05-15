using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class StartFormPresenter
    {
        #region  View

        private IStartFormView _view;

        #endregion

        #region Constructors

        public StartFormPresenter(IStartFormView view)
        {
            this._view = view;
        }

        #endregion
    }
}
