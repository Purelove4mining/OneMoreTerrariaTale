using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class SOD : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shard of Darkness");
			Tooltip.SetDefault("Your terrified just by holding it");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 30;
			item.maxStack = 99;
			item.value = 5;
			item.rare = 1 	;
		}

		
	}
}	