using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class ChaosBanebar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Chaos Bane Bar");
			Tooltip.SetDefault("There's a little inferno within this bar");
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
			item.createTile = mod.TileType("Chaosbanebar");
			item.placeStyle = 0;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 2);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.AddIngredient(ItemID.PalladiumBar, 2); 
			recipe.AddIngredient(ItemID.Ichor, 5); 
			recipe.AddIngredient(ItemID.LivingFireBlock, 10);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this, 8);
			recipe.AddRecipe(); 
		}
}
}		