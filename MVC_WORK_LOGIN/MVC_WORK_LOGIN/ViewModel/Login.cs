using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_WORK_LOGIN.ViewModel
{
    public class Login
    {
        [DisplayName("帳號")]
        [RegularExpression(@"\w.+\@\w.+")]
        public string LOGIN_ID { get; set; }
        [DisplayName("密碼")]
        [StringLength(20,MinimumLength =4)]
        public string PASSWORD { get; set; }
    }
}