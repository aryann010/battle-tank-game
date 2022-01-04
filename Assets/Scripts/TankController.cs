using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankServices
{
    public class TankController
    {
        private Rigidbody rb;
        public TankModel tankModel { get; private set; }
        public TankView tankView { get; private set; }

        public TankController(TankModel model, TankView tankView)
        {
            tankModel = model;
            tankView = GameObject.Instantiate<TankView>(tankView);
            CameraFollow.instance.SetTarget(tankView.transform);
            rb = tankView.GetComponent<Rigidbody>();
            tankView.SetTankController(this);
            tankModel.SetTankController(this);
        }
    }
}