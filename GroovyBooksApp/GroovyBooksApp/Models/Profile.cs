using System;
using System.Collections.Generic;

namespace GroovyBooksApp.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
