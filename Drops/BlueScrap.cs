using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class BlueScrap : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Blue Scrap");
			Tooltip.SetDefault("Maybe could have some melting uses");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 10;
			item.rare = 2;
		}
    }
}		