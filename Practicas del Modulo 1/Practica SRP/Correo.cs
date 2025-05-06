namespace Practica_SRP
{
    /* responsable del envio de correos electronicos
     * de esta forma si cambia como enviar correos solo
     * cambia la clase de Correo donde se encuantra la logica
     * y en las otras clases solo se llama el metodo por lo que 
     * no habra que hacer cambios en otras partes, solo en Correo
     * asegurarse de no cambiar los nombres de los metodos pues 
     * aho si dara error en las otras partes donde se hace uso de este metodo
     */
    public class Correo
    {
        public void EnviarCorreo(string destinatario, string mensaje)
        {
            Console.WriteLine($"Enviando correo a {destinatario}.");
            Console.WriteLine($"Mensaje: {mensaje}.");

        }
    }
}
