using Microsoft.AspNetCore.Mvc;

namespace SonDeneme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ogrenciController : ControllerBase
    {
        private static readonly string[] isimler = new[]
       { "Sümeyye", "Feyza", "Ali"
        };

        private static readonly string[] soyisimler = new[]
       { "Ayten", "Ercan", "Ayten"
        };

        private readonly ILogger<ogrenciController> _logger;

        public ogrenciController(ILogger<ogrenciController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOgrenci")]
        public IEnumerable<ogrenci> Get()
        {
            List<ogrenci> ogrenciler = new List<ogrenci>();
            ogrenciler.Add(new ogrenci
            {
                OgrenciAd = isimler[0],
                OgrenciSoyad = soyisimler[0],
                Mail = "sumeyyeayten06@gmail.com",
                Telefon = "05331444215"

            });

            ogrenciler.Add(new ogrenci
            {
                OgrenciAd = isimler[1],
                OgrenciSoyad = soyisimler[1],
                Mail = "feyzaercan06@gmail.com",
                Telefon = "05331444215"

            });

            ogrenciler.Add(new ogrenci
            {
                OgrenciAd = isimler[2],
                OgrenciSoyad = soyisimler[2],
                Mail = "aliayten06@gmail.com",
                Telefon = "05331444215"

            });
            return ogrenciler;
        }
        [Route("get-search-list")]
        [HttpGet]
        public async Task<ActionResult<List<ogrenci>>> List(string name)
        {
            List<ogrenci> listOgrencis = new List<ogrenci> { };
            foreach (string l in isimler)
            {
                listOgrencis.Add(new ogrenci
                {
                    OgrenciAd = l,
                    OgrenciSoyad = soyisimler[2],
                    Mail = "aliayten06@gmail.com",
                    Telefon = "05331444215"
                });
            }
            var result = listOgrencis.Where(w => w.OgrenciAd.ToLower().Contains(name.ToLower()));
            return Ok(result);
        }
    }
}
