using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class NeonScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Neon Scale");
			Tooltip.SetDefault("Warm to the touch and shines gently");
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