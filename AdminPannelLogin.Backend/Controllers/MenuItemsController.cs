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

        foreach (var menuitem in menuItems)
        {
            menuItemViewModels.Add(new MenuItemViewModel
            {
                Id = menuitem.Id,
                Price = menuitem.Price,
                NameDe = menuitem.NameDe,
                NameEn = menuitem.NameEn,
                DescriptionDe = menuitem.DescriptionDe,
                DescriptionEn = menuitem.DescriptionEn
            });
        }
        return menuItemViewModels;
    }
}