using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Contracts.Enums;

namespace Contracts.UI;


public class PageOrderDto 
{
  
    public required string FieldName { get; set; }


    public required SortOrder SortOrder { get; set; }


 
}