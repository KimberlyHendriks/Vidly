namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('John Smith', 'False', 1, 23-9-2001)");
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Mary Williams', 'True', 3, 2-1-1949)");
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Paige Jennings', 'True', 4, 24-6-1984)");
        }
        
        public override void Down()
        {
        }
    }
}
