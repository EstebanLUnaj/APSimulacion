using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador2019
{
	public class Cuota
	{
		//Campos de la clase Cuata
		private int CantCuotas, interes, opcionTar;

		//Propiedades de la clase Cuata

		public int CuotPro
		{
			get { return CantCuotas; }
			set { CantCuotas = value; }
		}
		public int IntPro
		{
			get { return interes; }
			set { interes = value; }
		}

		//constructor de la clase Cuata
		public Cuota(int cuotasCons, int InteresCons)
		{
			CuotPro = cuotasCons;
			IntPro = InteresCons;

		}
		public Cuota(int opcionCons, int cuotasCons, int InteresCons)
		{
			CuotPro = cuotasCons;
			IntPro = InteresCons;
			opcionTar = opcionCons;

		}

		public override string ToString()
		{
			return string.Format("[Cuota CantCuotas={0}, Interes={1}]", CuotPro, IntPro);
		}

	}
}
