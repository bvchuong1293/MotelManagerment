using MotelManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Data
{
    public class MotelManagementDbContext:DbContext
    {
        public MotelManagementDbContext() : base("MotelManagementConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<BookRoom> BookRooms { get; set; }
        public DbSet<BookRoomService> BookRoomServices { get; set; }
        public DbSet<BookRoomVehicles> BookRoomVehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ImportGoods> ImportGoods { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Error> Errors { get; set; }


    }
}
