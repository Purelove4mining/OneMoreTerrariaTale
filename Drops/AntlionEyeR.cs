using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class AntlionEyeR : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Antlion Eyes");
			Tooltip.SetDefault("Looks cooler out of them");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 800;
			item.rare = 2;
		}
    }
}		