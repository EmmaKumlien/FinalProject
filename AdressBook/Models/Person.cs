﻿using AdressBook.Interfaces;

namespace AdressBook.Models;

public class Person : IPerson
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int? PhoneNumber { get; set; }
    public string? StreetName { get; set; }
    public int? PostalCode { get; set; }
    public string CityName { get; set; } = null!;
    

 


}
