using Terraria;
using Terraria.ModLoader;

namespace Bleachmod.Buffs
{
	public class Thorned : ModBuff
	{	

   	public override void SetDefaults() {
			DisplayName.SetDefault("Thorned");
			Description.SetDefault("Your clothes/armor if full filled by thorns");
			Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			
			player.GetModPlayer<ExamplePlayer>().Thorned = true;
		}
			
		
}
}	