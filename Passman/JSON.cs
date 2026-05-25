using System.Collections.Generic;
using Newtonsoft.Json;

namespace Passman;

public class Vault
{
    public string? Site { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}

public class JsonStruct
{
    public string? VaultUsername { get; set; }
    public string? VaultPassword { get; set; }
    public string? VaultSalt { get; set; }
    public string? Vault { get; set; }
}

public class JSON
{
    
}