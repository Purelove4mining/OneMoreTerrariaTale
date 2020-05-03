using Bleachmod.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class TrueBlade : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Refined Blade");
			Tooltip.SetDefault("Finally its showing some of his true power");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults() {
			item.damage = 32;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 64;            //Weapon's texture's width
			item.height = 60;           //Weapon's texture's height
			item.useTime = 16;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 16;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 8;         //The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(silver: 1);           //The value of the weapon
			item.rare = 5;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TriSword");
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("FailedDust"));
			}
	
}


		
	}
}
