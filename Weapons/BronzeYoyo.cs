using Bleachmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class BronzeYoyo : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bronze Yo-yo");
			Tooltip.SetDefault("'Let's have fun!'");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults() {
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 25f;
			item.knockBack = 2.5f;
			item.damage = 9;
			item.rare = 0;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
			item.shoot = ModContent.ProjectileType<BronzeYoyoprojectile>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Bronzebar", 5); 
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
