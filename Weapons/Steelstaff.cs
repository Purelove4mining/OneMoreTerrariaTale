using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class Steelstaff : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Steel Staff");
			Tooltip.SetDefault("Let the darkness rest in your hands");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.magic = true;
			item.mana = 12;
			item.width = 45;
			item.height = 45;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 3;
			item.value = 2000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("DarkBall");
			item.shootSpeed = 16f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Darkmanastar", 1);
			recipe.AddIngredient(null, "Steelbar", 15);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}