namespace SporcialAPI.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public DateTime UserBirthDate { get; set; }
        public string UserLocation { get; set; }
        public int UserHeight { get; set; }
        public int UserWeight { get; set; }
        public string? UserProfilePhoto { get; set; }
        public bool UserAgreement { get; set; }
        public bool HealthAgreement { get; set; }
    }
}