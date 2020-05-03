using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class DragonScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dragon Scale");
			Tooltip.SetDefault("The skin of the devourers kings");
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