using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class PutridScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Putrid Scale");
			Tooltip.SetDefault("It feels dead somehow and has a horrible smell");
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