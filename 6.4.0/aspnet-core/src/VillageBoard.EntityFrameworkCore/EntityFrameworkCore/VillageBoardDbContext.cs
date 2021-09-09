using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VillageBoard.Authorization.Roles;
using VillageBoard.Authorization.Users;
using VillageBoard.MultiTenancy;
using VillageBoard.Announcement_Types;
using VillageBoard.Campuses;
using VillageBoard.Item_Types;
using VillageBoard.Meals;
using VillageBoard.Health_Inspection_Statuses;
using VillageBoard.Maintainence_Request_Statuses;
using VillageBoard.Payment_Types;
using VillageBoard.Residence_Types;
using VillageBoard.Room_Statuses;
using VillageBoard.Sizes;
using VillageBoard.Suppliers;
using VillageBoard.Time_Slots;
using VillageBoard.Years;
using VillageBoard.Dates;
using VillageBoard.Health_Inspection_Types;
using VillageBoard.Room_Inspections;
using VillageBoard.Meal_Types;
using VillageBoard.Menu_Types;
using VillageBoard.Product_Types;
using VillageBoard.Visitation_Application_Statuses;
using VillageBoard.Annoucements;
using VillageBoard.Blocks;
using VillageBoard.Carts;
using VillageBoard.Collection_Reminders;
using VillageBoard.Disciplinary_Hearings;
using VillageBoard.Events;
using VillageBoard.Health_Inspections;
using VillageBoard.Items;
using VillageBoard.Maintainence_Categories;
using VillageBoard.Order_Statuses;
using VillageBoard.Orders;
using VillageBoard.Payment_Statuses;
using VillageBoard.Payments;
using VillageBoard.Prices;
using VillageBoard.Products;
using VillageBoard.Residences;
using VillageBoard.Rooms;
using VillageBoard.Statuses;
using VillageBoard.Student_Visitations;

namespace VillageBoard.EntityFrameworkCore
{
    public class VillageBoardDbContext : AbpZeroDbContext<Tenant, Role, User, VillageBoardDbContext>
    {

        public DbSet<Studnet_Visitation> Student_Visitations { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Residence> Residences { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Payment_Status> Payment_Statuses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Order_Status> Order_Statuses { get; set; }

        public DbSet<Maintainence_Category> Maintainence_Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Health_Inspection> Health_Inspections { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Disciplinary_Hearing> Disciplinary_Hearings { get; set; }

        public DbSet<Collection_Reminder> Collection_Reminders { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Block> Blocks { get; set; }

        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Announcement_Type> Announcement_Types { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Item_Type> Item_Types { get; set; }

        public DbSet<Health_Inspection_Status> Health_Inspection_Statuses { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Meal_Type> Meal_types { get; set; }
        public DbSet<Maintainence_Request_Status> Maintainence_Request_Statuses { get; set; }
        public DbSet<Menu_Type> Menu_Types { get; set; }
        public DbSet<Payment_Type> Payment_Types { get; set; }

        public DbSet<Product_Type> Product_Type { get; set; }

        public DbSet<Residence_Type> Residence_Type { get; set; }
        public DbSet<Room_Status> Room_Statuses { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Visitation_Applicaition_Status> Visitation_Application_Statuses { get; set; }
        public DbSet<Time_Slot> Time_Slots { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Health_Inpsection_Type> Health_Inspection_Type { get; set; }
        public DbSet<Room_Inspection> Room_Inspection { get; set; }
        

















        public VillageBoardDbContext(DbContextOptions<VillageBoardDbContext> options)
            : base(options)
        {
        }
    }
}
