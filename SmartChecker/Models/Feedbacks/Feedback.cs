using System.Text.Json.Serialization;
using SmartChecker.Models.Essays;

namespace SmartChecker.Models.Feedbacks;

public class Feedback
{
    public Guid Id { get; set; }
    public float Mark { get; set; }
    public string Comment { get; set; }
    public Guid EssayId { get; set; }
    [JsonIgnore]
    public Essay Essay { get; set; }
}