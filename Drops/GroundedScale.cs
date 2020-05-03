using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class GroundedScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Grounded Scale");
			Tooltip.SetDefault("Hard and powerfull as earth itself");
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