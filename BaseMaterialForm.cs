using MaterialSkin;
using MaterialSkin.Controls;
using Nhom1_WFA_QLSV;

public class BaseMaterialForm : MaterialForm
{
    protected readonly MaterialSkinManager materialSkinManager;

    private static List<BaseMaterialForm> openForms = new List<BaseMaterialForm>();

    public static IEnumerable<BaseMaterialForm> OpenForms => openForms; // Truy xuất danh sách form mở

    List<BaseMaterialForm> openFormsCopy = BaseMaterialForm.OpenForms.ToList();

    public BaseMaterialForm()
    {
        materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        ApplyTheme();
        openForms.Add(this); // Thêm form vào danh sách khi khởi tạo
        this.FormClosed += (s, e) => openForms.Remove(this); // Xóa khi đóng
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
