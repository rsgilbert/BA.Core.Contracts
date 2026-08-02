using System.ComponentModel.DataAnnotations.Schema;


namespace BA.Core.Contracts.UI;



public class SubPageFilterDto 
{

    public required string FieldName { get; set; }


    public required string RelatedFieldName { get; set; }
 
}