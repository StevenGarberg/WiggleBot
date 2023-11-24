using Blazored.LocalStorage;

namespace WiggleBot.Dashboard.Services;

public interface ISettingsService
{
    Task<bool> GetDrawerOpenAsync();
    Task SetDrawerOpenAsync(bool value);
    event EventHandler DrawerOpened;
    
    Task<bool> GetUseDarkModeAsync();
    Task SetUseDarkModeAsync(bool value);
    event EventHandler DarkModeToggled;
}

public class SettingsService : ISettingsService
{
    private readonly ILocalStorageService _localStorage;

    public SettingsService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    private const string DrawerOpenKey = "Settings:DrawerOpen";
    private static bool? _drawerOpenMenu;
    
    private const string UseDarkModeKey = "Settings:DarkMode";
    private static bool? _useDarkMode;
        
    public event EventHandler DrawerOpened;
    public event EventHandler DarkModeToggled;
        
    public async Task<bool> GetDrawerOpenAsync()
    {
        if (_drawerOpenMenu != null)
            return _drawerOpenMenu.Value;

        if (await _localStorage.ContainKeyAsync(DrawerOpenKey))
            _drawerOpenMenu = await _localStorage.GetItemAsync<bool>(DrawerOpenKey);
        else
            _drawerOpenMenu = true;
                
        return _drawerOpenMenu.Value;
    }
        
    public async Task SetDrawerOpenAsync(bool value)
    {
        _drawerOpenMenu = value;
        await _localStorage.SetItemAsync(DrawerOpenKey, value);
        DrawerOpened?.Invoke(this, EventArgs.Empty);
    }
    
    public async Task<bool> GetUseDarkModeAsync()
    {
        if (_useDarkMode != null)
            return _useDarkMode.Value;

        if (await _localStorage.ContainKeyAsync(UseDarkModeKey))
            _useDarkMode = await _localStorage.GetItemAsync<bool>(UseDarkModeKey);
        else
            _useDarkMode = true;
                
        return _useDarkMode.Value;
    }
    
    public async Task SetUseDarkModeAsync(bool value)
    {
        _useDarkMode = value;
        await _localStorage.SetItemAsync(UseDarkModeKey, value);
        DarkModeToggled?.Invoke(this, EventArgs.Empty);
    }
}