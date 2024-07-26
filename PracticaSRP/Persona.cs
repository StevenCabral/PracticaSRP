namespace PracticaSRP
{
	public abstract class Persona
	{
		public string Nombre { get; set; }
		public int Edad { get; set; }
		public string Direccion { get; set; }
		public string CorreoElectronico { get; set; }

		public void Registrar()
		{
			Console.WriteLine("Introduzca el nombre de la persona: ");
			Nombre = Console.ReadLine();
			Console.WriteLine("Introduzca la edad que tiene la persona");
			Edad = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Introduzca la direccion de residencia:");
			Direccion = Console.ReadLine();
			Console.WriteLine("Coloque la direccion de correo electronico:");
			CorreoElectronico = Console.ReadLine();

		}
		public abstract void ImprimirDatos();
	}
}
