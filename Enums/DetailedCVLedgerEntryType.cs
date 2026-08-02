using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums;


public enum DetailedCVLedgerEntryType
{
    None,

    [Display(Name = "Initial Entry")]
    InitialEntry,
    Application,

    [Display(Name = "Unrealised Loss")]
    UnrealisedLoss,

    [Display(Name = "Unrealised Gain")]
    UnrealisedGain,

    [Display(Name = "Realised Loss")]
    RealisedLoss,

    [Display(Name = "Realised Gain")]
    RealisedGain
}