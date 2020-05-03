using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class Cursedbar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cursed Bar");
			Tooltip.SetDefault("Its power makes you feel sick");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 59;
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 800;
			item.rare = 5;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("Cursedbar");
			item.placeStyle = 0;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 2);
			recipe.AddIngredient(ItemID.MeteoriteBar, 2);
			recipe.AddIngredient(ItemID.OrichalcumBar, 2); 
			recipe.AddIngredient(ItemID.CursedFlame, 5); 
			recipe.AddIngredient(ItemID.LivingFireBlock, 10);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this, 10);
			recipe.AddRecipe(); 
		}
}
}		