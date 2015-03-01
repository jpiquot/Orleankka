﻿using System;
using System.Linq;

using NUnit.Framework;

namespace Orleankka
{
    [TestFixture]
    public class TodoFixture
    {
        [Test, Ignore]
        public void Envelopes()
        {
            // - Envelope and Body attribute
            // - Proper selection of Receive channel based on Body type
            // - Proper dispatching based on Body type
        }

        [Test, Ignore]
        public void AutomaticDeactivation()
        {
            // - Add support for per-type idle deactivation timeouts
        }

        [Test, Ignore]
        public void Serialization()
        {
            // - Add support for native Orleans serializer
        }

        [Test, Ignore]
        public void Samples()
        {
            // - Add DI container sample (Unity)
            // - Add ProtoBuf/Bond serialization sample
            // - Add Azure CloudService sample
        }

        [Test, Ignore]
        public void AzureSystem()
        {
            // - Finish actor system configuration
        }

        [Test, Ignore]
        public void ActorPrototype()
        {
            // - Prototype extensibility?
        }

        [Test, Ignore]
        public void MutableMessages()
        {
            // - Add support (deep-copy) for mutable (yay) messages
        }
    }
}
