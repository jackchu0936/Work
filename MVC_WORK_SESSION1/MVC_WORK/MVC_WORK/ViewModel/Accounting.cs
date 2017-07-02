using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_WORK.ViewModel
{
    public class Accounting
    {
    }


    public class AccountingViewModel
    {
        [DisplayName("金額")]
        public string MONEY { get; set; }
        [DisplayName("日期")]
        public string DATE { get; set; }
        [DisplayName("備註")]
        public string REMARKS { get; set; }

    }

    public class AccountingDataViewModel
    {
        [DisplayName("類別")]
        public string AccountTYPE { get; set; }
        [DisplayName("日期")]
        public string DATE { get; set; }
        [DisplayName("金額")]
        public string MONEY { get; set; }

    }

}