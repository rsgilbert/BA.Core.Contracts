using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums
{
    public enum GLAccountType
    {
        [Display(Name = "Posting")]
        Posting,
        Heading,
        Total,

        [Display(Name = "Begin Total")]
        BeginTotal,

        [Display(Name = "End Total")]
        EndTotal
    }

}