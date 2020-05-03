using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class DeepScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Deep Scale");
			Tooltip.SetDefault("Cold 'n' Soft to the touch, the inner calm baffles you.");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = 7;
		}
    }
}		