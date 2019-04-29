using Aplicacion.Contratos;
using Aplicacion.Servicios;
using Autofac;
using Contratos;
using Datos.Repositorios;
using Dominio.Contrato;
using Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class Contenedor
    {
        public static ContainerBuilder Contain(ContainerBuilder build)
        {
            build.RegisterType(typeof(PersonaRepositorio)).As(typeof(IPersonaRepositorio)).InstancePerLifetimeScope();
            build.RegisterType(typeof(PersonaDominio)).As(typeof(IPersonaDominio)).InstancePerLifetimeScope();
            build.RegisterType(typeof(PersonaServicio)).As(typeof(IPersonaServicio)).InstancePerLifetimeScope();

            return build;
        }
    }
}
