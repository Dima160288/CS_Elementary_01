namespace CodeFirst_CodeSecond_EF
{
    using System.Data.Entity;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<PersonalInfo> PersonalInfoes { get; set; }
    }
}
