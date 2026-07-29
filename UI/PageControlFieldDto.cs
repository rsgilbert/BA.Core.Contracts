
namespace Contracts.UI;



public class PageControlFieldDto 
{
   

    public required string Name { get; set; }

    public string? Caption { get; set; }

    public bool? Editable { get; set; } 

    public bool? Visible { get; set; } 
    

     public int DrillDownPageId { get; set; }

  
    public bool Required { get; set; }

    public int Size { get; set; } 


    public bool ShowMandatory { get;set; }




}