using System;
using System.Collections;
using System.Linq;

namespace integrador2019
{
	//	class Program
	//	{
	//		
	//		
	//		public static void Main(string[] args){
	//			
	//			Menu_Pantalla();
	//			Console.ReadKey(true);
	//		}
	//		public static void Menu_Pantalla(){
	//			
	//
	//			Tienda tienda=new Tienda();
	//			Administracion adm = tienda.adm;
	//
	//			
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("*****			TIENDA LA MUNDIAL ONLINE 			   *****");
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("¿A QUE MODULO DESEA INGRESAR?");
	//			Console.WriteLine("1_ PRODUCTO Y PROMOCIONES");
	//			Console.WriteLine("2_ COMPRAS");
	//			Console.WriteLine("3_ TARJETAS DE CREDITO");
	//			Console.WriteLine("4_ ADMINISTRACION");
	//			Console.WriteLine("5_ SALIR DEL SISTEMA");
	//			
	//			int numero = int.Parse(Console.ReadLine());
	//			do{
	//				switch(numero){
	//						case 1:
	//							Modulo_Productos();
	//							break;
	//						case 2:
	//							
	//							Modulo_Compras();
	//							break;
	//						case 3:
	//							
	//							Modulo_Tarjetas();
	//							break;
	//						case 4:
	//							
	//							Modulo_Administrativo();
	//							break;
	//						case 5:
	//							Environment.Exit(0);//Application.Exit();
	//						break;
	//						
	//				}
	//				
	//			}
	//			while (numero < 5 ); 
	//	
	//		}
	//		
	//		//COMIENZO DEL MODULO PRODUCTOS
	//		
	//		public static void Modulo_Productos(){
	//			
	////			Console.Clear();
	//			Tienda tienda=new Tienda();
	//			Administracion adm = tienda.adm;
	//			
	//		
	//			adm.AltaProducto("456","LILIANA","BATIDORA","UNIDAD", 1500, 0);
	//			adm.AltaProducto("46656","JULIAN","TENEDOR PARA ASADOR","POR 12", 150, 0);
	//			adm.AltaProducto("0987","CARLOSTAN","HORNO MICROONDAS","UNIDAD", 2500, 0);
	//
	//			
	//			
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("*****			MODULO PRODUCTOS 			   *****");
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("¿QUE DESEA HACER?");
	//			Console.WriteLine("1_ DAR DE ALTA PRODUCTOS");
	//			Console.WriteLine("2_ DAR DE ALTA PROMOCIONES");
	//			Console.WriteLine("3_ LISTAR PRODUCTOS ");
	//			Console.WriteLine("4_ LISTAR PROMOCIONES");
	//			Console.WriteLine("5_ VOLVER");
	//			
	//			int numero = int.Parse(Console.ReadLine());
	//			
	//			do{
	//					switch(numero){
	//						case 1:
	////							Console.Clear();
	//
	//							string cod,mar,descr,pres;
	//							decimal pre;
	//							Producto prod;
	//				
	//					
	//							Console.WriteLine("********************************************************************************");
	//							Console.WriteLine("*****			MODULO PRODUCTOS 			   *****");
	//							Console.WriteLine("********************************************************************************");
	//							Console.WriteLine("");
	//						
	//							Console.WriteLine("Ingrese el codigo del producto");
	//							cod= Console.ReadLine();
	//							Console.WriteLine("Ingrese la marca del producto");
	//							mar= Console.ReadLine();
	//							Console.WriteLine("Ingrese la descripcion del producto");
	//							descr=Console.ReadLine();
	//							Console.WriteLine("Ingrese tipo de presentacion UNIDAD/POR 6/ POR 12");
	//							pres = Console.ReadLine();
	//							Console.WriteLine("Ingrese precio por la unidad del producto");	
	//							pre= decimal.Parse(Console.ReadLine());
	//							decimal descuen = 0;
	//							adm.AltaProducto(cod,mar,descr,pres,pre,descuento);
	//							adm.MostrarProductos();
	//
	//							
	//
	//							Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
	//							Console.ReadKey(true);
	//							Modulo_Productos();
	//							break;
	//						case 2:
	////							Console.Clear();
	//							Console.WriteLine("********************************************************************************");
	//							Console.WriteLine("*****			MODULO PRODUCTOS 			   *****");
	//							Console.WriteLine("********************************************************************************");
	//							Console.WriteLine("Listado de productos disponibles");
	////							if(adm.MostrarProductos()!=1)
	////							{
	////								Console.WriteLine("ingrese un producto para aplicar un descuento");          
	////							}
	////							else
	////							{
	////								Console.WriteLine("No se almacenaron los Productos");
	////							}
	//							Console.ReadKey(true);
	//							
	//
	//							break;
	//						case 3:
	////							Console.Clear();
	//							Console.WriteLine("********************************************************************************");
	//							Console.WriteLine("*****			MODULO PRODUCTOS 			   *****");
	//							Console.WriteLine("********************************************************************************");
	//							Console.WriteLine("Listado de productos disponibles");
	//							
	//							adm.MostrarProductos();
	////							if(adm.MostrarProductos()==1)
	////							{
	////								Console.WriteLine("No se almacenaron los Productos");          
	////							}
	//							Console.ReadKey(true);
	//							Modulo_Productos();
	//							break;
	//						case 4:
	//
	//							break;
	//						case 5:
	//							Menu_Pantalla();
	//						break;
	//				}
	//			}
	//			while (numero < 5 );
	//			
	//		}
	//		
	//		//COMIENZO DEL MODULO COMPRAS
	//		public static void Modulo_Compras(){
	//			Console.Clear();
	//			
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("*****			MODULO COMPRAS 			   *****");
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("¿QUE DESEA HACER?");
	//			Console.WriteLine("1_ AGREGAR PRPODUCTO AL CARRO");
	//			Console.WriteLine("2_ IDENTIFICAR CLIENTE");
	//			Console.WriteLine("3_ VOLVER");
	//			
	//			int numero = int.Parse(Console.ReadLine());
	//			do{
	//					switch(numero){
	//						case 1:
	//						Console.Clear();
	//						Modulo_Productos();
	//						
	//							break;
	//						case 2:
	//						
	//							break;
	//						
	//						case 3:
	//							Console.Clear();
	//							Menu_Pantalla();
	//						break;
	//				}
	//			}
	//			while (numero < 3 );
	//			
	//		}
	//		
	//		public static void Modulo_Tarjetas(){
	//			Console.Clear();
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("*****			MODULO TARJETAS 			   *****");
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("¿QUE DESEA HACER?");
	//			Console.WriteLine("1_ AGREGAR TARJETAS");
	//			Console.WriteLine("2_ AGREGAR BENEFICIOS");
	//			Console.WriteLine("3_ LISTAR TARJETAS ");
	//			Console.WriteLine("4_ LISTAR TARJETAS CON BENEFICIOS");
	//			Console.WriteLine("5_ VOLVER");
	//			
	//			int numero = int.Parse(Console.ReadLine());
	//			do{
	//					switch(numero){
	//						case 1:
	//						Console.Clear();
	//						Modulo_Productos();
	//						
	//							break;
	//						case 2:
	//						
	//							break;
	//						case 3:
	//						
	//							break;
	//						case 4:
	//						
	//							break;
	//						case 5:
	//							Console.Clear();
	//							Menu_Pantalla();
	//						break;
	//				}
	//			}
	//			while (numero < 5 );
	//			
	//		}
	//		
	//		public static void Modulo_Administrativo(){
	//			Console.Clear();
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("*****			MODULO ADMINISTRATIVO 			   *****");
	//			Console.WriteLine("********************************************************************************");
	//			Console.WriteLine("SELECCIONE UNA OPCION: ");
	//			Console.WriteLine("1_ MONTO TOTAL RECAUDADO POR LA TIENDA");
	//			Console.WriteLine("2_ MONTO TOTAL ABONADO POR EL CLIENTE");
	//			Console.WriteLine("3_ MONTO TOTAL ABONADO CON TARJETAS ");
	//			Console.WriteLine("4_ MONTO TOTAL CORRESPONDIENTE A DESCUENTOS EFECTUADOS EN LAS VENTAS");
	//			Console.WriteLine("5_ VOLVER");
	//			
	//			int numero = int.Parse(Console.ReadLine());
	//			do{
	//					switch(numero){
	//						case 1:
	//						Console.Clear();
	//						Modulo_Productos();
	//						
	//							break;
	//						case 2:
	//						
	//							break;
	//						case 3:
	//						
	//							break;
	//						case 4:
	//						
	//							break;
	//						case 5:
	//							Console.Clear();
	//							Menu_Pantalla();
	//						break;
	//				}
	//			}
	//			while (numero < 5 );
	//			
	//		}
	//		
	//		
	//		
	//			
	//	}

