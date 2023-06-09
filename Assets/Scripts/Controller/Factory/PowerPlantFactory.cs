﻿using System.Collections;
using UnityEngine;
using Assets.Scripts.Model;

namespace Assets.Scripts.Controller.Factory
{
    public class PowerPlantFactory : IBuildingFactory
    {
        public IBuildings GenerateWarrior(Vector3 position)
        {
            return new PowerPlantModel(300, 20, position);
        }
    }
}