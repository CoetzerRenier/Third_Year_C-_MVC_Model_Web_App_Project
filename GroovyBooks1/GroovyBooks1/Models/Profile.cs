using System;
using System.Collections.Generic;

namespace GroovyBooks1.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
