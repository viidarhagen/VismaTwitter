namespace VismaTwitter.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Models;

    public class ItemController : Controller
    {
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            var items = await DocumentDBRepository<Item>.GetItemsAsync(d => d.TranslatedText!="",d=> d.ts);
            return View(items);
        }



        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id, string category)
        {
            Item item = await DocumentDBRepository<Item>.GetItemAsync(id, category);
            return View(item);
        }
    }
}