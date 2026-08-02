using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BA.Core.Contracts.Enums;
namespace BA.Core.Contracts.UI;


public class ProfileItemItemDto
{
    public required string Name { get; set; }

    public string? Caption { get; set; }


    // this is the PageId the item links to
    public int? PageId { get; set; }




    public List<ProfileItemItemDto>? Items { get; set; }




}