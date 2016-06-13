using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public abstract class NotificadorBase
    {
        public abstract void Notificar(string message);
    }

    public class NotificadorEmail : NotificadorBase
    {
        public override void Notificar(string message)
        {
            Console.WriteLine("Email enviado");
        }
    }

    public class NotificadorSMS : NotificadorBase
    {
        public override void Notificar(string message)
        {
            Console.WriteLine("SMS Enviado");
        }
    }

    public class UsuarioManager
    {
        public NotificadorBase Notificador { get; set; }

        public void CriarUsuario(string name, string email)
        {
            Notificador.Notificar("Usuario criado com sucesso");
        }

        public void MudarSenha(int password, int newPassword)
        { 
            Notificador.Notificar("Senha modificada com sucesso");
        }
    }
   
}
