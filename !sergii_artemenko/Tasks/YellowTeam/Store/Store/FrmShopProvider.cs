using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class FrmShopProvider
    {
        public static frmShop FrmShop
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new frmShop();
                }
                return _form;
            }
        }
        private static frmShop _form;
    }
}
