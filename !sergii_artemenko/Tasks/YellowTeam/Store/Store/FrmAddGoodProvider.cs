using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class FrmAddGoodProvider
    {
        public static frmAddGood FrmAddGood
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new frmAddGood();
                }
                return _form;
            }
        }
        private static frmAddGood _form;
    }
}