	class ConfirmadoErrorException : Exception { }
	class NoNegativosExcepcion : Exception { }
	class EstaVacioException : Exception { }

	class Program
	{
		public static void Main(string[] args)
		{
			decimal totalRecaudadoTienda = 0m;
			decimal totalRecaudadoDesc = 0m;


			ArrayList totalRecaudadooCliente = new ArrayList();
			ArrayList totalRecaudadoTarjeta = new ArrayList();
			ArrayList cuo_tar;
			string nom_tar;
			decimal total_tar = 0m;
			decimal cuota;
			decimal interes;



			Administracion adm;
			Tienda tienda = new Tienda("LA MUNDIAL ON-LINE");
			int opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro }, "¿A que modulo desea entrar?", new string[] { "Producto y Promociones", "Compras", "Tarjetas de credito", "Administracion", "Salir del sistema" });
			adm = tienda.adm;


			//			// Lista de productos:

			Producto producto1 = new Producto("3336", "MARIA ANA", "SARTEN ANTIADHERENTE", "UNIDAD", 650.89m, 0);
			adm.productos.Add(producto1);
			Producto producto2 = new Producto("1234", "JOHAN", "OLLA DE PRESION", "UNIDAD", 929.30m, 0);
			adm.productos.Add(producto2);
			Producto producto3 = new Producto("9393", "MARIA ANA", "CUCHILLOS", "POR 6", 200.50m, 0);
			adm.productos.Add(producto3);
			Producto producto4 = new Producto("0012", "SANTIAGO", "EXPRIMIDOR ELECTRICO", "UNIDAD", 900.60m, 0);
			adm.productos.Add(producto4);
			Producto producto5 = new Producto("4003", "CABRA", "SARTEN ANTIADHERENTE", "UNIDAD", 650.30m, 0);
			adm.productos.Add(producto5);
			Producto producto6 = new Producto("5748", "DANIEL", "SARTEN ANTIADHERENTE", "UNIDAD", 750.00m, 0);
			adm.productos.Add(producto6);


