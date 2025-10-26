using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PirahnaStaff:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Starfury);

			Item.damage = 18;
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 20;
			Item.mana = 8;

			Item.useAnimation = 50;
			Item.useStyle = 5;
			Item.shootSpeed = 10f;
			Item.staff[Item.type] = true;
			Item.knockBack = 3;
			Item.value = 15000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item9;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Piranha Staff");
			// Tooltip.SetDefault("Causes pirahnas to fall from the sky");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.PirahnaPro>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GoldfishStaff>(), 1);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 10);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddIngredient(ItemID.Ruby, 6);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GoldfishStaff>(), 1);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 8);
			recipe.AddIngredient(ItemID.Ruby, 6);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
