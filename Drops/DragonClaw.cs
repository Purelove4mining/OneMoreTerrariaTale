using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class DragonClaw : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dragon claw");
			Tooltip.SetDefault("There's no bones or armor that can handle a scrath of this one");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 7000;
			item.rare = 5;
		}
    }
}		