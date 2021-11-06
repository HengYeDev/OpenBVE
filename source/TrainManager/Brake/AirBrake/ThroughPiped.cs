﻿using TrainManager.Handles;
using TrainManager.Power;

namespace TrainManager.BrakeSystems
{
	public class ThroughPiped : CarBrake
	{
		public ThroughPiped()
		{
			decelerationCurves = new AccelerationCurve[] { };
			brakeType = BrakeType.None;
		}

		public override void Update(double TimeElapsed, double currentSpeed, AbstractHandle brakeHandle, out double Deceleration)
		{
			Deceleration = 0.0;
		}
	}
}
