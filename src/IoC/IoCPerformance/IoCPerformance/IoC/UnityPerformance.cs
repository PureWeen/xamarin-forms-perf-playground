﻿using IoCPerformance.IoC.Base;
using IoCPerformance.Services.Test;
using Unity;

namespace IoCPerformance.IoC
{
    public class UnityPerformance : IPerformance
    {
        private readonly int _numberOfTests;

        private readonly IUnityContainer _unityContainer;

        public UnityPerformance(int numberOfTests)
        {
            _unityContainer = new UnityContainer();
            _numberOfTests = numberOfTests;
        }

        public void Registration()
        {
            for (int x = 0; x < _numberOfTests; x++)
            {
                _unityContainer.RegisterType<ITestService, TestService>(string.Format("Class{0}", x));
            }
        }

        public void Resolve()
        {
            for (int x = 0; x < _numberOfTests; x++)
            {
                _unityContainer.Resolve<ITestService>(string.Format("Class{0}", x));
            }
        }
    }
}