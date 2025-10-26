using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Candy
{
	public class CandyBlaster:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 226;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 42;
			Item.height = 30;

			Item.useTime = 4;
			Item.useAnimation = 12;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4f;
			Item.value = Item.sellPrice(0, 20, 0, 0);
			Item.rare = 10;
			Item.UseSound = SoundID.Item40;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.shootSpeed = 15f;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Candy Blaster");
			// Tooltip.SetDefault("Spends bullets and fires candies");
		}

		public override bool CanConsumeAmmo(Item ammo, Player p)
		{
			return Main.rand.NextBool(3);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.SweetPro>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override Vector2? HoldoutOffset()
		{
			return Vector2.Zero;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 8);
			recipe.AddIngredient(ModContent.ItemType<CandyBar>(), 12);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
