using Microsoft.AspNetCore.Mvc;

namespace DineApp.CustomControls
{
    [ViewComponent(Name ="ViewCard")]
    public class ViewCardViewComponent:ViewComponent
    {
        public ViewCardViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View("ViewCard"));
        }
    }
}
