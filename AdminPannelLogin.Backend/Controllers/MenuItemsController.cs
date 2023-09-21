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

    [HttpPost]
    public MenuItemViewModel Create([FromBody] MenuItem menuItem)
    {
        var createdMenuItem = _menuItemRepository.Create(menuItem);
        return new MenuItemViewModel(createdMenuItem);
    }
    
    [HttpPut]
    public MenuItemViewModel Update([FromBody] MenuItem menuItem)    
    {
        var updateMenuItem = _menuItemRepository.Update(menuItem);
        return new MenuItemViewModel(updateMenuItem);
    }
}
