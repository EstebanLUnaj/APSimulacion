namespace integrador2019
{
	public class Producto
	{
		private string codigo, marca, descripcion, presentacion;
		private decimal precio, descuento;




		public Producto(string codigo, string marca, string descripcion, string presentacion, decimal precio, decimal descuento)
		{
			this.codigo = codigo;
			this.marca = marca;
			this.descripcion = descripcion;
			this.presentacion = presentacion;
			this.precio = precio;
			this.descuento = descuento;


		}

		public string CodigoPro
		{
			get { return codigo; }
			set { codigo = value; }
		}

		public string MarcaPro
		{
			get { return marca; }
			set { marca = value; }
		}

		public string DescriPro
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		public string PresentPro
		{
			get { return presentacion; }
			set { presentacion = value; }
		}

		public decimal PrecioPro
		{
			get { return precio; }
			set { precio = value; }
		}

		public decimal DescuentoPro
		{
			get { return descuento; }
			set { descuento = value; }
		}

		public override string ToString()
		{
			return string.Format("- Producto Codigo={0}, Marca={1}, Descripcion={2},Presentacion={3}, Precio=${4}, Descuento={5}%]", codigo, marca, descripcion, presentacion, precio, descuento);
		}


	}
}