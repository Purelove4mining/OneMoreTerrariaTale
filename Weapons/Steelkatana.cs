using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class Steelkatana : ModItem
	{
		public override void SetStaticDefaults() {
			
			DisplayName.SetDefault("Steel katana");
			Tooltip.SetDefault("Fast and furi.. Letal"); 
		}
		
		public override void SetDefaults() {
			
			item.damage = 15;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 44;            //Weapon's texture's width
			item.height = 46;           //Weapon's texture's height
			item.useTime = 15;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 15;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 3;         //The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(silver: 50);           //The value of the weapon
			item.rare = 3;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
			
			}
			
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(null, "Steelbar", 7);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}		
}