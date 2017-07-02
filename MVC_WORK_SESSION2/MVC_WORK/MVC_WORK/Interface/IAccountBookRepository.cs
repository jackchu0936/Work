using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_WORK.Models;
using MVC_WORK.ViewModel;
namespace MVC_WORK.Interface
{
    //實作參考 http://kevintsengtw.blogspot.tw/2012/10/aspnet-mvc-part1.html
    //目的先建立 Repository 類別的介面，建立介面是為了要避免直接依賴 Repository 類別
    //，往後在 Controller 中只需要用介面來進行資料操作，而不需直接使用 Repository 類別；
    interface IAccountBookRepository
    {
       
        void Create(AccountBook instance);

        void Update(AccountBook instance);

        void Delete(AccountBook instance);

        AccountBook Get(Guid id);

        IQueryable<AccountBookViewModels> GetAll();

        void SaveChanges();




    }
}
