using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
    public class DarkManipulator : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Manipulator");
            Tooltip.SetDefault("'The crystal seems like could get break in any moment'");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 26;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 2;
            item.value = 3000;
            item.createTile = mod.TileType("DarkManipulatorTile");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Darkmanastar", 1);
            recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.AddIngredient(ItemID.WorkBench);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}