			// Lista de clientes:

			Cliente cliente1 = new Cliente("Johana", "Cuyo", "38111111", "03/05/1993");
			tienda.clientes.Add(cliente1);

			Cliente cliente2 = new Cliente("Lucio", "Gomez", "38222222", "03/05/1993");
			tienda.clientes.Add(cliente2);

			Cliente cliente3 = new Cliente("Jorge", "Martinez", "38333333", "10/10/1990");
			tienda.clientes.Add(cliente3);

			Cliente cliente4 = new Cliente("Maria", "Sosa", "37133331", "23/07/1983");
			tienda.clientes.Add(cliente4);


			// Lista de tarjetas:

			// Comienzo de tarjeta 1:

			Tarjeta tarjeta1 = new Tarjeta("VISA", "PROVINCIA", 3);
			adm.tarjetas.Add(tarjeta1);

			Cuota pago1_t1 = new Cuota(3, 10);
			tarjeta1.cuotas.Add(pago1_t1);

			Cuota pago2_t1 = new Cuota(6, 20);
			tarjeta1.cuotas.Add(pago2_t1);

			Cuota pago3_t1 = new Cuota(9, 30);
			tarjeta1.cuotas.Add(pago3_t1);

			// Comienzo de tarjeta 2:

			Tarjeta tarjeta2 = new Tarjeta("NARANJA", "GALICIA", 4);
			adm.tarjetas.Add(tarjeta2);

			Cuota pago1_t02 = new Cuota(10, 3);
			tarjeta2.cuotas.Add(pago1_t02);
			Cuota pago2_t02 = new Cuota(20, 5);
			tarjeta2.cuotas.Add(pago2_t02);
			Cuota pago3_t02 = new Cuota(30, 10);
			tarjeta2.cuotas.Add(pago3_t02);
			Cuota pago4_t02 = new Cuota(40, 15);
			tarjeta2.cuotas.Add(pago4_t02);


			// Comienzo de tarjeta 3:

			Tarjeta tarjeta3 = new Tarjeta("MASTERCARD", "GALICIA", 2);
			adm.tarjetas.Add(tarjeta3);

			Cuota pago1_t3 = new Cuota(3, 10);
			tarjeta3.cuotas.Add(pago1_t3);

			Cuota pago2_t3 = new Cuota(6, 20);
			tarjeta3.cuotas.Add(pago2_t3);




