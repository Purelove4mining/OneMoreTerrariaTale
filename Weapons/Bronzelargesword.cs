using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class Bronzelargesword : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bronze Large Sword");
			Tooltip.SetDefault("The blade is extremely thin (Try using Right click ;)");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults() {
			item.damage = 10;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 40;            //Weapon's texture's width
			item.height = 40;           //Weapon's texture's height
			item.useTime = 25;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 25;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 1;         //The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(silver: 12);           //The value of the weapon
			item.rare = 2;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
		     recipe.AddIngredient(null, "Bronzebar", 10);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
         
		 public override bool AltFunctionUse(Player player) {
			return true;
		}

		public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.useStyle = 3;
				item.useTime = 20;
				item.useAnimation = 20;
				item.damage = 13;
				item.knockBack = 9;
				item.rare = 2; 
				item.UseSound = SoundID.Item1; 
				item.autoReuse = true; 
				item.width = 40;   
				item.height = 40; 
				item.createTile = mod.TileType("Bronzeshortsword");
			} 
			else {
			item.damage = 10;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 40;            //Weapon's texture's width
			item.height = 40;           //Weapon's texture's height
			item.useTime = 25;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 25;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 1;         //The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(silver: 12);           //The value of the weapon
			item.rare = 2;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
			}
			return base.CanUseItem(player);
		
		

		
	}
}
}