﻿using Hangfire.Unity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire
{
    /// <summary>
    /// Extensions class for unity
    /// </summary>
    public static class UnityBootstrapperConfigurationExtensions
    {
        /// <summary>
        /// Tells bootstrapper to use the specified Ninject
        /// kernel as a global job activator.
        /// </summary>
        /// <param name="configuration">Configuration</param>
        /// <param name="container">The unity container that will be used to activate jobs</param>
        public static void UseUnityActivator(this IBootstrapperConfiguration configuration, IUnityContainer container)
        {
            configuration.UseActivator(new UnityJobActivator(container));
        }
    }
}
