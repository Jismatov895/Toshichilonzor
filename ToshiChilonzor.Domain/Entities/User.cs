﻿using ToshiChilonzor.Domain.Commons;

namespace ToshiChilonzor.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

