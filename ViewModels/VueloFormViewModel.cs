using System.Collections.Generic;
using Vuelos.Models;

namespace Vuelos.ViewModels
{
    public class VueloFormViewModel
    {
        public Vuelo Vuelo { get; set; }
        public List<Vuelo> Vuelos { get; set; }

        public string Title
        {
            get
            {
                if (Vuelo != null && Vuelo.Id != 0)
                    return "Modificación";

                return "Alta";
            }
        }
        public string ButtonText
        {
            get
            {
                if (Vuelo != null && Vuelo.Id != 0)
                    return "Modicar";

                return "Guardar";
            }
        }


    }
}