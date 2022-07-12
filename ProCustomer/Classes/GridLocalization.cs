using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Localization;
using DevExpress.ExpressApp.Win.Localization;

namespace ProCustomer.Classes
{
    class GridLocalization : GridControlLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                case GridStringId.GridGroupPanelText:
                    return "Gruplamak istediğniz kolonları bu bölgeye sürükleyip bırakabilirsiniz";
            }
            return base.GetLocalizedString(id);
        }
    }
}
