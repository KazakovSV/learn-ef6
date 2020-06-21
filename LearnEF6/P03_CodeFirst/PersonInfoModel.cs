namespace P03_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PersonInfoModel : DbContext
    {
        public PersonInfoModel()
            : base("name=PersonInfoModel")
        {
        }

        public virtual DbSet<PersonInfo> PersonInfos { get; set; }
    }
}