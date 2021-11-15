using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2L2A1
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        public Usuario()
        {

        }



        public void Registro(ref List<Usuario> usuarios, string Nom, string Ape, string Ema, string Sex, string Use, string Passw)
        {
            usuarios.Add(new Usuario() { Nombre = Nom, Apellido = Ape, Email = Ema, Sexo = Sex, User = Use, Pass = Passw, });
        }
        public bool Login(ref List<Usuario> usuarios, string Use, string Passw)
        {
            bool flag = false;
            foreach (var usuario in usuarios)
            {
                if (usuario.User.Equals(Use) && usuario.Pass.Equals(Passw))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                return flag;
            }
            else
            {
                return flag;
            }
        }
    }
}
