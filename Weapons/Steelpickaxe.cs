using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class Steelpickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Steel Pickaxe");
			Tooltip.SetDefault("It's slower than usual pickaxes but also more powerfull");
		}

		public override void SetDefaults() {
			item.damage = 9;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 30;
			item.pick = 64;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Steelbar", 22);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		
	}
}