			bool estado;
			while (opcion != 5)
			{
				switch (opcion)
				{

					//*************************************MODULO PRODUCTOS*******************************************************
					case 1:
						opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro, "Modulo Producto" }, "¿Que desea Hacer?", new string[] { "Dar de alta Producto", "Dar de alta promociones", "Listar productos", "Listar Promociones", "volver" });
						switch (opcion)
						{
							case 1:
								estado = true;
								Console.WriteLine("\nIngrese tipo de producto: ");

								Console.WriteLine("Ingrese el codigo del producto");
								string cod = Console.ReadLine();
								Console.WriteLine("Ingrese la marca del producto");
								string mar = Console.ReadLine();
								Console.WriteLine("Ingrese la descripcion del producto");
								string descr = Console.ReadLine();
								Console.WriteLine("Ingrese tipo de presentacion UNIDAD/POR 6/ POR 12");
								string pres = Console.ReadLine();
								try
								{
									if (pres != "UNIDAD" && pres != "POR 6" && pres != "POR 12")
									{
										throw new ConfirmadoErrorException();
									}
								}
								catch (ConfirmadoErrorException)
								{
									Console.WriteLine("ERROR: SOLO SON VALIDOS 'UNIDAD' 'POR 6' O 'POR 12' ");
									Console.ReadKey(true);
									break;
								}

								Console.WriteLine("Ingrese precio por la unidad del producto");
								decimal pre = 0;
								try
								{
									pre = decimal.Parse(Console.ReadLine());
									if (pre <= -1)
										throw new NoNegativosExcepcion();

								}
								catch (FormatException)
								{

									Console.WriteLine("Solo se pueden recibir numeros no letras.");
									Console.ReadKey(true);
									break;

								}
								catch (NoNegativosExcepcion)
								{
									Console.WriteLine("no se permiten numeros nrgativos");
									Console.ReadKey(true);
									break;
								}

								decimal descuen = 0;

								if (estado && cod != "" && mar != "" && descr != "" && pre >= 0)
								{
									if (adm.AltaProducto(cod, mar, descr, pres, pre, descuen))
										Console.WriteLine("\nEl producto fue agregado correctamente.");
									else
										Console.WriteLine("\nDatos duplicados, el producto no fue dado de alta.");
								}
								else
									Console.WriteLine("\nHay un error en los datos ingresados, el producto no fue dado de alta.");
								Console.WriteLine("\n\nPresione una tecla para continuar");
								Console.ReadKey(true);
								opcion = 1;
								break;
							case 2:
								estado = true;
								Menu(new string[] { "TIENDA " + tienda.NomPro, "Modulo Promocion" }, "Lista de Productos");

								if (adm.MostrarProductos() != 1)
								{
									Console.Write("\n\ningrese el producto para la promo: ");
									string OpProduc = Console.ReadLine();
									int num = 0;
									if (SoloNumeros(OpProduc) && OpProduc != "")
									{
										num = int.Parse(OpProduc);
									}
									else
										estado = false;
									Console.Write("ingrese el descuento: ");
									string descuentoString = Console.ReadLine();

									decimal descuento = 0M;
									if (SoloNumeros(descuentoString) && descuentoString != "")
									{
										descuento = decimal.Parse(descuentoString);
									}
									else
										estado = false;
									if (estado)
									{
										try
										{
											if (adm.AltaPromocion(num, descuento, (Producto)adm.productos[num - 1]))
												Console.WriteLine("La promocion de productos fue dada de alta.");
										}
										catch (ArgumentOutOfRangeException)
										{

											Console.WriteLine("ERROR: FUERA DEL RANGO DISPONIBLE");
											Console.ReadKey(true);
											opcion = 1;
											break;
										}


									}

								}
								else
									Console.WriteLine("Sin datos almacenados");
								Console.WriteLine("\n\nPresione una tecla para continuar");
								Console.ReadKey(true);
								opcion = 1;
								break;


							case 3:
								estado = true;
								Menu(new string[] { "TIENDA " + tienda.NomPro, "Modulo Producto" }, "Lista de Productos");
								if (adm.MostrarProductos() == 1)
								{
									Console.Write("No se almacenaron los Productos");
								}
								Console.WriteLine("\n\nPresione una tecla para continuar");
								Console.ReadKey(true);
								opcion = 1;
								break;
							case 4:
								estado = true;
								Menu(new string[] { "TIENDA " + tienda.NomPro, "Modulo Producto" }, "Lista de Promociones");
								adm.MostrarPromociones();
								Console.WriteLine("\n\nPresione una tecla para continuar");
								Console.ReadKey(true);
								opcion = 1;
								break;
							default:
								opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro }, "¿A que modulo desea entrar?", new string[] { "Producto y Promociones", "Compras", "Tarjetas de credito", "Administracion", "Salir del sistema" });
								break;
						}
						break;

					//**************************************************MODULO COMPRAS*************************************
					case 2:
						opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro, "MODULO COMPRAS" }, "¿Que desea Hacer?", new string[] { "Agregar Producto al carro", "Identificar cliente", "volver" });
						switch (opcion)
						{
							case 1:
								int opcion2 = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro, "MODULO CARRO" }, "¿Que desea Hacer?", new string[] { "Agregar Producto al carro", "Quitar Producto del carro", "Listar productos del carro", "volver" });
								switch (opcion2)
								{
									case 1:
										estado = true;
										if (adm.MostrarProductos() != 1)
										{
											Console.Write("Seleccione un producto para agregar al carro: ");
											string numOpString = Console.ReadLine();
											int numOp = 0;
											if (SoloNumeros(numOpString) && numOpString != "")
											{
												numOp = int.Parse(numOpString);
											}
											else
												estado = false;
											Console.Write("Ingrese la cantidad: ");
											string cantString = Console.ReadLine();
											decimal cantidad = 0;
											if (SoloNumeros(cantString) && cantString != "")
											{
												cantidad = decimal.Parse(cantString);
											}

											else
												estado = false;

											if (estado)
											{
												Producto prod = (Producto)adm.productos[numOp - 1];
												adm.AltaCarro(prod, cantidad);
											}
										}
										else
											Console.WriteLine("Sin datos almacenados");
										Console.WriteLine("\n\nPresione una tecla para continuar");
										Console.ReadKey(true);
										opcion = 2;
										break;
									case 2:
										estado = true;
										if (adm.MostrarCarro())
										{
											Console.WriteLine("Seleccione la producto para quitar del crro: ");
											string OpString = Console.ReadLine();
											int numOp = 0;
											if (SoloNumeros(OpString) && OpString == "")
											{
												numOp = int.Parse(OpString);
											}
											else
												estado = false;
											if (numOp <= 1 || numOp <= adm.promociones.Count)
											{
												adm.Eliminarproductocarro(adm.CarroCompra.productosCa, numOp);
												Console.Write("\nSe elimino el producto seleccionado.");
											}
											else
												Console.Write("se a ingresado un numero fuera de rango.");
										}
										else
											Console.WriteLine("Sin datos almacenados");
										Console.WriteLine("\n\nPresione una tecla para continuar");
										Console.ReadKey(true);
										opcion = 2;
										break;
									case 3:
										estado = true;
										if (estado)
										{
											adm.MostrarCarro();
											Console.Write("\nEl total es:{0:C}", adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa));
										}
										else
											Console.WriteLine("Sin datos almacenados");
										Console.WriteLine("\n\nPresione una tecla para continuar");
										Console.ReadKey(true);
										opcion = 2;
										//opcion = MenuOpcion(new string[]{"TIENDA "+tienda.NomPro,"MODULO CARRO"},"¿Que desea Hacer?",new string[]{"Agregar Producto al carro","Quitar Producto del carro","Listar productos del carro","volver"});
										break;

									default:
										//opcion=MenuOpcion(new string[]{"TIENDA "+tienda.NomPro,"MODULO COMPRAS"},"¿Que desea Hacer?",new string[]{"Agregar Producto al carro","Identificar cliente","volver"});
										opcion = 2;
										break;
								}
								break;
							case 2:
								estado = true;
								Menu(new string[] { "TIENDA " + tienda.NomPro, "Modulo Cliente" }, "");
								string dni;
								Console.WriteLine("ingrese Dni: ");
								dni = Console.ReadLine();
								if (tienda.BuscarCliente(dni))
								{
									Console.WriteLine("Cliente Existente");

									tienda.MostrarCliente(dni);

									Console.WriteLine("");
									Console.WriteLine("Selecciione la tarjeta con la que va a abonar");
									Console.WriteLine("");
									adm.MostrarTarjetas(adm.tarjetas);
									Console.WriteLine("");
									int ntarj = 0;
									int ncuota = 0;
									try
									{
										ntarj = int.Parse(Console.ReadLine());

									}
									catch (ArgumentOutOfRangeException)
									{
										Console.WriteLine("ERROR: FUERA DEL RAANGO PERMITIDO");
										Console.ReadKey(true);
										break;
									}
									try
									{
										Console.WriteLine(adm.tarjetas[ntarj - 1]);
										Console.WriteLine("indique la cantidad de cuotas");
										ncuota = int.Parse(Console.ReadLine());
									}
									catch (ArgumentOutOfRangeException)
									{
										Console.WriteLine("ERROR: FUERA DEL RAANGO PERMITIDO");
										Console.ReadKey(true);
										break;
									}



									//								ArrayList cuo_tar;
									//								string nom_tar;
									//								decimal total_tar = 0m ;
									//								decimal cuota ;
									//								decimal interes;


									foreach (Tarjeta elem in adm.tarjetas)
									{
										if (elem == adm.tarjetas[ntarj - 1])
										{
											cuo_tar = elem.cuotas;
											nom_tar = elem.NomTarjPro;
											total_tar = elem.TotalPro;
											foreach (Cuota e in cuo_tar)
											{
												if (ncuota == e.CuotPro)
												{
													cuota = e.CuotPro;
													interes = e.IntPro;
													Console.WriteLine("En {0} cuotas tiene un interes del {1}%", cuota, interes);
													Console.WriteLine("En el carro hay un total de {0:C}", adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa));
													Console.WriteLine("Precio total financiado: {0:C}, EN {1} CUOTAS DE {2:C}", adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100, cuota, (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100) / cuota);
													string confirmar;
													try
													{
														Console.WriteLine("Confirmar la compra? (S/N) ");
														confirmar = Console.ReadLine();
														if (confirmar != "S" && confirmar != "N")
															throw new ConfirmadoErrorException();
													}
													catch (ConfirmadoErrorException)
													{
														Console.WriteLine("ERROR: SOLO SON VALIDOS 'S' Y 'N' ");
														break;

													}

													switch (confirmar)
													{

														case "S":
															{
																totalRecaudadoTienda = totalRecaudadoTienda + (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																foreach (Cliente cli in tienda.clientes)
																{
																	if (dni == cli.DniPro)
																	{
																		cli.TotGastPro = cli.TotGastPro + (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																	}
																}
																elem.TotalPro = elem.TotalPro + (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																totalRecaudadoDesc = totalRecaudadoDesc + (adm.CalculoTotalCarroDesc(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarroDesc(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																Console.WriteLine(elem.TotalPro);

																//															foreach (Producto p in adm.productos) {
																//																if (p.DescuentoPro >= 0)
																//																	totalRecaudadoProm = totalRecaudadoProm + adm.CalculoTotalCarro(adm.CarroCompra.productosCa,adm.CarroCompra.cantidadCa)+adm.CalculoTotalCarro(adm.CarroCompra.productosCa,adm.CarroCompra.cantidadCa)*interes/100;
																//															}



																Console.WriteLine("La compra ah sido realizada.\nMuchas gracias!!!");


																adm.LimpiarCarroDeProductos();

																break;
															}
														case "N":
															{

																break;
															}
													}


												}
											}
										}
									}


									Console.ReadKey(true);
								}
								else
								{
									Console.Write("Nuevo cliente, ingrese sus datos: ");
									Console.Write("\n\nIngrese nombre: ");
									string nombre = Console.ReadLine();
									Console.Write("Ingrese apellido: ");
									string apellido = Console.ReadLine();
									Console.Write("Ingrese fecha nacimiento (DD/MM/AA): ");
									string fecha = Console.ReadLine();

									try
									{
										if (nombre == "" || apellido == "" || fecha == "")
										{
											throw new EstaVacioException();
										}
									}
									catch (EstaVacioException)
									{

										Console.WriteLine("Elemento/s vacios como para continuar con la operacion");
										Console.ReadKey(true);
										break;
									}
									tienda.AltaCliente(nombre, apellido, dni, fecha);
									Console.WriteLine("");
									Console.WriteLine("Selecciione la tarjeta con la que va a abonar");
									Console.WriteLine("");
									adm.MostrarTarjetas(adm.tarjetas);
									Console.WriteLine("");


									int ntarj = 0;
									int ncuota = 0;
									try
									{
										ntarj = int.Parse(Console.ReadLine());

									}
									catch (ArgumentOutOfRangeException)
									{
										Console.WriteLine("ERROR: FUERA DEL RAANGO PERMITIDO");
										Console.ReadKey(true);
										break;
									}
									try
									{
										Console.WriteLine(adm.tarjetas[ntarj - 1]);
										Console.WriteLine("indique la cantidad de cuotas");
										ncuota = int.Parse(Console.ReadLine());
									}
									catch (ArgumentOutOfRangeException)
									{
										Console.WriteLine("ERROR: FUERA DEL RAANGO PERMITIDO");
										Console.ReadKey(true);
										break;
									}

									foreach (Tarjeta elem in adm.tarjetas)
									{
										if (elem == adm.tarjetas[ntarj - 1])
										{
											cuo_tar = elem.cuotas;
											nom_tar = elem.NomTarjPro;
											total_tar = elem.TotalPro;
											foreach (Cuota e in cuo_tar)
											{
												if (ncuota == e.CuotPro)
												{
													cuota = e.CuotPro;
													interes = e.IntPro;
													Console.WriteLine("En {0} cuotas tiene un interes del {1}%", cuota, interes);
													Console.WriteLine("En el carro hay un total de {0:C}", adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa));
													Console.WriteLine("Precio total financiado: {0:C}, EN {1} CUOTAS DE {2:C}", adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100, cuota, (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100) / cuota);

													string confirmar;
													try
													{
														Console.WriteLine("Confirmar la compra? (S/N) ");
														confirmar = Console.ReadLine();
														if (confirmar != "S" && confirmar != "N")
															throw new ConfirmadoErrorException();
													}
													catch (ConfirmadoErrorException)
													{
														Console.WriteLine("ERROR: SOLO SON VALIDOS 'S' Y 'N' ");
														break;
													}
													switch (confirmar)
													{

														case "S":
															{
																totalRecaudadoTienda = totalRecaudadoTienda + (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																foreach (Cliente cli in tienda.clientes)
																{
																	if (dni == cli.DniPro)
																	{
																		cli.TotGastPro = cli.TotGastPro + (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																	}
																}
																elem.TotalPro = elem.TotalPro + (adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarro(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																totalRecaudadoDesc = totalRecaudadoDesc + (adm.CalculoTotalCarroDesc(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) + adm.CalculoTotalCarroDesc(adm.CarroCompra.productosCa, adm.CarroCompra.cantidadCa) * interes / 100);
																Console.WriteLine(elem.TotalPro);

																//															foreach (Producto p in adm.productos) {
																//																if (p.DescuentoPro >= 0)
																//																	totalRecaudadoProm = totalRecaudadoProm + adm.CalculoTotalCarro(adm.CarroCompra.productosCa,adm.CarroCompra.cantidadCa)+adm.CalculoTotalCarro(adm.CarroCompra.productosCa,adm.CarroCompra.cantidadCa)*interes/100;
																//															}



																Console.WriteLine("La compra ah sido realizada.\nMuchas gracias!!!");


																adm.LimpiarCarroDeProductos();

																break;
															}
														case "N":
															{

																break;
															}
													}


												}
											}
										}
									}

									Console.ReadKey(true);

								}

								break;
							default:
								opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro }, "¿A que modulo desea entrar?", new string[] { "Producto y Promociones", "Compras", "Tarjetas de credito", "Administracion", "Salir del sistema" });
								break;

						}
						break;

					//**************************************************MODULO TARJETAS*************************************

					case 3:
						estado = true;
						opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro, "MODULO TARJETAS" }, "¿Que desea Hacer?", new string[] { "Agregar Tarjeta", "Agregar beneficios", "listar Tarjetas", "Listar tarjetas con beneficios", "Volver" });
						switch (opcion)
						{
							case 1:
								estado = true;
								Console.Write("\ningrese Tarjeta: ");
								string NomTar = Console.ReadLine();
								Console.Write("Ingrese Banco: ");
								string NomBan = Console.ReadLine();
								Console.Write("Ingrese cantidad de formas de pago: ");
								string cantForString = Console.ReadLine();
								int cantFormPag = 0;

								if (SoloNumeros(cantForString) && cantForString != "")
								{
									cantFormPag = Convert.ToInt32(cantForString);
								}
								else
									estado = false;
								if (estado && NomTar != "" && NomBan != "")
								{
									if (adm.AltaTarjeta(NomTar, NomBan, cantFormPag))
										Console.Write("\nSe agrego correctamente la Tarjeta");
									else
										Console.Write("No se admiten datos duplicados");

								}
								else
									Console.WriteLine("\nHay un error en los datos ingresados, el producto no fue dado de alta.");

								Console.WriteLine("\n\nPresione una tecla para continuar");
								Console.ReadKey(true);
								opcion = 3;
								break;
							case 2:
								estado = true;
								if (estado)
								{


									adm.MostrarTarjetas(adm.tarjetas);
									Console.Write("\n seleccione una tarjeta para el beneficio:");
									string NumOpString = Console.ReadLine();
									int NumOp = 0;
									if (SoloNumeros(NumOpString) && NumOpString != "")
									{
										NumOp = int.Parse(NumOpString);

									}
									else
										estado = false;
									Console.Write("Ingrese cantidad de cuotas: ");
									int cantCuo = Convert.ToInt32(Console.ReadLine());

									Console.Write("Ingrese interes: ");

									int cantInt = Convert.ToInt32(Console.ReadLine());
									adm.AltaBeneficiosTarje(NumOp, cantCuo, cantInt);

									//                                	if(estado)
									//                                	{
									//                                		if(adm.AltaPromocion(num,descuento,(Producto)adm.productos[num-1]))
									//                                			Console.WriteLine("La promocion de productos fue dada de alta.");
									//                                		
									//                                	}



									Console.ReadKey(true);
								}
								else
									Console.Write("\nNo se pudo dar de alta el beneficio");


								opcion = 3;

								break;
							case 3:
								estado = true;
								if (estado)
								{
									//
									adm.MostrarTarjetas(adm.tarjetas);


								}
								else
									Console.WriteLine("Sin datos almacenados");
								Console.WriteLine("\n\nPresione una tecla para continuar");

								Console.ReadKey(true);
								opcion = 3;

								break;
							case 4:
								estado = true;
								if (estado)
								{
									//
									adm.MostrarTarjetas(adm.beneficios);
									Console.ReadKey(true);
								}
								else
									Console.WriteLine("Sin datos almacenados");
								Console.WriteLine("\n\nPresione una tecla para continuar");
								Console.ReadKey(true);
								opcion = 3;
								break;




							default:
								opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro }, "¿A que modulo desea entrar?", new string[] { "Producto y Promociones", "Compras", "Tarjetas de credito", "Administracion", "Salir del sistema" });

								break;
						}
						break;
					//**************************************************MODULO ADMINISTRACION*************************************
					case 4:
						estado = true;
						opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro, "MODULO ADMINISTRATIVO" }, "Seleccione una opcion", new string[] { "Monto total recaudado por la tienda", "Monto total abonado por cliente", "Monto total abonado con tarjeta", "Monto total correspondiente a descuentos efectuados en las ventas", "Volver" });
						switch (opcion)
						{
							case 1:
								estado = true;

								//								tienda.TotalVendidoEnTienda(totalRecaudadoTienda,totalRecaudadoTienda.Count-1);
								//								Console.WriteLine(tienda.TotalVendidoEnTienda(totalRecaudadoTienda,totalRecaudadoTienda.Count-1));
								tienda.TotalVendidoEnTienda(totalRecaudadoTienda);

								Console.WriteLine("\n\nPresione una tecla para continuar");
								Console.ReadKey(true);
								opcion = 4;
								break;
							case 2:
								estado = true;


								tienda.TotalAbonadoCliente(tienda.clientes, tienda.clientes.Count - 1);

								Console.ReadKey(true);
								opcion = 4;

								break;
							case 3:
								estado = true;

								adm.TotalVendidoPorTarjeta();

								Console.ReadKey(true);
								opcion = 4;

								break;
							case 4:
								estado = true;
								adm.TotalVendidoDesc(totalRecaudadoDesc);
								Console.ReadKey(true);
								opcion = 4;
								break;




							default:
								opcion = MenuOpcion(new string[] { "TIENDA " + tienda.NomPro }, "¿A que modulo desea entrar?", new string[] { "Producto y Promociones", "Compras", "Tarjetas de credito", "Administracion", "Salir del sistema" });

								break;
						}
						break;


				}


			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void Lineas(string[] frase)
		{
			int ancho = Console.WindowWidth, linea = frase.Length;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.Write(String.Concat(Enumerable.Repeat("*", ancho)));
			for (int i = 1; i <= linea; i++)
			{
				Console.SetCursorPosition(0, i);
				Console.Write("*****");
				Console.SetCursorPosition(ancho - 5, i);
				Console.Write("*****");
				Console.SetCursorPosition(((ancho - frase[i - 1].Length) / 2), i);
				Console.Write(frase[i - 1]);
			}
			Console.SetCursorPosition(0, linea + 1);
			Console.Write(String.Concat(Enumerable.Repeat("*", ancho)));
		}
		public static bool SoloNumeros(string n)
		{
			foreach (char caracter in n)
			{
				if (!char.IsDigit(caracter) && caracter != '.')
				{
					return false;
				}
			}
			return true;
		}
		public static void Menu(string[] titulo, string frase)
		{
			int ancho = Console.WindowWidth, tope = titulo.Length + 3;

			Lineas(titulo);
			if (frase != "")
			{
				Console.SetCursorPosition((ancho - frase.Length) / 2, tope);
				Console.WriteLine(frase);
			}
			else if (tope > 3)
			{
				tope -= 2;
			}


		}
		public static int MenuOpcion(string[] titulo, string frase, string[] frases)
		{
			int opcion = -1, ancho = Console.WindowWidth, tope = titulo.Length + 3;

			do
			{
				Lineas(titulo);

				if (frase != "")
				{
					Console.WriteLine("");
					//					Console.SetCursorPosition((ancho-frase.Length)/2,tope);
					Console.WriteLine(frase);
					Console.WriteLine("");
				}
				else if (tope > 3)
				{
					tope -= 2;
				}

				int i;
				for (i = 0; i < frases.Length; i++)
				{
					//					Console.SetCursorPosition((ancho-frases[i].Length)/2,tope+i+2);

					Console.WriteLine("{0}){1}", i + 1, frases[i]);
				}
				if (opcion > frases.Length || opcion == 0)
				{
					string mensaj = "Error. Solo valores del 1 al " + frases.Length + ".";
					Console.SetCursorPosition((ancho - mensaj.Length) / 2, tope + i + 4);
					Console.WriteLine("{0}", mensaj);
					opcion = -1;
				}
				//				Console.SetCursorPosition((ancho-"opcion: ".Length)/2,tope+i+3);
				Console.Write("OPCION: ");
				//				string variable=Console.ReadKey().KeyChar.ToString();
				string variable = Console.ReadLine();
				Console.WriteLine();
				if (SoloNumeros(variable))
				{

					try
					{
						opcion = Int32.Parse(variable);
					}
					catch (FormatException)
					{

						Console.WriteLine("ERROR: EL FORMATO NO ES ACEPTADO PARA CONTINUAR");
						Console.ReadKey(true);

					}
				}
				else
					opcion = 0;


			} while (opcion > frases.Length || opcion <= 0);
			//Console.SetCursorPosition(0,0);
			return opcion;

		}

	}


}



