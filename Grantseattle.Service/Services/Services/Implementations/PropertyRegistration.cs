using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryERP.Data;
using InventoryERP.Services;
using InvertoryERP.Core.Domain;

namespace InventoryERP.Service.Services.Services.Implementations
{
    public class PropertyRegistration : BaseService, IPropertyRegistration
    {
        private IRepository<Propertys> propertyRepository { get; set; }

        public PropertyRegistration(IRepository<Propertys> newsRepository)
        {
            propertyRepository = newsRepository;
        }

        public Propertys GetById(string id)
        {
            return propertyRepository.GetById(id);
        }

        public void Save(Propertys entity)
        {
            propertyRepository.Save(entity);
        }

        public void Delete(Propertys entity)
        {
            entity.Status = Propertys.PropertyStatusText.Delete;
            entity.UpdatedAt = DateTime.UtcNow;
            propertyRepository.Save(entity);
        }

        public IList<Propertys> GetList()
        {
            return propertyRepository.GetQuery().Where(x => x.Status== Propertys.PropertyStatusText.Active).ToList();
        }

        public void Edit(Propertys oldModelObj)
        {
            /*Have ti implement this */
            //NewsRepository.
        }

        
    }
}
