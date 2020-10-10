using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraPickaxe.Items
{
	public class TerraFormer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Terra Former");
			Tooltip.SetDefault("Hold Right click to shoot an insane amount of destructive rockets.\n\"Try not to blow yourself up.\"");
		}

		public override void SetDefaults() 
		{
			item.damage = 1000;
			item.tileBoost = 7;
			item.melee = true;
			item.useTime = 2;
			item.pick = 500;
			item.axe = 100;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(999, 99, 99, 99);
			item.rare = 11;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if(player.altFunctionUse == 2) {
				item.melee = true;
				item.useTime = 2;
				item.useStyle = 5;
				item.shoot = ProjectileID.RocketIV;
				item.shootSpeed = 22.0f;
				item.knockBack = 60;
			} else {
				item.tileBoost = 7;
				item.melee = true;
				item.useTime = 2;
				item.pick = 250;
				item.useAnimation = 8;
				item.shoot = 0;
				item.shootSpeed = 0f;
				item.useStyle = 1;
				item.knockBack = 6;
				item.value = 10000;
				item.rare = 11;
				item.autoReuse = true;
			}
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{	for(int i = 0; i < 4; i++) {
			Projectile.NewProjectile(position, new Vector2(speedX, speedY).RotatedByRandom(-0.1*3.14159), type, damage, knockBack, player.whoAmI);
			}
			Projectile.NewProjectile(position, new Vector2(speedX * 1.5f, speedY * 1.5f), type, damage, knockBack, player.whoAmI);
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TrueDreamBreaker"));
			recipe.AddIngredient(mod.ItemType("TruePickaxeAxe"));
			recipe.AddIngredient(ItemID.Picksaw);
			recipe.AddIngredient(ItemID.SolarFlarePickaxe);
			recipe.AddIngredient(ItemID.VortexPickaxe);
			recipe.AddIngredient(ItemID.NebulaPickaxe);
			recipe.AddIngredient(ItemID.StardustPickaxe);
			recipe.AddIngredient(ItemID.SoulofLight);
			recipe.AddIngredient(ItemID.SoulofNight);
			recipe.AddIngredient(ItemID.LunarBar); // Luminite bar
			recipe.AddTile(TileID.LunarCraftingStation); // Ancient manipulator
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			player.pickSpeed /= 10.0f;
			base.MeleeEffects(player, hitbox);
		}
	}
}