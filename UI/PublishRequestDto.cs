namespace BA.Core.Contracts.UI;


public class PublishRequestDto
{
    /// <summary>
    /// App id from ba.json. Groups this upload as one application.
    /// </summary>
    public Guid? Id { get; set; }

    public string? Name { get; set; }

    public string? Publisher { get; set; }

    public string? Version { get; set; }

    public string? Homepage { get; set; }

    public required List<PageDto> Pages { get; set; }

    public required List<ProfileDto> Profiles { get; set; }

    public required List<RoleCenterDto> RoleCenters { get; set; }
}