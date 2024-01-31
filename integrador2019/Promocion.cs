namespace integrador2019
{
	public class Promocion
	{
		private decimal porcrntaje;
		private int opcion;
		public Producto producto;

		public int OpcionPro
		{
			get { return opcion; }
			set { opcion = value; }
		}

		public decimal PorcPro
		{
			get { return porcrntaje; }
			set { porcrntaje = value; }
		}
		public Promocion(int opcionCons, decimal porcenCons, Producto p)
		{
			OpcionPro = opcionCons;
			PorcPro = porcenCons;
			producto = p;
		}



		public override string ToString()
		{
			return string.Format("[Promocion codigo={0}, marca={1}, descripcion={2}, precio={3:C}, descuento={4}%]", producto.CodigoPro, producto.MarcaPro, producto.DescriPro, producto.PrecioPro, producto.DescuentoPro);
		}
	}
}