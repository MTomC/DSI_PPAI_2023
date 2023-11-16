namespace PPAI.Entities
{
    // Inheritance class {State}
    public class EstadoFinalizada : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoFinalizada()); }

        // Constructor
        private EstadoFinalizada()
        {
            Id = 3;
            Nombre = "Finalizada";
            Ambito = "Llamada";
        }


        
        // Override methods
        public override bool EsFinalizada() { return true; }

    }
}