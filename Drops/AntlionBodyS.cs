using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class AntlionBodyS : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Antlion Swarmer Body");
			Tooltip.SetDefault("The caparace of an Antlion");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 4000;
			item.rare = 2;
		}
    }
}		