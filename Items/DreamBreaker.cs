using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraPickaxe.Items
{
	public class DreamBreaker : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dreambreaker");
		}

		public override void SetDefaults() 
		{
			item.damage = 35;
			item.melee = true;
			item.useTime = 7;
			item.useAnimation = 16;
			item.pick = 110;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 5, 0, 0); // The item sells for 5 gold.
			item.useTurn = true;
			item.rare = ItemRarityID.Orange;
			item.autoReuse = true;
			item.tileBoost = 3;
		}

		public override void AddRecipes()
		{
			// Add recipes for both the Nightmare and Deathbringer pickaxe
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MeteorPickaxe"));
			recipe.AddIngredient(mod.ItemType("JungleGrassPickaxe"));
			recipe.AddIngredient(ItemID.NightmarePickaxe);
			recipe.AddIngredient(ItemID.MoltenPickaxe);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(mod.ItemType("MeteorPickaxe"));
			recipe2.AddIngredient(mod.ItemType("JungleGrassPickaxe"));
			recipe2.AddIngredient(ItemID.DeathbringerPickaxe);
			recipe2.AddIngredient(ItemID.MoltenPickaxe);
			recipe2.AddTile(TileID.DemonAltar);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}