using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class User
{

    public string? Context { get; set; }
    [JsonPropertyName("@odata.context")]
    public string? DisplayName { get; set; }
    public string? Surname { get; set; }
    public string? GivenName { get; set; }
    public string? UserPrincipalName { get; set; }
    public string? businessPhones { get; set; }
    public string? JobTitle { get; set; }
    public string? Mail { get; set; }


    // Pass the json data to string and serialize it
    public override string ToString() => JsonSerializer.Serialize<User>(this);


}