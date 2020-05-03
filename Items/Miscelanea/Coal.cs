using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class Coal : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A simple piece of carbono");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 5;
			item.rare = 1 	;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}	
	}
}	