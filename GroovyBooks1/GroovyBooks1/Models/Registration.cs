using System;
using System.Collections.Generic;

namespace GroovyBooks1.Models;

public partial class Registration
{
    public int RegistrationId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public int? PhoneNo { get; set; }

    public string? Address { get; set; }
}
