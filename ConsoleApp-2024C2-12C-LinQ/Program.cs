namespace ConsoleApp_2024C2_12C_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudiante[] misEsudiantes =
            {
                new Estudiante() {Id = 1, Nombre = "Juan", Edad = 18},
                new Estudiante() {Id = 2, Nombre = "Daniel", Edad = 14},
                new Estudiante() {Id = 3, Nombre = "Fernanda", Edad = 27},
                new Estudiante() {Id = 4, Nombre = "Nadia", Edad = 13},
                new Estudiante() {Id = 5, Nombre = "Ayelen", Edad = 25},
                new Estudiante() {Id = 6, Nombre = "Cecilia", Edad = 29},
                new Estudiante() {Id = 7, Nombre = "Mariano", Edad = 19},
                new Estudiante() {Id = 8, Nombre = "German", Edad = 21},
            };

            Estudiante[] misEstudantesSalida = new Estudiante[10];
            int i = 0;
            foreach (var elemEstu in misEsudiantes)
            {
                if (elemEstu.Edad >= 13 && elemEstu.Edad <=19) 
                {
                    misEstudantesSalida[i] = elemEstu;
                    i++;
                }
            }

            for (int x = 0; x < i; x++)
            {
                Console.WriteLine("Nombre: " + misEstudantesSalida[x].Nombre + " Edad: " + misEstudantesSalida[x].Edad);
            }

            Console.ReadKey();


            Console.WriteLine("LinQ - Expresion de Consulta");
            var consultaEstudiantes = from s in misEsudiantes where s.Edad >= 13 && s.Edad <= 19 select s;
            foreach (var itemConsulta in consultaEstudiantes)
            {
                Console.WriteLine("Nombre:" + itemConsulta.Nombre + " Edad: " + itemConsulta.Edad);
            }

            Console.ReadKey();

            Console.WriteLine("LinQ - Expresion Lambda");
            var consultaEstudiantesLambda = misEsudiantes.Where(estu => estu.Edad >= 13 && estu.Edad <= 19);
            foreach (var itemConsultaLambda in consultaEstudiantesLambda)
            {
                Console.WriteLine("Nombre:" + itemConsultaLambda.Nombre + " Edad: " + itemConsultaLambda.Edad);
            }
            Console.WriteLine("Fin");
        }
    }
}
