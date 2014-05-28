﻿namespace NServiceBus.InMemory.SagaPersister
{
    using Features;

    public class InMemorySagaPersistence:Feature
    {
        public InMemorySagaPersistence()
        {
            DependsOn<Sagas>();
        }

        protected override void Setup(FeatureConfigurationContext context)
        {
            context.Container.ConfigureComponent<InMemorySagaPersister>(DependencyLifecycle.SingleInstance);
        }
    }
}