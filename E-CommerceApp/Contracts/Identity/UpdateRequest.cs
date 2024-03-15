﻿namespace E_CommerceApp.Contracts.Identity;

public class UpdateRequest
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string PhoneNumber { get; set; }
    public required string AddressLine { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
}