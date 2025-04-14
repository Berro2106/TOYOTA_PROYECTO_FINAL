using Firebase.Database;
using Firebase.Database.Query;
using TOYOTA.Helpers;
using TOYOTA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOYOTA.Helpers
{
    class FirebaseHelper
    {
        private readonly FirebaseClient firebaseClient;

        public FirebaseHelper()
        {
            firebaseClient = new FirebaseClient("https://toyotaapp-f639b-default-rtdb.firebaseio.com/");
        }

        public async Task AddSolicitud(Solicitud solicitud)
        {
            await firebaseClient.Child("Solicitudes").PostAsync(solicitud);
        }

        public async Task<List<Solicitud>> GetAllSolicitudes()
        {
            var solicitudes = await firebaseClient.Child("Solicitudes").OnceAsync<Solicitud>();

            return solicitudes.Select(s => new Solicitud
            {
                Id = s.Key,
                Vehiculo = s.Object.Vehiculo,
                Nombre = s.Object.Nombre,
                Cedula = s.Object.Cedula,
                Telefono = s.Object.Telefono,
                Fecha = s.Object.Fecha,
                Comentarios = s.Object.Comentarios
            }).ToList();
        }
    }
}