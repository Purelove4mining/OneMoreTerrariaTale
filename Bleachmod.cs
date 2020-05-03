using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;


namespace Bleachmod
{
	public class Bleachmod : Mod
	{
		public Bleachmod()
		{
		   	
		}
		public override void Load() {
			
			// Will show up in client.log under the ExampleMod name
			Logger.InfoFormat("{0} example logging", Name);
			
			if (!Main.dedServ) {
				// Add certain equip textures
				AddEquipTexture(null, EquipType.Legs, "DarkMagerobe_Legs", "bleachMod/Items/Armor/DarkMagerobe_Legs");
			
	}
	
}
}
}