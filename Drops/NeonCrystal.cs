using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class NeonCrystal : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Neon Crystal");
			Tooltip.SetDefault("Fragile but Powerfull like life itselfs");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1500;
			item.rare = 3; 
		}
    }
}	