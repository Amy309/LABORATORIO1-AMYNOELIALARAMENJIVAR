// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using LABORATORIO1_AMY_NOELIA_LARA_MENJIVAR.Entidades;
using LABORATORIO1_AMY_NOELIA_LARA_MENJIVAR.Negocio;

Persona persona = new Persona();
ClsPersona Clspersona= new ClsPersona();

Console.WriteLine("Ingrese su nombre");
persona.Nombre = (Console.ReadLine());

Console.WriteLine("Ingrese su edad");
persona.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su sexo");
persona.Sexo = (Console.ReadLine());

Console.WriteLine("Ingrese peso en Kg");
persona.Peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese altura en metros");
persona.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Clspersona.Calcular(persona));
Console.WriteLine(Clspersona.MayorEdad(persona));