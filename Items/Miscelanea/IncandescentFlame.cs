using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class IncandescentFlame : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("His gently shine is not equiparable to his heat");
		}

		public override void SetDefaults() {
			item.width = 31;
			item.height = 31;
			item.maxStack = 25;
			item.value = 0;
			item.rare = 2 	;
		}

			
	}
}	