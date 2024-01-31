using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace integrador2019
{
	/// <summary>
	/// Description of Tienda.
	/// </summary>
	//	public class Tienda
	//	{
	//		private string nombre; 
	//		public Administracion adm;
	//		public ArrayList clientes;
	//		
	//		
	//		public string NomPro
	//		{
	//			get{return nombre;}
	//		}
	//		
	//		
	//		
	//		public Tienda(string nombreCons)
	//		{
	//			nombre=nombreCons;
	//			adm=new Administracion();
	//			clientes=new ArrayList();
	//			
	//		}
	//		
	//		public void AltaCliente(string nom,string apell,string dni,string fec_naci)
	//		{
	//			Cliente client =new Cliente(nom,apell,dni,fec_naci);
	//			clientes.Add(client);
	//		}
	//		
	//		public bool BuscarCliente(string dni )
	//		{
	//			foreach(Cliente cli in clientes)
	//			{
	//				if(cli.DniPro==dni)
	//				{
	//					return true;
	//				}
	//			}
	//			return false;
	//		}
	//		
	//		public void MostrarCliente(string dni)
	//		{
	//			foreach(Cliente c in clientes)
	//			{
	//				if(c.DniPro==dni)
	//				{
	//					Console.Write("{0}",c.ToString());
	//				}
	//			}
	//		}
	//		
	//		
	////		public void TotalVendidoEnTienda()
	////		{
	////			Console.WriteLine("El total vendido en la tienda es: $" + string.Format("{0:0.00}",totaltienda));
	////			
	////			Console.WriteLine("\nPresione una tecla para continuar...");
	////			Console.ReadKey();
	////			Console.Clear();
	////			ModuloAdministrativo();
	////		}
	//		
	////		public double TotalVendidoEnTienda(ArrayList a, int c)
	////		{
	////			double suma = 0;
	////			foreach (double element in a) {
	////				suma = suma + element;
	////			}
	////			return suma;
	////		}
	//		
	////		public static void ventatienda()
	////		{
	////			Console.WriteLine("Ventas tienda online:"+portienda);
	////		}
	//		
	//
	//		
	//		public void TotalVendidoPorCliente()
	//		{
	//			Console.WriteLine("Total vendido por cliente:");
	//			
	////			int i = 1;
	////			foreach (Cliente cliente in MiTienda.Cliente) {
	////				Console.WriteLine("\n"+ i +") "+"[Nombre: " +cliente.Nombre+ ", Apellido: " +cliente.Apellido+ ", DNI: "+cliente.Dni+", Fecha: " + cliente.Fecha + ", Gastado: " + string.Format("{0:0.00}",cliente.TotalGastado) +"]");
	////				i++;
	////			}
	////			
	////			Console.WriteLine("\nPresione una tecla para continuar...");
	////			Console.ReadKey();
	////			Console.Clear();
	////			ModuloAdministrativo();
	//			
	//			foreach (Cliente e in clientes) {
	//				if(e.TotGastPro > 0){
	//					Console.WriteLine("{0}", e.ToString());
	//
	//				}
	//			}
	//			
	//			
	//		}
	//		
	//		
	//		
	//	}

	public class Tienda
	{
		private string nombre;
		public Administracion adm;
		public ArrayList clientes;

		public string NomPro
		{
			get { return nombre; }
		}



		public Tienda(string nombreCons)
		{
			nombre = nombreCons;
			adm = new Administracion();
			clientes = new ArrayList();

		}

		public void AltaCliente(string nom, string apell, string dni, string fec_naci)
		{
			Cliente client = new Cliente(nom, apell, dni, fec_naci);
			clientes.Add(client);
		}
		public bool BuscarCliente(string dni)
		{
			foreach (Cliente cli in clientes)
			{
				if (cli.DniPro == dni)
				{
					return true;
				}
			}
			return false;
		}
		public void MostrarCliente(string dni)
		{
			foreach (Cliente c in clientes)
			{
				if (c.DniPro == dni)
				{
					Console.Write("{0}", c.ToString());
				}
			}
		}

		//		public void TotalVendidoEnTienda()
		//		{
		//			Console.WriteLine("El total vendido en la tienda es: $" + string.Format("{0:0.00}",totaltienda));
		//			
		//			Console.WriteLine("\nPresione una tecla para continuar...");
		//			Console.ReadKey();
		//			Console.Clear();
		//			ModuloAdministrativo();
		//		}

		//		public double TotalVendidoEnTienda(ArrayList a, int c)
		//		{
		//			double suma = 0;
		//			foreach (double element in a) {
		//				suma = suma + element;
		//			}
		//			return suma;
		//		}

		//		public static void ventatienda()
		//		{
		//			Console.WriteLine("Ventas tienda online:"+portienda);
		//		}

		public void TotalVendidoEnTienda(decimal x)
		{
			Console.WriteLine("MONTO TOTAL RECAUDADO POR LA TIENDA ${0}", x);
		}
		public void TotalVendidoPorCliente()
		{
			Console.Clear();
			Console.WriteLine("***      Total vendido por cliente           ***");
			foreach (Cliente e in clientes)
			{
				if (e.TotGastPro > 0)
				{
					Console.WriteLine("{0}", e.ToString());

				}
			}


		}
		public void TotalAbonadoCliente(ArrayList client, int indice)
		{
			if (indice == 0)
			{
				Console.WriteLine(client[indice]);
			}
			else
			{
				Console.WriteLine(client[indice]);
				TotalAbonadoCliente(client, indice - 1);
			}
		}

		//		public int TotalAbonadoCliente(ArrayList client,  int indice){
		//			
		//			if (indice == 0) {
		//				return (client[indice].TotalGastado);
		//			}
		//			else{
		//				Console.WriteLine(client[indice]);
		//				return client[indice].TotalGastado + TotalAbonadoCliente(client, indice-1);
		//			}
		//		}


		//		public Cliente TotalAbonadoCliente(Cliente[] cli, int pos){
		//
		//			if (pos == 0){
		//				return cli[pos];
		//			}
		//			else{
		//				return cli[pos] + TotalAbonadoCliente(cli, pos-1);
		//			}
		//		}


	}
}
