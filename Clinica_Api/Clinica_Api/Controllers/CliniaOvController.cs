using Clinica_Api.Data;
using Clinica_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Imaging;
using Image = System.Drawing.Image;
using Clinica_Api.Modelss;

namespace Clinica_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CliniaOvController : ControllerBase
    {
        private readonly DbOliveraClinicaContext _context;

        public CliniaOvController(DbOliveraClinicaContext context)
        {
            _context = context;
        }


        [HttpGet("CliniaOvController/MostrarTexto")]
        public IActionResult MostrarTexto()
        {
            var contenido = _context.PacientesInformacionGenerals.Take(10).ToList();

            return Ok(contenido);
        }

        [HttpGet("CliniaOvController/UsuarioMasactual")]
        public IActionResult MostrarTexto1()
        {
            var contenido = _context.PacientesInformacionGenerals.OrderByDescending(x => x.FechaConsulta).FirstOrDefault();

            return Ok(contenido);
        }


        [HttpGet("CliniaOvController/GetPacientes")]
        public IActionResult GetPacientes()
        {
            var contenido = _context.PacientesInformacionGenerals.Where(x=>x.Clave==429).OrderByDescending(x => x.FechaConsulta).Take(20);

            return Ok(contenido);
        }

        [HttpGet("CliniaOvController/GetPacienteId/{id:int}")]
        public IActionResult GetPacienteId(int id)
        {
            var contenido = _context.PacientesInformacionGenerals.Where(x => x.Clave==id).FirstOrDefault();

            return Ok(contenido);
        } 

        [HttpGet("CliniaOvController/GetImagenesPaciente/{id:int}")]
        public IActionResult GetImagenesPaciente(int id)
        {
            List<Imagene> blobData = _context.Imagenes.Where(x=>x.Id==id).ToList();
            //int i = 0;
            //if (blobData != null)
            //{
            //    //var id = blobData.Id.ToString();
            //    //byte[] blob = blobData.BlobData as byte[];

            //    //if (blob != null)
            //    //{
            //        //    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // Obtiene el directorio base de la aplicaci�n
            //        //    string imagesDirectory = Path.Combine(baseDirectory, "Imagenes"); // Construye el path hacia la carpeta Imagenes

            //        //    Asegur�ndose de que el directorio existe
            //        //    if (!Directory.Exists(imagesDirectory))
            //        //    {
            //        //        Directory.CreateDirectory(imagesDirectory); // Crea el directorio si no existe
            //        //    }

            //        //    Formando el path final donde se guardar� la imagen, incluyendo el nombre del archivo
            //        //    string filePath = Path.Combine(imagesDirectory, $"imagen_{id}.jpg");

            //        //    Especifica el tipo MIME del archivo que est�s devolviendo
            //        //    string contentType = "application/octet-stream";

            //        //    Nombre del archivo para el usuario
            //        //    string fileName = "nombre_del_archivo.ext";

            //        //    Usa el m�todo File para crear un FileContentResult con los bytes del archivo, el tipo MIME y el nombre del archivo
            //        //    File(blob, contentType, fileName);
            //        //    Console.WriteLine($"Archivo guardado: {filePath}");
            //        //}



            //        foreach (byte[] blob in blobData)
            //    {
            //        try { 
            //            using (MemoryStream ms = new MemoryStream(blob))
            //            {
            //                using (Image image = Image.FromStream(ms))
            //                {
            //                    // Guardar la imagen en disco
            //                    image.Save("output_image" + i + ".jpg", ImageFormat.Jpeg);
            //                    Console.WriteLine("La imagen ha sido guardada como 'output_image.jpg'.");
            //                i++;
            //                }
            //            }
            //            }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine("Exception in image"+i + e);
            //        }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se encontr� ning�n dato de imagen para cargar.");
            //    }
            
            return Ok(blobData);
        }

        [HttpGet("CliniaOvController/GetFotoPaciente/{id:int}")]
        public IActionResult GetFotoPaciente(int id)
        {
            List<Foto> blobData = _context.Fotos.Where(x=>x.Id==id).ToList();            
            return Ok(blobData);
        }

        [HttpGet("CliniaOvController/GetHistoriaPaciente/{id:int}")]
        public IActionResult GetHistoriaPaciente(int id)
        {
            Expediente historia = _context.Expedientes.Where(x => x.Clave == id).First();
            return Ok(historia);
        }

        [HttpPost("CliniaOvController/PostPaciente")]
        public IActionResult PostPaciente([FromBody] PacientesInformacionGeneral paciente)
        {
            PacientesInformacionGeneral informacionpaciente = _context.PacientesInformacionGenerals.FirstOrDefault(x => x.Clave == paciente.Clave);
            if (informacionpaciente == null)
            {
                return NotFound();
            }
            informacionpaciente = paciente;
            // Guarda los cambios en la base de datos.
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir durante el guardado.
                return StatusCode(500, "No se pudo guardar la informaci�n del paciente. Error: " + ex.Message);
            }

            return Ok(informacionpaciente);
        }

        private static byte[] HexStringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

    }
}