


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPA.PhoneBook.PhoneBook.Persons;

namespace SPA.PhoneBook.EntityMapper.Persons
{
public class PersonCfg : IEntityTypeConfiguration<Person>
    {
    public void Configure(EntityTypeBuilder<Person>
        builder)
        {

        builder.ToTable("Persons", YoYoAbpefCoreConsts.SchemaNames.CMS);

        builder.Property(a => a.Id).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.Name).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.EmailAddress).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.Address).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.PhoneNumbers).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
        }
        }


