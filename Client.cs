using System.Collections.Generic;

class Client
{
    public string firstName { get; init; }
    public string lastName { get; init; }
    public string email { get; init; }
    public string age { get; init; }
    public string passportNum { get; init; }
    public string password { get; init; }
    public string phoneNum { get; init; }
    public string maritualStatus { get; init; }

    public Client(string fName, string lName, string mail, string dob, string passport, string passwd, string phone, string status)
    {
        firstName = fName;
        lastName = lName;
        email = mail;
        age = dob;
        passportNum = passport;
        password = passwd;
        phoneNum = phone;
        maritualStatus = status;
    }

    // Validation at the level of getters and setters
    
    public string FirstName
    {
        get => firstName ?? string.Empty;
        init => firstName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string LastName
    {
        get => lastName ?? string.Empty;
        init => lastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string Email
    {
        get => email ?? string.Empty;
        init => email = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string Age
    {
        get => age ?? string.Empty;
        init => age = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string PassportNum
    {
        get => passportNum ?? string.Empty;
        init => passportNum = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string PhoneNum
    { 
        get => phoneNum ?? string.Empty;
        init => phoneNum = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string Password
    {
        get => password ?? string.Empty;
        init => password = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string MaritualStatus
    {
        get => maritualStatus ?? string.Empty;
        init => maritualStatus = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
}