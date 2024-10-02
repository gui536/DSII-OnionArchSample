namespace Todo.API.Adapter
{
    public class BaseAdapter<TEntity, TModel>
    {
        public IEnumerable<TEntity> Map(IEnumerable<TModel> models)
        {
            return models.Select(Map);
        }

        public IEnumerable<TModel> Map(IEnumerable<TEntity> entities)
        {
            return entities.Select(Map);
        }

        public TModel Map(TEntity entity)
        {
            var model = (TModel)Activator.CreateInstance(typeof(TModel));
            var properties = GetProperties<TModel, TEntity>();

            foreach (var propertyName in properties)
            {
                var value = entity.GetType().GetProperty(propertyName).GetValue(entity);
                model.GetType().GetProperty(propertyName).SetValue(model, value);
            }
            return model;
        }

        public TEntity Map(TModel model)
        {
            var entity = (TEntity)Activator.CreateInstance(typeof(TEntity));
            var properties = GetProperties<TEntity, TModel>();

            foreach (var propertyName in properties)
            {
                var value = model.GetType().GetProperty(propertyName).GetValue(model);
                entity.GetType().GetProperty(propertyName).SetValue(entity, value);
            }
            return entity;
        }

        private static List<string> GetProperties<TFrom, TTo>(){
            var from = typeof(TFrom).GetProperties();
            var to = typeof(TTo).GetProperties();
            var properties = new List<string>();

            foreach (var property in to)
            {
                var fromProperty = from.FirstOrDefault(p => p.Name.Equals(property.Name) && p.CanWrite);
                if(fromProperty != null) properties.Add(property.Name);
            }

            return properties;
        }
    }
}
