using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Intent.RoslynWeaver.Attributes;

using EfEntityGenerationTests.Domain;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.EntityFramework.EFMapping", Version = "1.0")]

namespace EfEntityGenerationTests.Infrastructure.Data.EF
{
    public partial class L_SelfReferenceMultipleMapping : EntityTypeConfiguration<L_SelfReferenceMultiple>
    {

        public L_SelfReferenceMultipleMapping()
        {
            this.ToTable("L_SelfReferenceMultiple");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.HasMany(x => x.MiniSelves)
                ;

        }
    }
}
