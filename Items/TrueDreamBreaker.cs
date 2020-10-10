using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraPickaxe.Items
{
	public class TrueDreamBreaker : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Dreambreaker");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.useTime = 6;
			item.useAnimation = 11;
			item.pick = 205;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 20, 0, 0); // The item sells for 20 gold.
			item.useTurn = true;
			item.rare = ItemRarityID.Yellow;
			item.autoReuse = true;
			item.tileBoost = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DreamBreaker"));
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}