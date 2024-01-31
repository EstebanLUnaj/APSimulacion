using System.Collections;

namespace integrador2019
{
//	public class Tarjeta
//	{
//		private string nom_Tarj, nom_Ban;
//		private int forma_Pago; 
//		public ArrayList cuotas;
//		public Tarjeta()
//		{
//		}
//		//Propiedades de la clase Tarjeta
//		public string NomTarjPro
//		{
//			get{return nom_Tarj;}
//			set{nom_Tarj=value;}
//		}
//		public string NomBanPro
//		{
//			get{return nom_Ban;}
//			set{nom_Ban=value;}
//		}
//		public int FormPagoPro
//		{
//			get{return forma_Pago;}
//			set{forma_Pago=value;}
//		}
//		
//		//Constructor de la clase Tarjeta
//		public Tarjeta(string NomTarCons,string NomBanCons,int FormPagoCons)
//		{
//			NomTarjPro=NomTarCons;
//			NomBanPro=NomBanCons;
//			FormPagoPro=FormPagoCons;
//			cuotas=new ArrayList();
//		}
//		
////		public void TotalVendidoPorTarjeta()
////		{
////			Console.WriteLine("Total vendido por Tarjeta:");
////			
////			int i = 1;
////			foreach (Tarjeta t in MiTienda.Tarjetas) {
////				Console.WriteLine("\n" +i + ")" + " [Tarjeta Nombre: " +t.Nombre+ ", Banco: " +t.Banco+ ", Cantidad de formas de pago: "+t.Formas_de_Pago.Count+ ", Gastado:" + string.Format("{0:0.00}",t.Total_Compras)+"]");
////				i++;
////			}
////			
////			Console.WriteLine("Presione una tecla para continuar...");
////			Console.ReadKey();
////			Console.Clear();
////			ModuloAdministrativo();
////		}
//		
//		public override string ToString()
//		{
//			return string.Format("[Tarjeta NomTarj={0}, NomBan={1}, FormPago={2}, Cuotas={3}]", nom_Tarj, nom_Ban, forma_Pago, cuotas);
//		}
//	}


	public class Tarjeta
	{
		private string nom_Tarj, nom_Ban;
		private int forma_Pago;
		private decimal total;
		public ArrayList cuotas;

		public Tarjeta()
		{
		}
		//Propiedades de la clase Tarjeta
		public string NomTarjPro
		{
			get { return nom_Tarj; }
			set { nom_Tarj = value; }
		}
		public string NomBanPro
		{
			get { return nom_Ban; }
			set { nom_Ban = value; }
		}
		public int FormPagoPro
		{
			get { return forma_Pago; }
			set { forma_Pago = value; }
		}

		public decimal TotalPro
		{
			get { return total; }
			set { total = value; }
		}

		//Constructor de la clase Tarjeta
		public Tarjeta(string NomTarCons, string NomBanCons, int FormPagoCons)
		{
			NomTarjPro = NomTarCons;
			NomBanPro = NomBanCons;
			FormPagoPro = FormPagoCons;
			cuotas = new ArrayList();
		}

		//		public void TotalVendidoPorTarjeta()
		//		{
		//			Console.WriteLine("Total vendido por Tarjeta:");
		//			
		//			int i = 1;
		//			foreach (Tarjeta t in MiTienda.Tarjetas) {
		//				Console.WriteLine("\n" +i + ")" + " [Tarjeta Nombre: " +t.Nombre+ ", Banco: " +t.Banco+ ", Cantidad de formas de pago: "+t.Formas_de_Pago.Count+ ", Gastado:" + string.Format("{0:0.00}",t.Total_Compras)+"]");
		//				i++;
		//			}
		//			
		//			Console.WriteLine("Presione una tecla para continuar...");
		//			Console.ReadKey();
		//			Console.Clear();
		//			ModuloAdministrativo();
		//		}

		public override string ToString()
		{
			return string.Format("[Tarjeta NomTarj={0}, NomBan={1}, FormPago={2}, Cuotas={3}]", nom_Tarj, nom_Ban, forma_Pago, cuotas);
		}
	}
}