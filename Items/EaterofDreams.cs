using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class EaterofDreams:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.damage = 99;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 76;
			Item.height = 36;
			Item.useTime = 10;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 2f;
			Item.UseSound = SoundID.Item34;
			Item.value = 1253000;
			Item.rare = 11;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.EaterofDreamsPro>();
			Item.shootSpeed = 7.5f;
			Item.useAmmo = AmmoID.Gel;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Eater of Dreams");
			// Tooltip.SetDefault("Consumes gel as ammo");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 16);
			recipe.AddIngredient(ItemID.Flamethrower, 1);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 25);
			recipe.AddIngredient(ModContent.ItemType<PurpleQuartz>(), 15);
			recipe.AddIngredient(ModContent.ItemType<TearsofDeath>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
