using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WORK.Models
{
    public class ViewModels
    {
    }

    public class AccountingViewModel
    {
        public string MONEY { get; set; }
        public string DATE { get; set; }
        public string REMARKS { get; set; }

    }

    public class AccountingDataViewModel
    {
        public string TYPE { get; set; }
        public string DATE { get; set; }
        public string MONEY { get; set; }
       
    }



}