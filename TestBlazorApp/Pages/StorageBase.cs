using Microsoft.AspNetCore.Components;

namespace TestBlazorApp.Pages
{

    public class StorageBase<TItem> : ComponentBase
    {

        [Parameter]
        public TItem Items { get; set; }

        [Parameter]
        public EventCallback<TItem> ItemsChanged { get; set; }

    }

}