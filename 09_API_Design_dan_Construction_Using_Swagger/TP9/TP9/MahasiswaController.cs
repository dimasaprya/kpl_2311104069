using Microsoft.AspNetCore.Mvc;
using tpmodul9_2311104074.Models;

namespace tpmodul9_2311104074.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Fahmi Hasan Asagaf", Nim = "2311104074" },
            new Mahasiswa { Nama = "Laila", Nim = "C0B023745" },
            new Mahasiswa { Nama = "Faishal", Nim = "2311104066" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Mahasiswa tidak ditemukan");
            return mahasiswaList[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
            return Ok("Mahasiswa berhasil ditambahkan");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak valid");

            mahasiswaList.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus");
        }
    }
}
