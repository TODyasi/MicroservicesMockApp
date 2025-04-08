namespace ClientAPI.Data
{
    using ClientAPI.Models;
    using Microsoft.EntityFrameworkCore;

    public class ClientDbContext : DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options) { }

        public DbSet<ClientModel> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding data

            modelBuilder.Entity<ClientModel>().HasData(
            new ClientModel
            {
                ClientId = Guid.Parse("a1f1c1b1-d1e1-4f11-b1c1-001100110011"),
                ClientFirstName = "Ayanda",
                ClientLastName = "Mokoena",
                ClientGender = "Female",
                ClientIDNumber = "9001014800087",
                ClientAddress = "123 Main Road",
                ClientCity = "Cape Town",
                ClientEmailAddress = "ayanda.mokoena@example.com",
                ClientPhoneNumber = "0821234567"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a2f2c2b2-d2e2-4f22-b2c2-002200220022"),
                ClientFirstName = "Thabo",
                ClientLastName = "Nkosi",
                ClientGender = "Male",
                ClientIDNumber = "8802035800089",
                ClientAddress = "45 Long Street",
                ClientCity = "Cape Town",
                ClientEmailAddress = "thabo.nkosi@example.com",
                ClientPhoneNumber = "0732345678"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a3f3c3b3-d3e3-4f33-b3c3-003300330033"),
                ClientFirstName = "Naledi",
                ClientLastName = "Dlamini",
                ClientGender = "Female",
                ClientIDNumber = "9503214800081",
                ClientAddress = "89 Victoria Road",
                ClientCity = "Cape Town",
                ClientEmailAddress = "naledi.dlamini@example.com",
                ClientPhoneNumber = "0613456789"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a4f4c4b4-d4e4-4f44-b4c4-004400440044"),
                ClientFirstName = "Sibusiso",
                ClientLastName = "Zulu",
                ClientGender = "Male",
                ClientIDNumber = "9205145800084",
                ClientAddress = "22 Nelson Street",
                ClientCity = "Cape Town",
                ClientEmailAddress = "sibusiso.zulu@example.com",
                ClientPhoneNumber = "0744567890"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a5f5c5b5-d5e5-4f55-b5c5-005500550055"),
                ClientFirstName = "Zanele",
                ClientLastName = "Khumalo",
                ClientGender = "Female",
                ClientIDNumber = "8707084800086",
                ClientAddress = "55 Beach Road",
                ClientCity = "Cape Town",
                ClientEmailAddress = "zanele.khumalo@example.com",
                ClientPhoneNumber = "0835678901"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a6f6c6b6-d6e6-4f66-b6c6-006600660066"),
                ClientFirstName = "Mandla",
                ClientLastName = "Mbatha",
                ClientGender = "Male",
                ClientIDNumber = "9109025800080",
                ClientAddress = "14 Mountain View",
                ClientCity = "Cape Town",
                ClientEmailAddress = "mandla.mbatha@example.com",
                ClientPhoneNumber = "0726789012"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a7f7c7b7-d7e7-4f77-b7c7-007700770077"),
                ClientFirstName = "Lerato",
                ClientLastName = "Pule",
                ClientGender = "Female",
                ClientIDNumber = "9601044800083",
                ClientAddress = "67 Rose Street",
                ClientCity = "Cape Town",
                ClientEmailAddress = "lerato.pule@example.com",
                ClientPhoneNumber = "0617890123"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a8f8c8b8-d8e8-4f88-b8c8-008800880088"),
                ClientFirstName = "Sipho",
                ClientLastName = "Ngcobo",
                ClientGender = "Male",
                ClientIDNumber = "9303025800085",
                ClientAddress = "90 Hilltop Drive",
                ClientCity = "Cape Town",
                ClientEmailAddress = "sipho.ngcobo@example.com",
                ClientPhoneNumber = "0848901234"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("a9f9c9b9-d9e9-4f99-b9c9-009900990099"),
                ClientFirstName = "Boitumelo",
                ClientLastName = "Mahlangu",
                ClientGender = "Female",
                ClientIDNumber = "9406154800088",
                ClientAddress = "101 Sunset Avenue",
                ClientCity = "Cape Town",
                ClientEmailAddress = "boitumelo.mahlangu@example.com",
                ClientPhoneNumber = "0609012345"
            },
            new ClientModel
            {
                ClientId = Guid.Parse("aa00c0b0-d0e0-4f00-b0c0-000000000000"),
                ClientFirstName = "Kagiso",
                ClientLastName = "Radebe",
                ClientGender = "Male",
                ClientIDNumber = "8911205800082",
                ClientAddress = "33 Palm Street",
                ClientCity = "Cape Town",
                ClientEmailAddress = "kagiso.radebe@example.com",
                ClientPhoneNumber = "0710123456"
            }
               
          );
        }

    }
}
