using System.ComponentModel.DataAnnotations;

namespace sess09_delegates_events_and_collections;

/// <summary>
/// this class rep a basic user account with information suc as userid, username, and password. it can be used for systems requiring authentication like online accounts or POS systems
/// </summary>
public class UserAccount
{
    /// <summary>
    /// static/class variable to autogenerate unique userIDs starting from 1001
    /// </summary>
    private static long _initialID = 1001L;
    /// <summary>
    /// Retrieves the unique identifier for th user account. this property is read only and is automatically assigned during user account creation
    /// </summary>
    [Key]
    [Required]
    public long UserID { get; }

    [Required]
    public string UserName { get; set; }
    [Required]
    [MinLength(8), MaxLength(15)]
    public string Password { get; set; }

    public UserAccount(string username, string password)
    {
        this.UserName = username;
        this.Password = password;
        

    }
    /// <summary>
    /// Returns a string representation of the <see cref="UserAccount"/> object including:
    /// the userID, username, and a masked/obscured version of the account password.
    /// The password will be partially masked to ensure privacy. (Only the first and last
    /// character are visible).
    /// </summary>
    /// <returns>
    /// A string representation of the account's userid, username and masked version of the
    /// password.
    /// </returns>
    public override string ToString()
    {
        return $"User Account Details" +
            $"\n" + new string('-', 55) +
            $"\nUser ID: {this.UserID}" +
            $"\nUsername: {this.UserName}" +
            $"\nPassword: {this.Password.Remove(1, (this.Password.Length - 2)).Insert(1, "**********")}" + // Hide/obfuscate password chars.
            $"\n" + new string('-', 55);
    }

}
