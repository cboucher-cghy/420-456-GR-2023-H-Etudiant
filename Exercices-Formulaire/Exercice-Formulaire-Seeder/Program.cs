using Exercice_Formulaire_Etudiant.Models;
using Exercice_Formulaire_Seeder;
using FizzWare.NBuilder;

using var context = DbContextFactory.CreateDbContext();
// Vidange de la table
context.Departements.RemoveRange(context.Departements);
context.Employes.RemoveRange(context.Employes);
context.SaveChanges();

//Création des départements
var budgetGenerator = new RandomGenerator();
List<Departement> listeDepartement = new()
            {
                new Departement() { Nom = "Finance", Budget = budgetGenerator.Next(20000, 65000) },
                new Departement() { Nom = "Informatique", Budget = budgetGenerator.Next(20000, 65000) },
                new Departement() { Nom = "Ressources humaines", Budget = budgetGenerator.Next(20000, 65000) },
                new Departement() { Nom = "Développement", Budget = budgetGenerator.Next(20000, 65000) },
            };

context.Departements.AddRange(listeDepartement);
context.SaveChanges();

List<Pays> listePays = context.Pays.ToList();

//Création des employés
var generator = new RandomGenerator();
Random gen = new();
DateTime start = new(2017, 1, 1);
int range = (new DateTime(2020, 1, 1) - start).Days;

var employes = Builder<Employe>.CreateListOfSize(500)
    .All()
        .With(e => e.EmployeId = 0)
        .With(e => e.Nom = Faker.Name.FullName())
        .With(e => e.Age = generator.Next(18, 75))
        .With(e => e.DateEmbauche = start.AddDays(gen.Next(range)))
        .With(e => e.Salaire = generator.Next(38000, 95000))
        .With(e => e.EstEnEmploi = true)
        .With(e => e.PaysOrigine = Pick<Pays>.RandomItemFrom(listePays))
        .With(e => e.Departement = Pick<Departement>.RandomItemFrom(listeDepartement))
    .Build();

context.Employes.AddRange(employes.ToArray());
context.SaveChanges();
