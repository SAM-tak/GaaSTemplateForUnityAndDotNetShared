#nullable disable
using System.ComponentModel.DataAnnotations;

namespace YourGameServer.Interface // Unity cannot accpect 'namespace YourProjectName.Interface;' yet
{
    public enum ServiceTicketKind
    {
        [Display(Name = "Loot Box")]
        LootBox,
        [Display(Name = "Foo Bar")]
        FooBar,
    }
}
