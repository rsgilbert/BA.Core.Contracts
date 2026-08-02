using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums;


public enum LabRequestStatus
{

    Booked,


    Assigned,


    Collected,

    [Display(Name = "Received At Lab")]
    ReceivedAtLab,

    [Display(Name = "In Analysis")]
    InAnalysis,

    [Display(Name = "Results Ready")]
    ResultsReady,


    Delivered,

    Canceled
}