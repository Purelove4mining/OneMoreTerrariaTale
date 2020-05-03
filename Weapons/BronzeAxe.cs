using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class BronzeAxe : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bronze Axe");
			Tooltip.SetDefault("A bronze axe ¿What else?");
		}

		public override void SetDefaults() {
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 17;
			item.axe = 10;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
		    item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Bronzebar", 8);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(10)) {
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}
