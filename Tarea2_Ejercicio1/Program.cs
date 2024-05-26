using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string numeroIdentificacion = ".";
            string nombreEmpleado = ".";
            int codigoEmpleado = 0;
            double cantidadHoras = 0.0;
            double valorHora = 0.0;
            double salarioOrdinario = 0.0;
            string tipoEmpleado = ".";
            double aumento = 0.0;
            double deducciones = 0.0;
            int cantidadEmpleadosOp = 0;
            double acumuladoSalariosNetoOp = 0.0;
            double promedioSalariosNetosOp = 0.0;
            double salarioBruto = 0.0;
            double salarioNeto = 0.0;
            int contador = 1;
            int contadorProf = 1;
            int contadorTec = 1;
            int cantidadEmpleadosTec = 0;
            double acumuladoSalariosNetoTec = 0.0;
            double promedioSalariosNetosTec = 0.0;

            int cantidadEmpleadosProf = 0;
            double acumuladoSalariosNetoProf = 0.0;
            double promedioSalariosNetosProf = 0.0;


            do
            {
                Console.WriteLine("Si desea hacer un registro, digite la opción (1) y  si desea salir del sistema digite la opción (2)");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    while (menu == 1)
                    {
                        Console.WriteLine("Ingrese el código del empleado, siendo (1) Operarios, (2) Tecnicos y (3) Profesionales):      ");
                        codigoEmpleado = int.Parse(Console.ReadLine());

                        if (codigoEmpleado == 1)
                        {
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Ingrese el numero de identificacion del empleado:      ");
                            numeroIdentificacion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del empleado:      ");
                            nombreEmpleado = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio por hora:      ");
                            valorHora = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de horas laboradas:      ");
                            cantidadHoras = double.Parse(Console.ReadLine());
                            Console.WriteLine("                                                                                       ");
                            salarioOrdinario = cantidadHoras * valorHora;
                            salarioBruto = salarioOrdinario * 1.15;
                            tipoEmpleado = "Operario";
                            aumento = salarioBruto - salarioOrdinario;
                            salarioNeto = salarioBruto - (salarioBruto * 0.0917);
                            deducciones = salarioBruto - salarioNeto;

                            cantidadEmpleadosOp = contador++;
                            acumuladoSalariosNetoOp += salarioNeto;
                            promedioSalariosNetosOp = acumuladoSalariosNetoOp / cantidadEmpleadosOp;
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Numero de Identificacion :      {0}", numeroIdentificacion);
                            Console.WriteLine("Nombre del empleado:      {0}", nombreEmpleado);
                            Console.WriteLine("Tipo de trabajador:      {0}", tipoEmpleado);
                            Console.WriteLine("Salario por hora:      {0} Colones", valorHora);
                            Console.WriteLine("Cantidad de horas laboradas:      {0}", cantidadHoras);
                            Console.WriteLine("Salario ordinario    :      {0} Colones", salarioOrdinario);
                            Console.WriteLine("Aumento    :      {0} Colones", aumento);
                            Console.WriteLine("Salario bruto:      {0} Colones", salarioBruto);
                            Console.WriteLine("Deducciones CCSS:      -{0} Colones", deducciones);
                            Console.WriteLine("Salario neto:      {0} Colones", salarioNeto);
                            Console.WriteLine("                                                                                       ");
                        }
                        else if (codigoEmpleado == 2)
                        {
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Ingrese el numero de identificacion del empleado:      ");
                            numeroIdentificacion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del empleado:      ");
                            nombreEmpleado = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio por hora:      ");
                            valorHora = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de horas laboradas:      ");
                            cantidadHoras = double.Parse(Console.ReadLine());
                            Console.WriteLine("                                                                                       ");
                            salarioOrdinario = cantidadHoras * valorHora;
                            salarioBruto = salarioOrdinario * (1 + 0.10);
                            tipoEmpleado = "Tecnico";
                            aumento = salarioBruto - salarioOrdinario;
                            salarioNeto = salarioBruto - (salarioBruto * 0.0917);
                            deducciones = salarioBruto - salarioNeto;

                            cantidadEmpleadosTec = contadorTec++;
                            acumuladoSalariosNetoTec += salarioNeto;
                            promedioSalariosNetosTec = acumuladoSalariosNetoTec / cantidadEmpleadosTec;
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Numero de Identificacion :      {0}", numeroIdentificacion);
                            Console.WriteLine("Nombre del empleado:      {0}", nombreEmpleado);
                            Console.WriteLine("Tipo de trabajador:      {0}", tipoEmpleado);
                            Console.WriteLine("Salario por hora:      {0} Colones", valorHora);
                            Console.WriteLine("Cantidad de horas laboradas:      {0}", cantidadHoras);
                            Console.WriteLine("Salario ordinario    :      {0} Colones", salarioOrdinario);
                            Console.WriteLine("Aumento    :      {0} Colones", aumento);
                            Console.WriteLine("Salario bruto:      {0} Colones", salarioBruto);
                            Console.WriteLine("Deducciones CCSS:      -{0} Colones", deducciones);
                            Console.WriteLine("Salario neto:      {0} Colones", salarioNeto);
                            Console.WriteLine("                                                                                       ");


                        }

                        else if (codigoEmpleado == 3)
                        {
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Ingrese el numero de identificacion del empleado:      ");
                            numeroIdentificacion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del empleado:      ");
                            nombreEmpleado = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio por hora:      ");
                            valorHora = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de horas laboradas:      ");
                            cantidadHoras = double.Parse(Console.ReadLine());
                            Console.WriteLine("                                                                                       ");
                            salarioOrdinario = cantidadHoras * valorHora;
                            salarioBruto = salarioOrdinario * (1 + 0.05);
                            tipoEmpleado = "Profesionales";
                            aumento = salarioBruto - salarioOrdinario;
                            salarioNeto = salarioBruto - (salarioBruto * 0.0917);
                            deducciones = salarioBruto - salarioNeto;

                            cantidadEmpleadosProf = contadorProf++;
                            acumuladoSalariosNetoProf += salarioNeto;
                            promedioSalariosNetosProf = acumuladoSalariosNetoProf / cantidadEmpleadosProf;

                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Numero de Identificacion :      {0}", numeroIdentificacion);
                            Console.WriteLine("Nombre del empleado:      {0}", nombreEmpleado);
                            Console.WriteLine("Tipo de trabajador:      {0}", tipoEmpleado);
                            Console.WriteLine("Salario por hora:      {0} Colones", valorHora);
                            Console.WriteLine("Cantidad de horas laboradas:      {0}", cantidadHoras);
                            Console.WriteLine("Salario ordinario    :      {0} Colones", salarioOrdinario);
                            Console.WriteLine("Aumento    :      {0} Colones", aumento);
                            Console.WriteLine("Salario bruto:      {0} Colones", salarioBruto);
                            Console.WriteLine("Deducciones CCSS:      -{0} Colones", deducciones);
                            Console.WriteLine("Salario neto:      {0} Colones", salarioNeto);
                            Console.WriteLine("                                                                                       ");

                        }
                        else
                        {
                            Console.WriteLine("*****LA OPCION DIGITADA, NO ES VALIDAD *****");
                            Console.WriteLine("                                                                                       ");
                        }

                        Console.WriteLine("Si desea hacer un registro, digite la opción (1) y  si desea salir del sistema digite la opción (2)");
                        menu = int.Parse(Console.ReadLine());
                    }

                }

            } while (menu != 2);
            Console.WriteLine("************************************ESTADISTICAS DEL REGISTRO************************************");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("----------EMPLEADOS OPERARIOS----------");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("Cantidad Empleados Tipo Operarios:      {0}", cantidadEmpleadosOp);
            Console.WriteLine("Acumulado Salario Neto para Operarios:    {0} Colones", acumuladoSalariosNetoOp);
            Console.WriteLine("Promedio Salario Neto para Operarios :    {0} Colones", promedioSalariosNetosOp);
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("----------EMPLEADOS TECNICOS----------");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("Cantidad Empleados Tipo Tecnicos:      {0}", cantidadEmpleadosTec);
            Console.WriteLine("Acumulado Salario Neto para Tecnicos:    {0} Colones", acumuladoSalariosNetoTec);
            Console.WriteLine("Promedio Salario Neto para Tecnicos :    {0} Colones", promedioSalariosNetosTec);
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("----------EMPLEADOS PROFESIONALES----------");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("Cantidad Empleados Tipo Profesionales:      {0}", cantidadEmpleadosProf);
            Console.WriteLine("Acumulado Salario Neto para Profesionales:    {0} Colones", acumuladoSalariosNetoProf);
            Console.WriteLine("Promedio Salario Neto para Profesionales :    {0} Colones", promedioSalariosNetosProf);
            Console.WriteLine("                                                                                       ");
            Console.Read();


        }
    }
}
