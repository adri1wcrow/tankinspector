﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smellyriver.TankInspector.Modeling
{
	internal class RancorousBattleBoosterScript : ConsumableScript
	{
		public RancorousBattleBoosterScript(Database database)
			: base(database)
		{
		}

		public override string[] EffectiveDomains => new string[0];
		public override void Execute(ModificationContext context, object args)
		{
			// todo
		}
	}
}
