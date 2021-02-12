using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core Katmanı diğer katmanları referans almaz..Bağımsız kullanıma açıktır.
    //Genereic Constraint
    //class: Referans Tip
    //IEntity: IEntity veya IEntity implemente eden bir nesne olabilir.
    //new(): new leneblir olmalı (Abstract new lenemez.Soyut sınıf.)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
