namespace ProjectTestVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipType (Id, SignUpFee,DurationInMonths, Discount) VALUES(1,0,0,0) ");
            Sql("INSERT INTO MembershipType (Id, SignUpFee,DurationInMonths, Discount) VALUES(2,15,2,20) ");
            Sql("INSERT INTO MembershipType (Id, SignUpFee,DurationInMonths, Discount) VALUES(3,50,5,7) ");
            Sql("INSERT INTO MembershipType (Id, SignUpFee,DurationInMonths, Discount) VALUES(4,125,10,30) ");
        }
        
        public override void Down()
        {
        }
    }
}
