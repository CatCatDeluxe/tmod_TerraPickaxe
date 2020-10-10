using Terraria.ID;
using Terraria.ModLoader;

namespace TerraPickaxe.Items
{
	public class MeteorPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Meteor Pickaxe");
		}

		public override void SetDefaults() 
		{
			item.damage = 18;
			item.melee = true;
			item.useTime = 12;
			item.useAnimation = 24;
			item.pick = 60;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 25000; // The item sells for 50 silver.
			item.rare = ItemRarityID.Orange;
			item.useTurn = true;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			// This item requires meteorite bar x 20 @ avil to craft.
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}