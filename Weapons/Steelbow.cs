using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class Steelbow : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Steel Bow");
			Tooltip.SetDefault("It's heavier than it looks");
		}
		public override void SetDefaults() {
        	item.damage = 16;
			item.ranged = true;
			item.width = 22;
			item.height = 36;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 1;
			item.value = 1000;
			item.rare = 3;
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 15f;
			item.useAmmo = AmmoID.Arrow;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Steelbar", 5);
			recipe.AddIngredient(ItemID.IronBow); 
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}
}	