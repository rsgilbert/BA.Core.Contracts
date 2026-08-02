using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BA.Core.Contracts.Enums;

namespace BA.Core.Contracts.UI;


public class PageOrderDto 
{
  
    public required string FieldName { get; set; }


    public required SortOrder SortOrder { get; set; }


 
}