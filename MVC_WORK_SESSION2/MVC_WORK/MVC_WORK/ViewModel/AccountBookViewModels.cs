using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_WORK.Models;
namespace MVC_WORK.ViewModel
{
    public class AccountBookViewModels
    {

        public System.Guid Id { get; set; }
        public int Categoryyy { get; set; }
        public int Amounttt { get; set; }
        public System.DateTime Dateee { get; set; }
        public string Remarkkk { get; set; }
        /// <summary>
        /// Categoryyy的中文
        /// </summary>
        public string CategoryName { get; set; }

        public IEnumerable<AccountBookViewModels> AccountBookData
        {
            get;
            set;
        }

        




    }
    
   

}