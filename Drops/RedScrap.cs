using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class RedScrap : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Red Scrap");
			Tooltip.SetDefault("You ask yourself if all this is blood..");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 2;
		}
    }
}		