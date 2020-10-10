using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraPickaxe.Items
{
	public class TruePickaxeAxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True PIckaxe Axe");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.melee = true;
			item.useTime = 10;
			item.useAnimation = 17;
			item.pick = 205;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 15, 0, 0); // The item sells for 15 gold.
			item.useTurn = true;
			item.rare = ItemRarityID.Yellow;
			item.autoReuse = true;
			item.tileBoost = 6;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Drax);
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);

			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PickaxeAxe);
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}