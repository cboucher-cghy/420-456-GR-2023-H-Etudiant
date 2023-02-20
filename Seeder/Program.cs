// See https://aka.ms/new-console-template for more information
using DemoLocation2000.Models;
using EFCore_Seeder;
using FizzWare.NBuilder;

Console.WriteLine("Hello, World!");
using var ctx = DbContextFactory.CreateDbContext();

ctx.Modeles.RemoveRange(ctx.Modeles);
ctx.SaveChanges();

var listModeles = Builder<Modele>.CreateListOfSize(10)
    .All()
        .With(x => x.Nom = Faker.Company.Name())
.Build();


ctx.Modeles.AddRange(listModeles);
ctx.SaveChanges();

Console.Write("");
