using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Contracts.Enums;
namespace Contracts.UI;


public class ProfileItemDto
{
    public int? PageId { get; set; }

    public required string Name { get; set; }


    public string? Caption { get; set; }


    public string? ImageIcon { get; set; }


    public List<ProfileItemItemDto>? Items { get; set; }


}