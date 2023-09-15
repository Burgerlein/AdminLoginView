using AdminPannelLogin.Backend.Context;
using AdminPannelLogin.Backend.Entities;

namespace AdminPannelLogin.Backend.Repositories;

public interface IMenuItemRepository
{
    public List<MenuItem> GetAll();
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
}