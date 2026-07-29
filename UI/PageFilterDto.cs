using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Contracts.Enums;

namespace Contracts.UI;



public class PageFilterDto 
{
 


    public required string FieldName { get; set; }


    public FilterOperator Operator { get; set; }


    public required string Value { get; set; }


}