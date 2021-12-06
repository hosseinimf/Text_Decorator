using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Text_Decorator.TextDecorator;

namespace Text_Decorator
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<Application>().As<IApplication>();

            //builder.RegisterType<RegularText>().As<IRegularText>();
            //builder.RegisterType<TextDecorat>(). ;
            //builder.RegisterType<BoldText>().As<IBoldText>();
            //builder.RegisterType<ItalicText>().As<IItalicText>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("TextDecorator"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name));

            return builder.Build();
        }
    }
}
