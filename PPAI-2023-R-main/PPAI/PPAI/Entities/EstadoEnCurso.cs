

namespace PPAI.Entities
{
    // Inheritance class {State}
    public class EstadoEnCurso : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoEnCurso()); }
        
        // Constructor
        private EstadoEnCurso()
        {
            
        }




        // Overriding boolean method {State}
        public override bool EsEnCurso() { return true; }
        
    }
}