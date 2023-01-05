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

			item.damage = 226;
			item.DamageType = DamageClass.Ranged;
			item.width = 42;
			item.height = 30;

			item.useTime = 4;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 20, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item40;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 15f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Candy Blaster");
			Tooltip.SetDefault("Spends bullets and fires candies");
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
			ModRecipe recipe = new ModRecipe(mod);
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
