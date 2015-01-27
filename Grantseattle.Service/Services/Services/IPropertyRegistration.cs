using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvertoryERP.Core.Domain;

namespace InventoryERP.Service.Services.Services
{
    public interface IPropertyRegistration
    {
        Propertys GetById(string id);
        void Save(Propertys entity);
        void Delete(Propertys entity);
        IList<Propertys> GetList();
        void Edit(Propertys oldModelObj);
        //void SavePropertyPurpose(IList<Propertys> propertyPurposes);
    }
}
