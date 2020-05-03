using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class AshenScale : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ashen Scale");
			Tooltip.SetDefault("The scales that contains the Anger, fury and flames of Sul'livhan");
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