using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using InventoryERP.Data.Mapping;
using InventoryERP.Domain;
using InventoryERP.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace InventoryERP.Data.Implementations
{
    public partial class MongoRepository<TAggregateRoot> : IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        private MongoDatabase _database;
        private MongoCollection<TAggregateRoot> Collection
        {
            get
            {
                return _database.GetCollection<TAggregateRoot>(Inflector.Pluralize(typeof(TAggregateRoot).Name));
            }
        }        
        
        public MongoRepository(MongoDatabase database)
        {
            _database = database;
        }

        public IQueryable<TAggregateRoot> GetQuery()
        {
            return this.Collection.AsQueryable<TAggregateRoot>();
        }
        public TAggregateRoot GetById(string id)
        {
            return this.GetQuery().FirstOrDefault(x => x.Id == id);
        }
        public void Save(TAggregateRoot entity)
        {
            Check.Argument.Null(entity, "entity");

            this.Collection.Save<TAggregateRoot>(entity);
        }
        public void AddRange(IEnumerable<TAggregateRoot> entities)
        {
            Check.Argument.Null(entities, "entities");

            this.Collection.InsertBatch<TAggregateRoot>(entities);
        }
        public bool Remove(string id)
        {
            Check.Argument.EmptyOrWhiteSpace(id, "id", "You must provide an id.");

            WriteConcernResult result = this.Collection.Remove(Query.EQ("_id", id));

            return result.DocumentsAffected > 0;
        }
        public void RemoveAll()
        {
            this.Collection.RemoveAll();
        }

        }
}