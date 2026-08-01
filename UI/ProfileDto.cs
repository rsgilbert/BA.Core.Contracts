using System.ComponentModel.DataAnnotations;
namespace Contracts.UI;


public class ProfileDto
{


    public required int Id { get; set; }


      public int? RoleCenterId { get; set; }


    public required string Name { get; set; }


    public string? Caption { get; set; }



    [MinLength(1)]
    public required List<ProfileItemDto> Items { get; set; }






}

