using PracticaSRP;


Persona persona = new PersonaConcreta();
ImpresionService imprimir = new ImpresionService();
CorreoElectronicoService correoElectronicoService = new CorreoElectronicoService();

persona.Registrar();
imprimir.ImprimirDatos(persona);
correoElectronicoService.EnviarCorreoElectronico();

