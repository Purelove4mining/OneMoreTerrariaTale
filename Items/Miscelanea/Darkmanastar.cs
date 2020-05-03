using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class Darkmanastar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dark Mana Star");
			Tooltip.SetDefault("An condensed piece of evil");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 500;
			item.rare = 1 	;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}	
	}
}	