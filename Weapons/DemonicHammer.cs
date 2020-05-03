using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Weapons
{
	public class DemonicHammer : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Demonic Hammer");
			Tooltip.SetDefault("Turn your enemies into smithereens also your walls");
		}

		public override void SetDefaults() {
			item.damage = 48;
			item.melee = true;
			item.width = 62;
			item.height = 62;
			item.useTime = 25;
			item.useAnimation = 25;
			                   //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 140;      //How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 2800;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		


	}
}
