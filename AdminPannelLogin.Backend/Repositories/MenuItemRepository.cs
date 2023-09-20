using AdminPannelLogin.Backend.Context;
using AdminPannelLogin.Backend.Entities;

namespace AdminPannelLogin.Backend.Repositories;

public interface IMenuItemRepository
{
    public List<MenuItem> GetAll();
    public MenuItem GetById(int id);
    public MenuItem Update(MenuItem itemToUpdate);
    public MenuItem Create(MenuItem menuItem);


}

public class MenuItemRepository : IMenuItemRepository
{
    
    private readonly DataContext _context;

    public MenuItemRepository(DataContext context)
    {
        _context = context;
    }
    
    public List<MenuItem> GetAll()
    {
        return _context.MenuItems.ToList();
    }

    public MenuItem Create(MenuItem menuItem)
    {
        _context.Add(menuItem);
        _context.SaveChanges();
        return menuItem;
    }

    public MenuItem Update(MenuItem itemToUpdate)
    {
        var menuItem = GetById(itemToUpdate.Id);
        menuItem.NameDe = itemToUpdate.NameDe;
        menuItem.NameEn = itemToUpdate.NameEn;
        menuItem.DescriptionDe = itemToUpdate.DescriptionDe;
        menuItem.DescriptionEn = itemToUpdate.DescriptionEn;
        menuItem.Price = itemToUpdate.Price;
        _context.SaveChanges();
        return menuItem;
    }

    public MenuItem GetById(int id)
    {
        var menuItem = _context.MenuItems.First(item => item.Id == id);
        return menuItem;
    }
}