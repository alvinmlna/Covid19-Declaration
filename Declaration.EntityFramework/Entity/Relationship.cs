namespace Declaration.EntityFramework.Entity
{
    public class Relationship
    {
        public int DeclarationId { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string RelationshipType { get; set; }

        public virtual DeclarationForm DeclarationForm { get; set; }
    }
}
