using System.Text.Json.Serialization;
using SmartChecker.Models.Feedbacks;
using SmartChecker.Models.Users;

namespace SmartChecker.Models.Essays;

public class Essay
{
    public Guid EssayId { get; set; }
    public string Content { get; set; }
    public Guid UserId { get; set; }
    [JsonIgnore]
    public User User { get; set; }
    [JsonIgnore]
    public Feedback Feedback { get; set; }
}