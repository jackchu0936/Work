using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_WORK.Models
{
    public class ViewModels
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
        public string TYPE { get; set; }
        public string DATE { get; set; }
        public string MONEY { get; set; }
       
    }



}