using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Data.Entity;

namespace AngularTest.Controllers
{
    public class MenuItemController : ApiController
    {
        /*List<Models.MenuItem> MenuItems;
        public MenuItemController()
        {
            MenuItems = new List<Models.MenuItem>();

            Models.MenuItem tempItem = new Models.MenuItem();
            tempItem.ID = "1";
            tempItem.Name = "Hamburger";
            tempItem.Price = 1.00m;
            tempItem.Cost = 0.40m;
            tempItem.ImageURL = "";
            MenuItems.Add(tempItem);

            tempItem = new Models.MenuItem();
            tempItem.ID = "2";
            tempItem.Name = "Cheeseburger";
            tempItem.Price = 1.50m;
            tempItem.Cost = 0.60m;
            tempItem.ImageURL = "";
            MenuItems.Add(tempItem);

            tempItem = new Models.MenuItem();
            tempItem.ID = "3";
            tempItem.Name = "Small French Fry";
            tempItem.Price = 1.00m;
            tempItem.Cost = 0.20m;
            tempItem.ImageURL = "";
            MenuItems.Add(tempItem);
        }
        [System.Web.Http.AcceptVerbs("GET")]
        public Models.MenuItem GetMenuItem([FromUri]int id)
        {
            return MenuItems[id];
        }
        [System.Web.Http.AcceptVerbs("GET")]
        public List<Models.MenuItem> GetMenuItems()
        {
            return MenuItems;
        }*/
        [System.Web.Http.AcceptVerbs("GET")]
        public DbSet<MenuItem> GetMenuItems()
        {
            RestaurantManagementSystem db = new RestaurantManagementSystem();
            return db.MenuItems;
        }
        [System.Web.Http.AcceptVerbs("POST")]
        public void AddMenuItem(MenuItem menuItem)
        {
            RestaurantManagementSystem db = new RestaurantManagementSystem();
            db.MenuItems.Add(menuItem);
            db.SaveChanges();
        }
        
    }
}