using MaterialSkin;
using MaterialSkin.Controls;

public class BaseMaterialForm : MaterialForm
{
    protected readonly MaterialSkinManager materialSkinManager;

    public BaseMaterialForm()
    {
        materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        ApplyTheme();
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        ApplyTheme(); // Áp dụng lại theme khi form được mở
    }

    protected void ApplyTheme()
    {
        materialSkinManager.Theme = ThemeManager.IsDarkMode ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
    }
}
