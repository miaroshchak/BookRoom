using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookRoom.Data.EntityConfigurations
{
    public class RoomBookConfiguration : IEntityTypeConfiguration<RoomBook>
    {
        public void Configure(EntityTypeBuilder<RoomBook> builder)
        {
            builder.ToTable("RoomBooks");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Room).WithMany().HasForeignKey(x => x.RoomId);
        }
    }
}
