﻿using TestApplication.Types;

namespace TestApplication.StructureMap.RegistryTests
{
    public class RegistryInstanceConfigure
    {
        public RegistryInstanceConfigure()
        {
            var registry = new global::StructureMap.Configuration.DSL.Registry();
            registry.For<IFoo>().Use<Foo>();
        }
    }
}