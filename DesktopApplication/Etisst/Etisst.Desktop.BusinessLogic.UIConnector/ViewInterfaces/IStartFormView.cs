using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IStartFormView
    {
        void AttachPresenter(StartFormPresenter presenter);
    }
}
