using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ParaxydeStormbow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 68;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 15;
			Item.shoot = 1;
			Item.shootSpeed = 11f;
			Item.useAnimation = 15;
			Item.useStyle = 5;
			Item.knockBack = 1;
			Item.useAmmo = AmmoID.Arrow;
			Item.value = 216000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paraxyde Stormbow");
			// Tooltip.SetDefault("Has 33% chance to shoot paraxyde crystal");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-8, -2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParaxydeShard>(), 13);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			//type = 1;

			if (Main.rand.NextBool(3))
			{
				type = 522;
			}

			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}
