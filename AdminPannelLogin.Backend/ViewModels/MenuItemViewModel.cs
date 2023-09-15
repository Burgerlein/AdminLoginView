namespace AdminPannelLogin.Backend.ViewModels;

public class MenuItemViewModel
{
    public int Id { get; set; }
    
    public double Price { get; set;}
    
    public string NameDe { get; set; }
    
    public string? NameEn{ get; set; }

    public string? DescriptionDe { get; set; }

    public string? DescriptionEn { get; set; }
}