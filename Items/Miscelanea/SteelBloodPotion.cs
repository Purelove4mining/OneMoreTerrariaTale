using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class SteelBloodPotion : ModItem
	{
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Turn your blood steel cold");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = false;
            item.rare = 2;
            item.value = Item.buyPrice(silver: 10);
            item.buffType = ModContent.BuffType<Buffs.SteelBlood>(); //Specify an existing buff to be applied when used.
            item.buffTime = 10800; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronskinPotion);
			recipe.AddIngredient(null, "Steelbar", 1);
			recipe.AddIngredient(ItemID.Obsidian);
			recipe.AddIngredient(ItemID.Waterleaf);
			recipe.AddIngredient(ItemID.Fireblossom);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
