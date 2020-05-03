using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class Steelhamaxe : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Steel Hamaxe");
			Tooltip.SetDefault("Not enough powerfull to use it as a battleaxe");
		}

		public override void SetDefaults() {
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.axe = 15;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 80;      //How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 2000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Steelbar", 12);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


	}
}
