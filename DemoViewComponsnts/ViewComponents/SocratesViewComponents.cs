using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Threading.Tasks;

namespace DemoViewComponsnts.ViewComponents
{
    [ViewComponent(Name = "ApresentacaoSocrates")]
    public class ApresentacaoSocratesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

    [ViewComponent(Name = "DetalhesSocrates")]
    public class DetalhesSocratesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
