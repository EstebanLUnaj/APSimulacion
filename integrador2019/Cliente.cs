using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador2019
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente : Persona
	{
		private decimal totalGastado;

		public decimal TotGastPro
		{
			get { return totalGastado; }
			set { totalGastado = value; }
		}

		public Cliente(string nombre, string apellido, string dni, string fechaNacimento, decimal totGastadoCons) : base(nombre, apellido, dni, fechaNacimento)
		{
			TotGastPro = totGastadoCons;
		}
		public Cliente(string nombre, string apellido, string dni, string fechaNacimento) : base(nombre, apellido, dni, fechaNacimento)
		{

		}



		public override string ToString()
		{
			return string.Format("[Cliente Nombre={0}, Apellido={1}, Dni={2}, Nacimiento={3}, TotalGastado={4}]", NomPro, ApellPro, DniPro, FechNacPro, totalGastado);
		}
	}
}
