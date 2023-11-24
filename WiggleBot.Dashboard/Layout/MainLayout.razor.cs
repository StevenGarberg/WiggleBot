using WiggleBot.Dashboard.Services;

namespace WiggleBot.Dashboard.Layout;

public partial class MainLayout : LayoutComponentBase, IDisposable
{
    [Inject] public ISettingsService SettingsService { get; set; }
    
    private bool _drawerOpen = true;
    private bool _isDarkMode = true;

    protected override async Task OnInitializedAsync()
    {
        _drawerOpen = await SettingsService.GetDrawerOpenAsync();
        _isDarkMode = await SettingsService.GetUseDarkModeAsync();
        
        SettingsService.DrawerOpened += OnDrawerOpened;
        SettingsService.DarkModeToggled += OnDarkModeToggled;
    }
    
    private async Task ToggleDrawerOpened()
    {
        _drawerOpen = !_drawerOpen;
        await SettingsService.SetDrawerOpenAsync(_drawerOpen);
    }
    
    private async Task ToggleDarkMode()
    {
        _isDarkMode = !_isDarkMode;
        await SettingsService.SetUseDarkModeAsync(_isDarkMode);
    }
    
    private async void OnDrawerOpened(object sender, EventArgs e)
    {
        _drawerOpen = await SettingsService.GetDrawerOpenAsync();
        await InvokeAsync(StateHasChanged);
    }
    
    private async void OnDarkModeToggled(object sender, EventArgs e)
    {
        _drawerOpen = await SettingsService.GetDrawerOpenAsync();
        await InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        SettingsService.DrawerOpened -= OnDrawerOpened;
        SettingsService.DarkModeToggled -= OnDarkModeToggled;
    }
}