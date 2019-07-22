using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBHibernateTest.Utils
{
    public class Manager<T>
    {
        // 插入一条纪录
        public void Add<T>(T user)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(user);
                    transaction.Commit();
                }
            }
        }

        // 删除一条纪录
        public void Delete(T T)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(T);
                    transaction.Commit();
                }
            }
        }

        // 更新一条纪录
        public void Update(T T)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(T);
                    transaction.Commit();
                }
            }
        }

        // 查询一条纪录
        public T GetByID(int id)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                // 查询不会对数据进行操作，可以不用事务
                var T = session.Get<T>(id);
                return T;
            }
        }

        // 查询一条纪录
        public T GetByName(string TName)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                var T = session
                    .CreateCriteria(typeof(T))
                    .Add(Restrictions.Eq("TName", TName))
                    .UniqueResult<T>();
                return T;
            }
        }

        // 查询多条纪录
        public ICollection<T> GetAll()
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                var list = session.CreateCriteria(typeof(T)).List<T>();
                return list;
            }
        }

    }

}
