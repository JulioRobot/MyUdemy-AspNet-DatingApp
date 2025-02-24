using System;

namespace API.Entities;

public class AppUser
{
    public int id { get; set; }

    public required string UserName { get; set; }
}
