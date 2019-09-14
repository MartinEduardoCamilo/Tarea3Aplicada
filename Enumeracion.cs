using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    public class Enumeracion
    {
        private enum Neumaticos
        {
            Neumáticos_Anchos,
            NeumáticosXL,
            NeumáticosUsados,
            NeumáticosVerano,
            NeumáticosInvierno,
            NeumáticosTodoTerreno
        };

        public string AsignarValoresEImprimir(int valor)
        {
            Neumaticos MiNeumatico;


            switch (valor)
            {
                case 0:
                    MiNeumatico = Neumaticos.Neumáticos_Anchos;
                    return MiNeumatico.ToString();
                    
                case 1:
                    MiNeumatico = Neumaticos.NeumáticosUsados;
                    return MiNeumatico.ToString();
                    
                case 2:
                    MiNeumatico = Neumaticos.NeumáticosVerano;
                    return MiNeumatico.ToString();
                    
                case 3:
                    break;
                case 4:
                    MiNeumatico = Neumaticos.NeumáticosTodoTerreno;
                    return MiNeumatico.ToString();
                    
                case 5:
                    MiNeumatico = Neumaticos.NeumáticosInvierno;
                    return MiNeumatico.ToString();
                    
                default:

                    break;
            }
            return null;
        }
    }
}
