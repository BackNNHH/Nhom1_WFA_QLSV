using MaterialSkin;
using MaterialSkin.Controls;

public static class ThemeManager
{
    private static readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
    public static bool IsDarkMode { get; private set; } = false;

    static ThemeManager()
    {
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
    }

    public static void ApplyThemeToAllForms()
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form is MaterialForm materialForm)
            {
                materialSkinManager.AddFormToManage(materialForm);
                materialSkinManager.Theme = IsDarkMode ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            }
        }
    }

    public static void ToggleTheme()
    {
        IsDarkMode = !IsDarkMode;
        ApplyThemeToAllForms();
    }


}
