using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Contracts.Enums;
namespace Contracts.UI;


public class ProfileItemDto
{
    // This is the PageId of the Page referenced by the ProfileItem and its optional.
    // Its optional when the ProfileItem is a Group
    public int? PageId { get; set; }

    public required string Name { get; set; }


    public string? Caption { get; set; }


    public string? ImageIcon { get; set; }


    public List<ProfileItemItemDto>? Items { get; set; }


}