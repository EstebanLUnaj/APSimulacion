using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador2019
{
	public class Administracion
	{
		//de productos
		public ArrayList productos;
		public ArrayList promociones;
		public ArrayList tarjetas;
		public ArrayList beneficios;
		public Carro CarroCompra;
		public Cuota cuot;



		public Administracion()
		{
			productos = new ArrayList();
			promociones = new ArrayList();
			CarroCompra = new Carro(new ArrayList(), new ArrayList());
			tarjetas = new ArrayList();
			beneficios = new ArrayList();

		}

		public bool AltaProducto(string codigo, string marca, string descripcion, string presentacion, decimal precio, decimal descuento)
		{

			foreach (Producto p in productos)
			{
				if (p.CodigoPro == codigo && p.MarcaPro == marca && p.DescriPro == descripcion && p.PresentPro == presentacion && p.PrecioPro == precio && p.DescuentoPro == descuento)
					return false;
			}

			Producto producto = new Producto(codigo, marca, descripcion, presentacion, precio, descuento);
			productos.Add(producto);
			return true;
		}
		public int MostrarProductos()
		{
			int i = 1;
			foreach (Producto prod in productos)
			{
				Console.WriteLine("{0}){1}", i++, prod.ToString());
			}
			return i;
		}
		public void AltaCarro(Producto p, decimal cantidad)
		{
			bool estado = true;
			if (estado)
			{
				CarroCompra.productosCa.Add(p);
				CarroCompra.cantidadCa.Add(cantidad);
			}


		}
		public void Eliminarproductocarro(ArrayList prod, int opcion)
		{
			prod.RemoveAt(opcion);

		}
		public bool MostrarCarro()
		{
			bool estado = true;

			for (int i = 0; i < CarroCompra.productosCa.Count; i++)
			{
				Producto p = (Producto)CarroCompra.productosCa[i];

				Console.WriteLine("{0})Cantidad={1}[ProductoTipo={2}, Marca={3},Descripcion={4},Presentacion={5} precio={6:C}, Descuento={7}% ]", i + 1, CarroCompra.cantidadCa[i], p.CodigoPro, p.MarcaPro, p.DescriPro, p.PresentPro, p.PrecioPro, p.DescuentoPro);
			}
			return estado;

		}
		public decimal CalculoTotalCarro(ArrayList prod, ArrayList cant)
		{


			decimal total = 0;
			for (int i = 0; i < prod.Count; i++)
			{
				Producto varr = (Producto)prod[i];
				decimal cantidad = (decimal)cant[i];
				decimal variab = varr.PrecioPro - varr.PrecioPro * (varr.DescuentoPro / 100);
				total += cantidad * variab;
			}
			return total;

		}
		public decimal CalculoTotalCarroDesc(ArrayList prod, ArrayList cant)
		{
			decimal total = 0;

			for (int i = 0; i < prod.Count; i++)
			{
				Producto varr = (Producto)prod[i];
				decimal cantidad = (decimal)cant[i];
				decimal variab = varr.PrecioPro - varr.PrecioPro * (varr.DescuentoPro / 100);
				if (varr.DescuentoPro > 0)
				{
					total += cantidad * variab;
				}

			}
			return total;

		}
		public void LimpiarCarroDeProductos()
		{
			CarroCompra.productosCa.Clear();
			CarroCompra.cantidadCa.Clear();
		}
		public bool AltaTarjeta(string nomT, string nomB, int ForPa)
		{
			Tarjeta Tar = new Tarjeta(nomT, nomB, ForPa);
			tarjetas.Add(Tar);

			int i = 1;

			while (i <= Tar.FormPagoPro)
			{
				try
				{
					Console.Write("\nForma de pago #{0} ", i);
					Console.Write("\ningrese cuotas: ");
					int cantCuo = Convert.ToInt32(Console.ReadLine());
					Console.Write("Ingrese Interes por couta: ");
					int Interes = Convert.ToInt32(Console.ReadLine());
					cuot = new Cuota(cantCuo, Interes);
					Tar.cuotas.Add(cuot);
					i++;

				}
				catch (FormatException)
				{

					Console.WriteLine("ERROR: EL FORMATO NO EWS ACEPTADO");
					return false;

				}

			}
			return true;
		}
		public void AltaBeneficiosTarje(int numOp, int cantCuo, int inter)
		{

			foreach (Tarjeta ta in tarjetas)
			{
				if (tarjetas.IndexOf(ta) == numOp - 1)
				{
					foreach (Cuota cuo in ta.cuotas)
					{
						if (cuo.CuotPro == cantCuo)
						{
							cuo.IntPro = inter;
							beneficios.Add(ta);
						}

					}
				}
			}


		}
		public void MostrarTarjetas(ArrayList tarjet)
		{

			int i = 1;
			foreach (Tarjeta t in tarjet)
			{
				Console.Write("\n{0})[Tarjeta Nombre={1}, Banco={2}, Cantidad_Formas_Pago={3}, Total Compra={4:C}]", i, t.NomTarjPro, t.NomBanPro, t.FormPagoPro, CalculoTotalCarro(CarroCompra.productosCa, CarroCompra.cantidadCa));
				foreach (Cuota c in t.cuotas)
				{
					Console.Write("\n\t{0} cuotas {1}% de interes ", c.CuotPro, c.IntPro);
				}
				i++;
			}

		}
		public bool AltaPromocion(int numOp, decimal porcent, Producto pro)
		{
			pro.DescuentoPro = porcent;

			Promocion promo = new Promocion(numOp, porcent, pro);
			promociones.Add(promo);
			return true;
		}
		public void MostrarPromociones()
		{
			int i = 1;
			foreach (Promocion promo in promociones)
			{
				Console.WriteLine("{0}){1}", i++, promo.ToString());
			}

		}
		public void TotalVendidoPorTarjeta()
		{


			foreach (Tarjeta t in tarjetas)
			{
				if (t.TotalPro > 0)
				{
					Console.WriteLine("[Tarjeta Nombre={0}, Banco={1}, Total ={2:C}]", t.NomTarjPro, t.NomBanPro, t.TotalPro);
				}
			}

		}






		public void TotalVendidoDesc(decimal r)
		{
			Console.WriteLine("MONTO TOTAL DE DESCUENTOS ${0}", r);
		}


		//		public static void cantidadvendida(int encarro)
		//		{
		//			portienda=portienda+encarro;
		//		}
		//		public static void ventacliente()
		//		{
		//			ventaporcliente();
		//		}
		//		public static void ventaporcliente()
		//		{
		//			foreach(Compra clientex in Compra.client)
		//			{
		//				Console.WriteLine(clientex+" | "+" TtlGastado: $"+clientex.ventas);
		//			}
		//		}
		//		public static void ventatarjeta()
		//		{
		//			foreach(Tarjeta cosas in Tarjeta.tarjetax)
		//			{
		//				Console.WriteLine(cosas.numerox+")"+"[Tarjeta Nombre="+cosas.nomtar+" | "+"Banco="+cosas.banco+" | "+"Total Compras: $"+cosas.comprastarjeta+"]");
		//			}
		//		}



	}
}
