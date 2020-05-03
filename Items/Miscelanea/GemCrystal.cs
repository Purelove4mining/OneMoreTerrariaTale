using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class GemCrystal : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A piece of the earth unified");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 1500;
			item.rare = 4 	;
		}

		
	}
}	