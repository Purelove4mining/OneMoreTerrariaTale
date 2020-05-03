using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BleachMod.Items.Weapons
{
	public class BronzeBullet : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Like throwing oranges.. well maybe not.");
		}

		public override void SetDefaults() {
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("BronzeBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 18f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

	
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Bronzebar", 1); 
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}
