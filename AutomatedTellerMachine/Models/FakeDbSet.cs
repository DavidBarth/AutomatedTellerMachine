using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatedTellerMachine.Models
{

    //Code imported from https://gist.github.com/LukeWinikates/1309447

    public class FakeDbSet<T> : System.Data.Entity.IDbSet<T> where T : class
    {
        private readonly List<T> _listlist = new List<T>();

        public FakeDbSet()
        {
            _listlist = new List<T>();
        }

        public FakeDbSet(IEnumerable<T> contents)
        {
            this._listlist = contents.ToList();
        }

        #region IDbSet<T> Members

        public T Add(T entity)
        {
            this._listlist.Add(entity);
            return entity;
        }

        public T Attach(T entity)
        {
            this._listlist.Add(entity);
            return entity;
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            throw new NotImplementedException();
        }

        public T Create()
        {
            throw new NotImplementedException();
        }

        public T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<T> Local
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public T Remove(T entity)
        {
            this._listlist.Remove(entity);
            return entity;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return this._listlist.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this._listlist.GetEnumerator();
        }

        #endregion

        #region IQueryable Members

        public Type ElementType
        {
            get { return this._listlist.AsQueryable().ElementType; }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return this._listlist.AsQueryable().Expression; }
        }

        public IQueryProvider Provider
        {
            get { return this._listlist.AsQueryable().Provider; }
        }

        #endregion
    }
}