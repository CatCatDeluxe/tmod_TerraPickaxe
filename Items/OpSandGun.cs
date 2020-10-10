using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TerraPickaxe.Items
{
	public class OpSandGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("OP Sand Gun");
			Tooltip.SetDefault("Does Not Consume ammo\n[c/ff0000:WARNING!] Using this might ruin your world...\n\"Sand is overpowered\"");
		}

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.noMelee = true;
			item.ranged = true;

			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;

			item.width = 400;
			item.height = 400;
			item.value = 15;
			item.rare = ItemRarityID.Green;
			item.shoot = ProjectileID.SandBallGun; // Shoot flower of fire projectile (ID 15)
			item.shootSpeed = 12.0f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, -8);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed;
			for(int i = 0; i < 12; i++) {
				perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(3.14159/8); // Have a spread of 10 degrees
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sandgun);
			recipe.AddIngredient(ItemID.SandBlock, 999);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
		}
	}
}