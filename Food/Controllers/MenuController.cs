
using Food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        List<Menu> foods = new List<Menu>
        {
            new Menu("Pizza", 9.99f, "12in Pizza with your choice of toppings", "https://img.freepik.com/free-photo/top-view-pepperoni-pizza-with-mushroom-sausages-bell-pepper-olive-corn-black-wooden_141793-2158.jpg?w=826&t=st=1698283547~exp=1698284147~hmac=07c10aef44d07390fc6052e134ba84d3867637c025c2d51ff83721e03894d741"),
            new Menu("Cheeseburger", 8.99f, "Hamburger with a slice of melted cheese on top of the meat patty", "https://hips.hearstapps.com/hmg-prod/images/best-ever-burger-index-646e5ae887b2b.jpg"),
            new Menu("French Fries", 3.49f, "Everyone knows what French Fries are", "https://images.themodernproper.com/billowy-turkey/production/posts/2022/Homemade-French-Fries_8.jpg?w=800&q=82&fm=jpg&fit=crop&dm=1662474181&s=76f4dc7a5af1958d255ce8559579a6f2"),
            new Menu("Hamburger", 7.99f, "Burger with no cheese", "https://www.allrecipes.com/thmb/3x-XkV8T36df_M4tkoDbaD-WmJs=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/49404-juiciest-hamburgers-ever-DDMFS-4x3-86fc27c741dd410aa365f96490c54060.jpg"),
            new Menu("Breadsticks", 4.99f, "6pc Bread Sticks", "https://sugarspunrun.com/wp-content/uploads/2021/09/Homemade-Breadsticks-Recipe-1-of-1.jpg"),
            new Menu("Steak Sub", 7.99f, "8in Steak and Cheese sub made from thinly sliced pieces of beefsteak and melted cheese in a hoagie roll", "https://www.spendwithpennies.com/wp-content/uploads/2022/06/Philly-Cheesesteaks-SpendWithPennies-7.jpg"),
            new Menu("Chicken Sub", 6.99f, "8in Chicken sub with lettuce and tomato", "https://thestayathomechef.com/wp-content/uploads/2016/02/Buffalo2BChicken2BSubs2B1.jpg"),
            new Menu("Turkey Sub", 7.49f, "8in Turkey sub with swiss cheese, lettuce and tomato", "https://www.mccormick.com/-/media/project/oneweb/mccormick-us/frenchs/recipes/h/800x800/ham_and_turkey_sub_with_creamy_yellow_mustard_spread_17758_800x800.jpg?rev=3146787bdcec4ca38ea555dcbf57eac3&vd=20220114T211717Z&hash=57EDD25AA0906A9A44089297A9373822"),
        };

        [HttpGet("getFoods")]
        public List<Menu> GetFoods()
        {
            return foods.ToList();
        }

        [HttpGet("{name}")]
        public Menu GetByName(string name)
        {
            return foods.FirstOrDefault(f => f.Name.ToLower().Contains(name.ToLower().Trim()));
        }

        [HttpDelete("{name}")]
        public Menu DeleteById(string name)
        {
            Menu delete = foods.FirstOrDefault(x => x.Name == name);
            foods.Remove(delete);

            return delete;
        }

        
    }
}
