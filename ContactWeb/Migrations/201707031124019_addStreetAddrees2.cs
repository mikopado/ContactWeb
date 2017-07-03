namespace ContactWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStreetAddrees2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "StreetAddress2", c => c.String());         
        }
               
        public override void Down()
        {
            DropColumn("dbo.Contacts", "StreetAddress2");
        }
    }
}
