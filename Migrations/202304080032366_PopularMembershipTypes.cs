namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopularMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) VAlUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) VAlUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) VAlUES (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) VAlUES (4, 300, 12, 20)");
        }

        public override void Down()
        {
        }
    }
}
