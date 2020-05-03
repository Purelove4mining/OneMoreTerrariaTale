using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class TwinkleAshes : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("An inner desire of calm live within");
		}

		public override void SetDefaults() {
			item.width = 38;
			item.height = 38;
			item.maxStack = 25;
			item.value = 0;
			item.rare = 2 	;
		}

			
	}
}	