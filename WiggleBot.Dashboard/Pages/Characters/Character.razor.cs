using MediatR;
using WiggleBot.Dashboard.Requests;
using WiggleBot.Models.RaiderIO;

namespace WiggleBot.Dashboard.Pages.Characters;

public partial class Character : ComponentBase
{
    [Parameter] public string RealmName { get; set; }
    [Parameter] public string CharacterName { get; set; }
    [Inject] public IMediator Mediator { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }
    
    private CharacterProfile CharacterProfile { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        CharacterProfile = await Mediator.Send(new GetCharacterProfileQuery(RealmName, CharacterName));
        
        if (CharacterProfile == null)
            NavigationManager.NavigateTo("/");
    }
}