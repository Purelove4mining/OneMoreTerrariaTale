using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class MetalWorker : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Allows you to make really nice bars -wink-");
		}

		public override void SetDefaults() {
			item.width = 54;
			item.height = 47;
			item.maxStack = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 5000;
			item.createTile = mod.TileType("MetalWorker");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.HeavyWorkBench);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HeavyWorkBench);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}