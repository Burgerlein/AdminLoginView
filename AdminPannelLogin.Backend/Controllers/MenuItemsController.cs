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

        for (var i = 0; menuItems.Count > i; i++)
        {
            var menuItemViewModel = new MenuItemViewModel();

            menuItemViewModel.Id = menuItems[i].Id;
            menuItemViewModel.Price = menuItems[i].Price;
            menuItemViewModel.NameDe = menuItems[i].NameDe;
            menuItemViewModel.NameEn = menuItems[i].NameEn;
            menuItemViewModel.DescriptionDe = menuItems[i].DescriptionDe;
            menuItemViewModel.DescriptionEn = menuItems[i].DescriptionEn;

            menuItemViewModels.Add(menuItemViewModel);
        }

        return menuItemViewModels;
    }
}