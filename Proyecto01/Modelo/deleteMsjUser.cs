using Modelo.Mensajes;
using Modelo.User;

namespace Modelo
{
    public class deleteMsjUser
    {

        public boolean mensajeDelete(Mensajes msj)
        {
            Mensajes mensaje = await _repo.GetMensajeByIdAsync(msj.MensajeId); //metodo verifica si mensaje existe

            if(mensaje == null) 
		        return false;
            boolean resp = await _repo.Delete(msj.MensajeId); // Metodo borra mensaje

            if(resp) //Verifica Borrado
            {
                BadRequest(“No se pudo borrar el mensaje”);
                return false; //Excepcion
            }
            return true;
        }

        public boolean userDelete(Users user)
        {
            Users usuario = await _repo.GetUserByIdAsync(user.UserId); //metodo verifica si usuario existe

            if(usuario == null) 
                return false;
            boolean resp = await _repo.Delete(user.UserId); //Metodo borra Usuario

            if(resp) //Verifica Borrado
            {
                 BadRequest(“No se pudo borrar el mensaje”); //Excepcion
                 return false;
            }
            return true;
        }
    }
}