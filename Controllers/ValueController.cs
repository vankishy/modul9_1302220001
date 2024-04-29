using Microsoft.AspNetCore.Mvc;
using modul9_1302220001;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302220001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa() {nama = "Reinhard",
                          nim = "1302220001",
                          course = new List<string>{"Konstruksi Perangkat Lunak", "Pemrograman Berbasis Objek", "Basis Data"},
                          year = 2024
            },

            new Mahasiswa() {nama = "Gabrielle",
                          nim = "1302220053",
                          course = new List<string>{"Konstruksi Perangkat Lunak", "Pemrograman Berbasis Objek", "Basis Data"},
                          year = 2024
            },

            new Mahasiswa() {nama = "Rafli",
                          nim = "1302223153",
                          course = new List<string>{"Konstruksi Perangkat Lunak", "Pemrograman Berbasis Objek", "Basis Data"},
                          year = 2024
            }
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}