namespace Application.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public int ReferanceNumber { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
