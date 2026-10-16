using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Test
    {
        static void Main(string[] args)
        {

            // Pruebas Alumno
            /* Console.WriteLine("Se crea un alumno: ");
             Alumno al1 = new Alumno("Juan", "Rodriguez", new DateTime(2000, 09, 10), "JuanRodriguez@gmai.com", 43513, new DateTime(2024, 1, 10), "Tecnico superior en Computacion");
             Console.WriteLine(al1.ToString() + "\n");

             Console.WriteLine("Alumno Copiado: ");
             Alumno al2 = new Alumno();
             al2.Copy(al1);
             Console.WriteLine(al2.ToString() + "\n");

             Console.WriteLine("Alumno Clonado: ");
             Alumno al3 = al2.Clone();
             Console.WriteLine(al3.ToString() + "\n");

             Console.WriteLine($"Ambos alumnos son iguales? {al1.Equals(al3)}");*/



            // Pruebas Profesor
            /* Console.WriteLine("Se crea un Prfesor: ");
             Profesor p1 = new Profesor("Juan", "Rodriguez", new DateTime(2000, 09, 10), "JuanRodriguez@gmai.com",321351, "Ingeniero en Sistemas de Informacion");
             Console.WriteLine(p1.ToString() + "\n");

             Console.WriteLine("profesor Copiado: ");
             Profesor p2 = new Profesor();
             p2.Copy(p1);
             Console.WriteLine(p2.ToString() + "\n");

             Console.WriteLine("Profesor Clonado: ");
             Profesor p3 = p1.Clone();
             Console.WriteLine(p3.ToString() + "\n");

             Console.WriteLine($"Ambos profesores son iguales? {p1.Equals(p3)}");
            */



            //Pruebas Curso

        /*    Alumno al1 = new Alumno("Juan", "Rodriguez", new DateTime(2000, 09, 10), "JuanRodriguez@gmai.com", 43513, new DateTime(2024, 1, 10), "Tecnico superior en Computacion");
            Alumno al2 = new Alumno("Pedro", "Perez", new DateTime(2000, 09, 10), "PedroP@gmai.com", 555, new DateTime(2024, 1, 10), "Tecnico superior en Computacion");
            Alumno al3 = new Alumno("Martin", "Gomez", new DateTime(2000, 09, 10), "Mgomez@gmai.com", 503, new DateTime(2024, 1, 10), "Tecnico superior en Computacion");

            Instituto instituto = new Instituto(20,"Instituto de ingles san jorge","Alem 750", 5555738, "Juan Rodriguez");

            Profesor profesor1 = new Profesor("Maria", "Muller", new DateTime(2000, 09, 10), "MullerMaria@gmai.com", 321351, "Ingeniero en Sistemas de Informacion");


            Curso curso1 = new CursoUniversitario(001, "matematicas", "Aula 9", "18:00 - 20:00 Lun y Mier", profesor1);

            //probando cursoExterno
            Curso curso2 = new CursoExterno(002, "Ingles", instituto);
            curso2.AgregatAlumnos(al1);
            curso2.AgregatAlumnos(al2);
            curso2.AgregatAlumnos(al3);
            Console.WriteLine($"Probando Curso Externo {curso2.ToString()} \n \n");




            curso1.AgregatAlumnos(al1);
            curso1.AgregatAlumnos(al2);
            curso1.AgregatAlumnos(al3);

            Console.WriteLine(curso1.ToString());

            Console.WriteLine("\n Probando el Metodo de Obtener Alumnos");
            Console.WriteLine(curso1.GetAlumnos());
            Console.ReadLine();*/
        }
    }
}
