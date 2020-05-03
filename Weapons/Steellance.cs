using Bleachmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class Steellance : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Steel Lance");
			Tooltip.SetDefault("'A hit should be enough for the weaks'");
		}

		public override void SetDefaults() {
			item.damage = 11;
			item.useStyle = 5;
			item.useAnimation = 26;
			item.useTime = 32;
			item.shootSpeed = 3.7f;
			item.knockBack = 2.5f;
			item.width = 32;
			item.height = 30;
			item.scale = 1f;
			item.rare = 2;
			item.value = Item.sellPrice(silver: 25);

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<SteelSpearProjectile>();
		}

		public override bool CanUseItem(Player player) {
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1;
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
