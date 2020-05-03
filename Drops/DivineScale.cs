using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class DivineScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Divine Scale");
			Tooltip.SetDefault("Keep it close to you makes you feel blessed");
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