using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DragonRafale:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 236;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 50;
			Item.maxStack = 1;
			Item.height = 30;
			Item.useTime = 10;
			Item.useAnimation = 15;
			//Item.shoot = ModContent.ProjectileType<Projectiles.DragonLaser>();
			Item.shoot = 20;

			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 15f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 31000; ;
			Item.rare = 11;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dragon Rafale");
			// Tooltip.SetDefault("Two round burst");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, -4);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 20;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DragonCapsule>(), 9);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 14);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
