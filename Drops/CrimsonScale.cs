using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class CrimsonScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Crimson Scale");
			Tooltip.SetDefault("'An inconmensurable hunger for blood resides in'");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 4000;
			item.rare = 4;
		}
    }
}		