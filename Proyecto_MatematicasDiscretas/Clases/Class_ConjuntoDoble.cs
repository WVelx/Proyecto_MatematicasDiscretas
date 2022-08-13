using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MatematicasDiscretas.Clases
{
    public class Class_ConjuntoDoble : Class_Conjunto
    {
        public HashSet<string> conjuntoA;
        public HashSet<string> conjuntoB;

        //Constructor       
        public Class_ConjuntoDoble(HashSet<string> pConjuntoA, HashSet<string> pConjuntoB) : base(pConjuntoA, pConjuntoB)
        {
            this.conjuntoA = pConjuntoA;
            this.conjuntoB = pConjuntoB;
        }

        public override HashSet<string> operarUnion()
        {
            HashSet<string> unionAB = new HashSet<string>(this.conjuntoA);
            unionAB.UnionWith(this.conjuntoB);
            return unionAB;
        }

        public override HashSet<string> operarInterseccion()
        {
            HashSet<string> interseccionAB = new HashSet<string>(this.conjuntoA);
            interseccionAB.IntersectWith(this.conjuntoB);
            return interseccionAB;
        }

        public override HashSet<string> operarDiferenciaAB()
        {
            HashSet<string> diferenciaAB = new HashSet<string>(this.conjuntoA);
            diferenciaAB.ExceptWith(this.conjuntoB);
            return diferenciaAB;
        }

        public HashSet<string> operarDiferenciaBA()
        {
            HashSet<string> diferenciaBA = new HashSet<string>(this.conjuntoB);
            diferenciaBA.ExceptWith(conjuntoA);
            return diferenciaBA;
        }

        public override HashSet<string> operarDiferenciaSimetrica()
        {
            HashSet<string> diferenciaSimetrica = new HashSet<string>(this.conjuntoA);
            diferenciaSimetrica.SymmetricExceptWith(this.conjuntoB);
            return diferenciaSimetrica;
        }
    }
}
