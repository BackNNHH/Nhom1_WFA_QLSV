using MaterialSkin;
using MaterialSkin.Controls;
using Nhom1_WFA_QLSV;

public class BaseMaterialForm : MaterialForm
{
    protected readonly MaterialSkinManager materialSkinManager;

    public BaseMaterialForm()
    {
        materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.DeepOrange700, TextShade.WHITE);

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
