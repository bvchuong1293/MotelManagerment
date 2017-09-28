namespace MotelManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookRooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TimeIn = c.DateTime(nullable: false),
                        TimeOut = c.DateTime(nullable: false),
                        Fomality = c.Int(nullable: false),
                        PrePay = c.Double(nullable: false),
                        Promotion = c.Double(nullable: false),
                        VehiclesID = c.Int(nullable: false),
                        ServiceID = c.Int(nullable: false),
                        RoomID = c.String(nullable: false, maxLength: 20),
                        CustomerID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 20),
                        LastName = c.String(maxLength: 20),
                        IdentityCard = c.String(maxLength: 20),
                        Phone = c.String(maxLength: 20),
                        Sex = c.Boolean(nullable: false),
                        VehicleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 50),
                        Status = c.Int(nullable: false),
                        RoomTypeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeRooms", t => t.RoomTypeID)
                .Index(t => t.RoomTypeID);
            
            CreateTable(
                "dbo.TypeRooms",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        NameRoomType = c.String(maxLength: 50),
                        HourPrice = c.Double(nullable: false),
                        OverNightPrice = c.Double(nullable: false),
                        DayPrice = c.Double(nullable: false),
                        FinePrice = c.Double(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BookRoomServices",
                c => new
                    {
                        ServiceID = c.Int(nullable: false),
                        BookRoomID = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceID, t.BookRoomID })
                .ForeignKey("dbo.BookRooms", t => t.BookRoomID, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceID, cascadeDelete: true)
                .Index(t => t.ServiceID)
                .Index(t => t.BookRoomID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        UnitPrice = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BookRoomVehicles",
                c => new
                    {
                        BookRoomID = c.Int(nullable: false),
                        VehiclesID = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Vehicle_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.BookRoomID, t.VehiclesID })
                .ForeignKey("dbo.BookRooms", t => t.BookRoomID, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_ID)
                .Index(t => t.BookRoomID)
                .Index(t => t.Vehicle_ID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                        LicensePlate = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ImportGoodss",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        TotalMoney = c.Double(nullable: false),
                        ServiceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Services", t => t.ServiceID, cascadeDelete: true)
                .Index(t => t.ServiceID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 20, unicode: false),
                        Password = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        DisplayName = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        PermissionID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Permissions", t => t.PermissionID, cascadeDelete: true)
                .Index(t => t.PermissionID);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Personnels",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        BirthDay = c.DateTime(),
                        Sex = c.Boolean(),
                        HomeTown = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Members", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personnels", "ID", "dbo.Members");
            DropForeignKey("dbo.Members", "PermissionID", "dbo.Permissions");
            DropForeignKey("dbo.ImportGoodss", "ServiceID", "dbo.Services");
            DropForeignKey("dbo.BookRoomVehicles", "Vehicle_ID", "dbo.Vehicles");
            DropForeignKey("dbo.BookRoomVehicles", "BookRoomID", "dbo.BookRooms");
            DropForeignKey("dbo.BookRoomServices", "ServiceID", "dbo.Services");
            DropForeignKey("dbo.BookRoomServices", "BookRoomID", "dbo.BookRooms");
            DropForeignKey("dbo.BookRooms", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "RoomTypeID", "dbo.TypeRooms");
            DropForeignKey("dbo.BookRooms", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Personnels", new[] { "ID" });
            DropIndex("dbo.Members", new[] { "PermissionID" });
            DropIndex("dbo.ImportGoodss", new[] { "ServiceID" });
            DropIndex("dbo.BookRoomVehicles", new[] { "Vehicle_ID" });
            DropIndex("dbo.BookRoomVehicles", new[] { "BookRoomID" });
            DropIndex("dbo.BookRoomServices", new[] { "BookRoomID" });
            DropIndex("dbo.BookRoomServices", new[] { "ServiceID" });
            DropIndex("dbo.Rooms", new[] { "RoomTypeID" });
            DropIndex("dbo.BookRooms", new[] { "CustomerID" });
            DropIndex("dbo.BookRooms", new[] { "RoomID" });
            DropTable("dbo.Personnels");
            DropTable("dbo.Permissions");
            DropTable("dbo.Members");
            DropTable("dbo.ImportGoodss");
            DropTable("dbo.Vehicles");
            DropTable("dbo.BookRoomVehicles");
            DropTable("dbo.Services");
            DropTable("dbo.BookRoomServices");
            DropTable("dbo.TypeRooms");
            DropTable("dbo.Rooms");
            DropTable("dbo.Customers");
            DropTable("dbo.BookRooms");
        }
    }
}
