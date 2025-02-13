using Exercice4.Models;

namespace Exercice4.Data
{
    public class FakeDb
    {
        public readonly HashSet<Marmoset> Marmosets = new()
        {
           new Marmoset(1, "Ouistiti commun", 0.35m, 20m),
            new Marmoset(2, "Ouistiti pygmée", 0.12m, 15m),
            new Marmoset(3, "Ouistiti à pinceaux blancs", 0.40m, 23m),
            new Marmoset(4, "Ouistiti argenté", 0.30m, 22m),
            new Marmoset(5, "Ouistiti à toupet noir", 0.38m, 21m)
        };
    }
}
