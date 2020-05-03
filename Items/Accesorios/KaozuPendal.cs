using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class KaozuPendal : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Kaozu pendant");
			Tooltip.SetDefault("Give your essence to the Darklord");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 5000;
			item.rare = 5;
		}

		public override void UpdateAccessory(Player player, bool Neck) {
		
		  
		 player.AddBuff(ModContent.BuffType<Buffs.KaozuFlux>(),1, true);		  
		  
         }		
	}
}	