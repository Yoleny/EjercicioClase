

SuperHeroe superHeroes = new SuperHeroe();
superHeroes.nombre = " Iro Man ";
superHeroes.identidadSecreta = " Anthony Edward Stark";
superHeroes.ciudad = " Manhattan";
superHeroes.superPoder = " Super Fuerza";
superHeroes.descripcion = " Capacidad de levantar objetos pesados";
superHeroes.nivel = " 8 ";

Console.WriteLine("Nombre: " + superHeroes.nombre);
Console.WriteLine("identidadSecreta:" + superHeroes.identidadSecreta);
Console.WriteLine("ciudad:" + superHeroes.ciudad);
Console.WriteLine("Puede volar:" + superHeroes.puedeVolar);
Console.WriteLine("superPoder: " + superHeroes.superPoder);
Console.WriteLine("Descripcion: " + superHeroes.descripcion);
Console.WriteLine("Es nivel:" + superHeroes.nivel);


superHeroes.nombre = " Batman ";
superHeroes.identidadSecreta = " Bruce Wayne";
superHeroes.ciudad = "Ciudad Gotica ";
superHeroes.superPoder = "No tiene";
superHeroes.descripcion = " Recurre a su intelecto, asi como aploaccionesncientificas para crear armar y herramientas";
superHeroes.nivel = " 6 ";

Console.WriteLine("Nombre: " + superHeroes.nombre);
Console.WriteLine("identidadSecreta:" + superHeroes.identidadSecreta);
Console.WriteLine("ciudad:" + superHeroes.ciudad);
Console.WriteLine("Puede volar:" + superHeroes.puedeVolar);
Console.WriteLine("superPoder: " + superHeroes.superPoder);
Console.WriteLine("Descripcion: " + superHeroes.descripcion);
Console.WriteLine("Es nivel:" + superHeroes.nivel);

superHeroes.nombre = " Doctor Strange ";
superHeroes.identidadSecreta = " Stephen Strange";
superHeroes.ciudad = "Ciudad Gotica ";
superHeroes.superPoder = " Poderes misticos";
superHeroes.descripcion = " Teletranspoirtacion, generacion de iluiones y proyeccion de energia";
superHeroes.nivel = " 8 ";


Console.WriteLine("Nombre: " + superHeroes.nombre);
Console.WriteLine("identidadSecreta:" + superHeroes.identidadSecreta);
Console.WriteLine("ciudad:" + superHeroes.ciudad);
Console.WriteLine("Puede volar:" + superHeroes.puedeVolar);
Console.WriteLine("superPoder: " + superHeroes.superPoder);
Console.WriteLine("Descripcion: " + superHeroes.descripcion);
Console.WriteLine("Es nivel:" + superHeroes.nivel);

public class SuperHeroe
{
    public string nombre { get; set; }
    public string identidadSecreta { get; set; }
    public string ciudad { get; set; }
    public  bool puedeVolar { get; set; }
    public string superPoder { get; set; }

    public string descripcion { get; set; }
   
    public string nivel { get; set; }

    public SuperHeroe()
    {
        puedeVolar = true;
       
    }


}

public class Superpoder
{
    public string nombre { get; set; }
    public string descripcion { get; set; }

    public string nivel { get; set;}

}