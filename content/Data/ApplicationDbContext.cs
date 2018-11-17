using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MvcStarter.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var mapper = new Npgsql.NameTranslation.NpgsqlSnakeCaseNameTranslator();

            foreach(var entity in builder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = mapper.TranslateTypeName(entity.Relational().TableName);

                foreach(var property in entity.GetProperties())
                {
                    property.Relational().ColumnName = mapper.TranslateMemberName(property.Name);
                }

                foreach(var key in entity.GetKeys())
                {
                    key.Relational().Name = mapper.TranslateMemberName(key.Relational().Name);
                }

                foreach(var key in entity.GetForeignKeys())
                {
                    key.Relational().Name = mapper.TranslateMemberName(key.Relational().Name);
                }

                foreach(var index in entity.GetIndexes())
                {
                    index.Relational().Name = mapper.TranslateMemberName(index.Relational().Name);
                }
            }
        }
    }
}