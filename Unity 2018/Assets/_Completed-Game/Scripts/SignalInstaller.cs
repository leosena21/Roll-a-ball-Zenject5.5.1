﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SignalInstaller : MonoInstaller<SignalInstaller>
{
        public override void InstallBindings()
        {

        Container.DeclareSignal<WinSignal>();
        Container.DeclareSignal<ScoreSignal>();
        Container.Bind<SignalManager>().AsSingle();

        Debug.Log("SignallInstaller");
    }

}
