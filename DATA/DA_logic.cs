using TEC_AL_0002.Models;

namespace TEC_AL_0002.DATA
{
	public class DA_logic
	{
		public List<Usuario> ListaUsuario()
		{
			// Agregar esto a una tabla SQL SERVER y Encriptar las contraseñas.
			return new List<Usuario>
			{
				new Usuario {Nombre="alice", Correo="alice", Clave="1234", Roles= new string[]{"Administrador"} },
				new Usuario {Nombre="maria", Correo="supervisor@tiendasdaka.com", Clave="123", Roles= new string[]{"Supervisor"} },
				new Usuario {Nombre="maria", Correo="@maria", Clave="123", Roles= new string[]{"Empleado"} },
				new Usuario {Nombre="oscar", Correo="oscar@tiendasdaka.com", Clave="123", Roles= new string[]{"Empleado"} },
                new Usuario {Nombre="giovanni", Correo="g.moffa@tiendasdaka.com", Clave="Daka000027102022*", Roles= new string[]{ "Administrador" } },
                new Usuario {Nombre="Dilan", Correo="d.marcano@tiendasdaka.com", Clave="0000", Roles= new string[]{ "Administrador" } },

				// Usuarios de Control y gestión.
                new Usuario {Nombre="Luis", Correo="l.dominguez@tiendasdaka.com", Clave="Daka321.", Roles= new string[]{ "Administrador" } },
                new Usuario {Nombre="Maria", Correo="m.gomez@tiendasdaka.com", Clave="Daka321.", Roles= new string[]{ "Empleado" } }
            };
		}

		public Usuario ValidarUsuario(string _correo, string _clave) 
		{
            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
		}
	}
}
