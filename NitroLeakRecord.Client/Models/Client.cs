using System.ComponentModel.DataAnnotations;

namespace NitroLeakRecord.Client.Models;

public class Client
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public required string LastName { get; set; }

    [Required]
    [StringLength(150)]
    public required string Email { get; set; }

    [Required]
    [StringLength(5)]
    public required string Gender { get; set; }

    [Range(1, 100)]
    public required decimal Wallet { get; set; }

    public required DateTime DateOfBirth { get; set; }
}