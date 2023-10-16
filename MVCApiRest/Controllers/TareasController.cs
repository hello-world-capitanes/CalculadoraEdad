using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace MVCApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TareasController : ControllerBase
    {
        private List<Tarea> tareas = new List<Tarea>
    {
        new Tarea { Id = 1, Titulo = "Completar informe", Descripcion = "Finalizar el informe para la reunión de la junta directiva." },
        new Tarea { Id = 2, Titulo = "Revisar diseño", Descripcion = "Revisar y aprobar el diseño de la interfaz de usuario." }
    };

        // GET api/tareas
        public IEnumerable<Tarea> GetTareas()
        {
            return tareas;
        }

        // GET api/tareas/1
        public IHttpActionResult GetTarea(int id)
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == id);
            if (tarea == null)
            {
                return NotFound(); // Devolver código de estado 404
            }
            return Ok(tarea);
        }

        // POST api/tareas
        public IHttpActionResult PostTarea(Tarea nuevaTarea)
        {
            nuevaTarea.Id = tareas.Max(t => t.Id) + 1;
            tareas.Add(nuevaTarea);
            return CreatedAtRoute("DefaultApi", new { id = nuevaTarea.Id }, nuevaTarea);
        }

        // PUT api/tareas/1
        public IHttpActionResult PutTarea(int id, Tarea tareaActualizada)
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == id);
            if (tarea == null)
            {
                return NotFound();
            }
            tarea.Titulo = tareaActualizada.Titulo;
            tarea.Descripcion = tareaActualizada.Descripcion;
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE api/tareas/1
        public IHttpActionResult DeleteTarea(int id)
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == id);
            if (tarea == null)
            {
                return NotFound();
            }
            tareas.Remove(tarea);
            return Ok(tarea);
        }
    }
}
