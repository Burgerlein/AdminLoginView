using AdminPannelLogin.Backend.Entities;
using AdminPannelLogin.Backend.Repositories;
using AdminPannelLogin.Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AdminPannelLogin.Backend.Controllers;

[Controller]
[Route("api/[controller]")]
public class MenuItemsController : ControllerBase
{
    private readonly IMenuItemRepository _menuItemRepository;

    public MenuItemsController(IMenuItemRepository menuItemRepository)
    {
        _menuItemRepository = menuItemRepository;
    }

    [HttpGet]
    public List<MenuItemViewModel> GetMenuList()
    {
        var menuItems = _menuItemRepository.GetAll();
        var menuItemViewModels = new List<MenuItemViewModel>();

        foreach (var menuItem in menuItems)
            menuItemViewModels.Add(new MenuItemViewModel(menuItem));

        return menuItemViewModels;
    }

    [HttpGet("{id:int}")]
    public MenuItemViewModel GetById(int id)
    {
        var menuItem = _menuItemRepository.GetById(id);
        return new MenuItemViewModel(menuItem);
    }

    [HttpPost("create")]
    public void Create(MenuItem sendetValue)
    {
        var createMenuItem = _menuItemRepository.Create(sendetValue);
    }
}
