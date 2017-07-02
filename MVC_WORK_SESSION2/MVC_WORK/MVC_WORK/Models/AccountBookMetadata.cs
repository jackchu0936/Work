using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_WORK.Models
{
    //預防外加的metadata屬性因為更新而被清掉
    [MetadataType(typeof(AccountBookMetadata))]
    public partial class AccountBook
    {
        public class AccountBookMetadata
        {
            public System.Guid Id { get; set; }
            public int Categoryyy { get; set; }
            public int Amounttt { get; set; }
            public System.DateTime Dateee { get; set; }
            public string Remarkkk { get; set; }
        }
    }
}
        


