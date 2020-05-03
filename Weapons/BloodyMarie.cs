using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod.Buffs;

namespace Bleachmod.Items.Weapons
{
	public class BloodyMarie : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bloody Marie");
			Tooltip.SetDefault("Swing your enemies with their own blood");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults() {
			item.damage = 20;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 44;            //Weapon's texture's width
			item.height = 44;           //Weapon's texture's height
			item.useTime = 20;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 20;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 5;         //The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(silver: 30);           //The value of the weapon
			item.rare = 3;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("AdamantiteDust"));
			}
		}

		
		
	}
}
