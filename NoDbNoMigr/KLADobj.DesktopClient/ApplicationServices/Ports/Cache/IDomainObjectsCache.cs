using KLADobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace KLADobj.ApplicationServices.Ports.Cache
{
    public interface IDomainObjectsCache<T> where T : DomainObject
    {
        T GetObject(long id);

        IEnumerable<T> GetObjects();

        void UpdateObjects(IEnumerable<T> domainObjects, DateTime expirationTime, bool allObjects);
        
        void UpdateObject(T domainObject, DateTime expirationTime);

        void ClearCache();
    }
}
