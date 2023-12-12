using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
            {
                new VillaDTO{CreatedDate=DateTime.Now,Id=1,Name="Pool View"},
                new VillaDTO{CreatedDate=DateTime.Now,Id=2,Name="Beach View"}
            };
    }
}
