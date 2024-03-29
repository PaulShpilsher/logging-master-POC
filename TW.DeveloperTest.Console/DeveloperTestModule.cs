﻿using Ninject.Modules;
using TW.DeveloperTest.Contracts;
using TW.DeveloperTest.Logger;
using TW.DeveloperTest.WorkLibrary;

namespace TW.DeveloperTest.ConsoleApp
{
    public class DeveloperTestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<ConsoleLogger>();
            Bind<IWorker>().To<SampleWorker>();
        }
    }
}
