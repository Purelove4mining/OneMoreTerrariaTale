using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class GreenScrap : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Light Green Scrap");
			Tooltip.SetDefault("It's almost in perfect state what a shame");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 30;
			item.rare = 2;
		}
    }
}		