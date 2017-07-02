using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_WORK.Models;
using System.Data.Entity;
using MVC_WORK.ViewModel;

namespace MVC_WORK.Interface
{
    public class AccountBookRepository : IAccountBookRepository
    {
        private static IEnumerable<AccountBook> Source { get; set; }
        protected SkillTreeHomeworkEntities db
        {
            get;
            private set;
        }
        public AccountBookRepository()
        {
            this.db = new SkillTreeHomeworkEntities();
        }

        public AccountBook Get(Guid id)
        {
            return db.AccountBook.FirstOrDefault(x => x.Id == id);
        }
                
        public void Create(AccountBook instance)
        {
            if (instance == null)
            {
                //當 Null 參考 (在 Visual Basic 中為 Nothing) 傳遞給不接受其為有效引數的方法時，所擲回的例外狀況。
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.AccountBook.Add(instance);
                this.SaveChanges();
            }
        }

        public void Update(AccountBook instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                //物件上的其中一個純量屬性已修改，而且尚未呼叫 SaveChanges 方法。
                //已呼叫 Modified 方法時，在沒有變更追蹤 Proxy 的 POCO 實體中，
                //已修改之屬性的狀態會變更為 DetectChanges。 儲存變更之後，
                //物件狀態會變更為 Unchanged
                db.Entry(instance).State = EntityState.Modified;
                this.SaveChanges();
            }
        }

        public void Delete(AccountBook instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                //已經從物件內容中刪除物件。 儲存變更之後，物件狀態會變更為 Detached。
                db.Entry(instance).State = EntityState.Deleted;
                this.SaveChanges();
            }
        }
        
        public IQueryable<AccountBookViewModels> GetAll()
        {

            return  db.AccountBook.OrderBy(x => x.Dateee).Select(u=> new AccountBookViewModels
            {
                Id = u.Id,
                Amounttt = u.Amounttt,
                Dateee = u.Dateee,
                CategoryName = u.Categoryyy == 1 ? "支出" : "收入",
                Remarkkk = u.Remarkkk
            });
        }

        public void SaveChanges()
        {
            this.db.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }

    }



}
