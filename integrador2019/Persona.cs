using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador2019
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre, apellido, dni, fechaNac;

		public string FechNacPro
		{
			get { return fechaNac; }
			set { fechaNac = value; }
		}
		public string NomPro
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string ApellPro
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public string DniPro
		{
			get { return dni; }
			set { dni = value; }
		}

		public Persona(string NomCons, string ApellCons, string DniCons, string FechNacCons)
		{
			NomPro = NomCons;
			ApellPro = ApellCons;
			DniPro = DniCons;
			FechNacPro = FechNacCons;
		}
	}
}
