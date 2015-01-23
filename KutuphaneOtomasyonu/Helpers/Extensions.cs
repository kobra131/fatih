using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneOtomasyonu.Helpers
{
    public static class Extensions
    {

        public static void SetToLookUpSettings(this LookUpEdit lookUp, object dataSource, string displayHeader, string displayMember, string valueMember)
        {   
            lookUp.Properties.Columns.Clear();
            lookUp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayMember, displayHeader));
            lookUp.Properties.DisplayMember = displayMember;
            lookUp.Properties.ValueMember = valueMember;
            lookUp.Properties.DataSource = dataSource;
        }
    }
}
