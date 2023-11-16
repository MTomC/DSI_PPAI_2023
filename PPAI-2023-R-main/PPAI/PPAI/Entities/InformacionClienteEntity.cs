namespace PPAI.Entities {
    public class InformacionClienteEntity {
        private string datoAValidar;
        private OpcionValidacionEntity opcionCorrecta = new OpcionValidacionEntity();
        private ValidacionEntity validacion = new ValidacionEntity();
        private string tipo;
        private int id;

        public string DatoAValidar { get => datoAValidar; set => datoAValidar = value; }
        public OpcionValidacionEntity OpcionCorrecta { get => opcionCorrecta; set => opcionCorrecta = value; }
        public ValidacionEntity Validacion { get => validacion; set => validacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }

        public bool EsValidacion(ValidacionEntity validacion) {
            return DatoAValidar == validacion.Nombre;
        }

        public bool EsInfoCorrecta(string respuesta) {
            return OpcionCorrecta.Correcta == respuesta;
        }
    }
}
