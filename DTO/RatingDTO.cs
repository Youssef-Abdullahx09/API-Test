namespace Application.DTO
{
    public class RatingDTO
    {
        public int Rate { get; set; }
        public int QuestionNo1Rating { get; set; }
        public int QuestionNo2Rating { get; set; }
        public int QuestionNo3Rating { get; set; }
        public int QuestionNo4Rating { get; set; }
        public string ClientComment { get; set; }
        public string AdministratorComment { get; set; }
        public bool WantToBeContacted { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int ClientId { get; set; }
        public int SessionId { get; set; }
    }
}
