using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class DragonFang : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dragon Fang");
			Tooltip.SetDefault("There's no bones or armor that can handle a bite with this one");
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