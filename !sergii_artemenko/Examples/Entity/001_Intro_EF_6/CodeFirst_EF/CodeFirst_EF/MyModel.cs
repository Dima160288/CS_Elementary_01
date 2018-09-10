namespace CodeFirst_EF
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyModel : DbContext
    {
       
        public MyModel()
            : base("name=MyModel")
        {
        }

        
        public virtual DbSet<PersonalInfo> PersonalInfos { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}