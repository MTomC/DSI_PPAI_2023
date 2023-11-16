namespace PPAI.Entities {
    public class OpcionValidacionEntity {
        private string correcta;
        private string descripcion;
        private int id;

        public string Correcta { get => correcta; set => correcta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id { get => id; set => id = value; }
    }
}
