using System.ComponentModel.DataAnnotations;

namespace TODO.Models.Entities;

public class BaseEntity
{
    [Key]
    public string Id { get; set; }
}