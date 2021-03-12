namespace Moviearo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdayManually : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = CAST('1980-01-01' AS DATETIME) WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
