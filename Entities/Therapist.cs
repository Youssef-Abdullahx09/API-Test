namespace Application.Entities
{
    public class Therapist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
