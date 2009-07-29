﻿using System;
using System.Collections.Generic;
using System.Reflection;
using NServiceBus.ObjectBuilder.Common;

namespace NServiceBus.Host
{
    /// <summary>
    /// Container class for interface specifications.
    /// Implement the contained interfaces on the class which implements <see cref="IConfigureThisEndpoint"/>.
    /// </summary>
    public class ISpecify
    {
        /// <summary>
        /// Specify the name of the endpoint that will be used as the name of the installed Windows Service
        /// instead of the default name.
        /// </summary>
        public interface EndpointName
        {
            string EndpointName { get; }
        }
        
        /// <summary>
        /// Specify the types to be configured in the endpoint.
        /// </summary>
        public interface TypesToScan
        {
            IEnumerable<Type> TypesToScan { get; }
        }

        /// <summary>
        /// Specify the assemblies whose types will be configured in the endpoint.
        /// </summary>
        public interface AssembliesToScan
        {
            IEnumerable<Assembly> AssembliesToScan { get; }
        }

        /// <summary>
        /// Specify the directory that will be scanned, and whose assembly files will be loaded and their types scanned.
        /// </summary>
        public interface ProbeDirectory
        {
            string ProbeDirectory { get; }
        }

        /// <summary>
        /// Specify additional code to be run at startup.
        /// </summary>
        public interface StartupAction
        {
            Action StartupAction { get; }
        }

        /// <summary>
        /// Specify the type of container that will be used for dependency injection in the endpoint.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface ContainerTypeToUse<T> where T : IContainer
        {
        }

        /// <summary>
        /// Specify a container instance that will be used for dependency injection in the endpoint.
        /// </summary>
        public interface ContainerInstanceToUse
        {
            IContainer ContainerInstance { get; }
        }

        /// <summary>
        /// Specify the type of endpoint that will be run after configuration is complete.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface ToRun<T> where T : IMessageEndpoint
        {
            
        }

        /// <summary>
        /// Specify that the XML serializer should be used.
        /// </summary>
        public interface ToUseXmlSerialization
        {
            
        }

        /// <summary>
        /// Specify the XML serialization namespace that should be used.
        /// </summary>
        public interface XmlSerializationNamespace
        {
            /// <summary>
            /// The XML serialization namespace.
            /// </summary>
            string Namespace { get; }
        }

        /// <summary>
        /// Specify that serialization will be independently configured in the container
        /// </summary>
        public interface MyOwnSerialization : IWantCustomInitialization
        {
            
        }

        /// <summary>
        /// Specify that saga persistence will be independently configured.
        /// </summary>
        public interface MyOwnSagaPersistence : IWantCustomInitialization
        {
            
        }

        /// <summary>
        /// Specify that Log4Net will be independently configured.
        /// </summary>
        public interface MyOwnLog4NetConfiguration
        {
            void ConfigureLog4Net();
        }

        /// <summary>
        /// Specify the level at which logging will be performed.
        /// </summary>
        public interface LoggingLevel
        {
            log4net.Core.Level Level { get; }
        }

        /// <summary>
        /// Specify the order in which message handlers will be invoked.
        /// </summary>
        public interface MessageHandlerOrdering
        {
            void SpecifyOrder(Order order);
        }

        /// <summary>
        /// Specifies that the nhibernate subscriptionn storage should be used
        /// </summary>
        public interface ToUseNHibernateSubscriptionStorage{}
    }
}
