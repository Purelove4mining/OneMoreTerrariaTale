using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class DuneSplinter : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dune Splinter");
			Tooltip.SetDefault("It's almost a catastrophe almost..."
			+ "\n Weapon and pickaxe all in one!");
		}

		public override void SetDefaults() {
			item.damage = 18;
			item.melee = true;
			item.width = 44;
			item.height = 48;
			item.useTime = 15;
			item.useAnimation = 15;
			item.pick = 70;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AntlionMandible, 3);
			recipe.AddIngredient(ItemID.Amber, 4);
			recipe.AddIngredient(null, "Bronzebar", 10);
			recipe.AddTile(null, "DessertIdol");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("SandDust"));
			}

		
	}
}
}