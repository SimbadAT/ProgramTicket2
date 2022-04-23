using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProgramaTicket2.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntranceAsync();
    }
}