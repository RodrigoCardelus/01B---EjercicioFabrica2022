using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaArticulo : ILogicaArticulo
    {
        //Singleton 
        //1)atributo privado de clase que me permite almacenar mis objetos
        //en este caso sera un solo objeto (singleton puro)
        //inicializo en null, porque asi optimizo: hasta que alguien necesite un objeto mio,
        //no lo creo - optimizo memoria 
        private static LogicaArticulo _instancia = null;


        //2)Constructor privado, no permite que nadie pueda crear objetos de la clase, solo yo
        //como no necesito nada... genero constructor vacio

        private LogicaArticulo() { }


        //3)mecanismo para obtener un objeto de la Clase
        public static LogicaArticulo GetInstancia()
        {

            if (_instancia == null) // no hay objeto.....
                _instancia = new LogicaArticulo(); // creo uno, yo puedo por ser la clase

            return _instancia;

        }
        //fin Singleton


        public void AgregarArticulo(Articulo A)
        {
            FabricaPersistencia.getPersistenciaArticulo().AgregarArticulo(A);
        }

        public Articulo BuscarArticulo(int pCodigo)
        {
            return (FabricaPersistencia.getPersistenciaArticulo().BuscarArticulo(pCodigo));
        }

        public void EliminarArticulo(Articulo A)
        {
            FabricaPersistencia.getPersistenciaArticulo().ModificarArticulo(A);
        }

        public List<Articulo> ListarArticulo()
        {
            return (FabricaPersistencia.getPersistenciaArticulo().ListarArticulo());
        }

        public void ModificarArticulo(Articulo A)
        {
            FabricaPersistencia.getPersistenciaArticulo().ModificarArticulo(A);
        }
    }
}
