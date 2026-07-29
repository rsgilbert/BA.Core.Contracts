namespace Contracts.UI;


public class PublishRequestDto
{
    public required List<PageDto> Pages { get;set; }

    public required List<ProfileDto> Profiles { get;set; }
}