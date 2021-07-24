using System.Data.Entity;

namespace AAtranslitWPF
{
    class SymbolContext: DbContext
    {
        public SymbolContext()
            : base("DbConnection")
        { }

        public DbSet<Symbol> Symbols { get; set; }
    }
}
