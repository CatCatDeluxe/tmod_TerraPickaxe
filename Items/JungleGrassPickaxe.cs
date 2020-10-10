using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraPickaxe.Items
{
	public class JungleGrassPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lawn Mower");
			Tooltip.SetDefault("How does is a sharp peice of grass supposed to break blocks?");
		}

		public override void SetDefaults() 
		{
			item.damage = 22;
			item.melee = true;
			item.useTime = 7;
			item.useAnimation = 24;
			item.pick = 45;
			item.scale = 1.3f;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 16000; // The item sells for 40 silver.
			item.useTurn = true;
			item.rare = ItemRarityID.Blue;
			item.autoReuse = true;
			item.tileBoost = 2;
		}

		public override void AddRecipes()
		{
			// This item requires jungle spores*14 + stinger*12 @ avil to craft.
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 12);
			recipe.AddIngredient(ItemID.Stinger, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}