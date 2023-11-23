namespace Application.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime SessionDate { get; set; }
        public int TherapistId { get; set; }
        public int ClientId { get; set; }
        public string RatingId { get; set; }
        public virtual Therapist Therapist { get; set; }
        public virtual Client Client { get; set; }
        public virtual Rating Rating { get; set; }

    }
}
