using System.Text.Json.Serialization;
using SmartChecker.Models.Essays;

namespace SmartChecker.Models.Users;

public class User
{
    public Guid Id;
    public string Name;
    [JsonIgnore]
    public List<Essay> Essays { get; set; }
}