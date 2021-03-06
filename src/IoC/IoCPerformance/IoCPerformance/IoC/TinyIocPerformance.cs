﻿using IoCPerformance.IoC.Base;
using IoCPerformance.Services.Test;
using TinyIoC;

namespace IoCPerformance.IoC
{
    public class TinyIocPerformance : IPerformance
    {
        private readonly int _numberOfTests;

        private TinyIoCContainer _container { get; set; }

        public TinyIocPerformance(int numberOfTests)
        {
            _numberOfTests = numberOfTests;
            _container = TinyIoCContainer.Current;
        }

        public void Registration()
        {
            for (int x = 0; x < _numberOfTests; x++)
            {
                _container.Register<TestService>(string.Format("Class{0}", x));
            }
        }

        public void Resolve()
        {
            for (int x = 0; x < _numberOfTests; x++)
            {
                _container.Resolve<TestService>(string.Format("Class{0}", x));
            }
        }
    }
}