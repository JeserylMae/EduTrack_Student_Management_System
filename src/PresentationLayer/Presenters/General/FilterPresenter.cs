using PresentationLayer.UserControls.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters.General
{
    internal class FilterPresenter
    {
        public FilterPresenter(IFilterControl filterControl)
        {
            _filterControl = filterControl;
        }

        private IFilterControl _filterControl;
    }
}
