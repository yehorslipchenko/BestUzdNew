using BestUzdNew.Domain.Constants;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestUzdNew.DataAccess.Migrations
{

    public partial class FillUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserRole_IsDeleted",
                table: "UserRole",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_IsDeleted",
                table: "UserInformation",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_User_IsDeleted",
                table: "User",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_IsDeleted",
                table: "Translation",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscountToService_IsDeleted",
                table: "ServiceSetDiscountToService",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscount_IsDeleted",
                table: "ServiceSetDiscount",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupToService_IsDeleted",
                table: "ServiceGroupToService",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupDiscount_IsDeleted",
                table: "ServiceGroupDiscount",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroup_IsDeleted",
                table: "ServiceGroup",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDiscount_IsDeleted",
                table: "ServiceDiscount",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Service_IsDeleted",
                table: "Service",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_IsDeleted",
                table: "Schedule",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IsDeleted",
                table: "Order",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Language_IsDeleted",
                table: "Language",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_IsDeleted",
                table: "DiscountType",
                column: "IsDeleted");

            migrationBuilder.Sql($@"
                INSERT INTO UserRole(NameAlias)
                VALUES ('{UserRoleAliases.AdminRoleAlias}')

                INSERT INTO UserRole(NameAlias)
                VALUES ('{UserRoleAliases.BasicRoleAlias}')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRole_IsDeleted",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserInformation_IsDeleted",
                table: "UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_User_IsDeleted",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Translation_IsDeleted",
                table: "Translation");

            migrationBuilder.DropIndex(
                name: "IX_ServiceSetDiscountToService_IsDeleted",
                table: "ServiceSetDiscountToService");

            migrationBuilder.DropIndex(
                name: "IX_ServiceSetDiscount_IsDeleted",
                table: "ServiceSetDiscount");

            migrationBuilder.DropIndex(
                name: "IX_ServiceGroupToService_IsDeleted",
                table: "ServiceGroupToService");

            migrationBuilder.DropIndex(
                name: "IX_ServiceGroupDiscount_IsDeleted",
                table: "ServiceGroupDiscount");

            migrationBuilder.DropIndex(
                name: "IX_ServiceGroup_IsDeleted",
                table: "ServiceGroup");

            migrationBuilder.DropIndex(
                name: "IX_ServiceDiscount_IsDeleted",
                table: "ServiceDiscount");

            migrationBuilder.DropIndex(
                name: "IX_Service_IsDeleted",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_IsDeleted",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Order_IsDeleted",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Language_IsDeleted",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_DiscountType_IsDeleted",
                table: "DiscountType");
        }
    }
}
