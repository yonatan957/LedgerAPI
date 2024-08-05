using static LedgerAPI.Models.DtoUser;

namespace LedgerAPI.Models
{
    public class LedgerDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<UserDto> Users { get; set; } = new List<UserDto>();
    }
}