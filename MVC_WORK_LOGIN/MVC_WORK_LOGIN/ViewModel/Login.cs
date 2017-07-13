using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WORK_LOGIN.ViewModel
{
    public class Login
    {
        [DisplayName("帳號")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w.+\@\w.+", ErrorMessage = "帳號 欄位 不是正確的EMAIL格式")]
        [Remote("CheckLogin", "Validate", ErrorMessage = "帳號 欄位 不可含有以下字串(skilltree,demo,twMVC)")]
        public string LOGIN_ID { get; set; }
        [DisplayName("密碼")]
        [Required]
        [StringLength(20,MinimumLength =4)]
        public string PASSWORD { get; set; }
    }
}