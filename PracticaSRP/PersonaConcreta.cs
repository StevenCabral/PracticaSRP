namespace PracticaSRP
{
	internal class PersonaConcreta : Persona
	{
		public override void ImprimirDatos()
		{
			Console.WriteLine($"Nombre: {Nombre}");
			Console.WriteLine($"Edad: {Edad}");
			Console.WriteLine($"Direccion: {Direccion}");
			Console.WriteLine($"Correo Electronico: {CorreoElectronico}");
		}
	}
}
