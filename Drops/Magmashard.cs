using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class Magmashard : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Magma Shard");
			Tooltip.SetDefault("You wonder how this can even get form");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 250;
			item.rare = 4;
		}
    }
}	