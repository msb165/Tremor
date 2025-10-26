using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class IchorBreath:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 55;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.height = 18;
			Item.useTime = 14;
			Item.maxStack = 999;
			Item.useAnimation = 14;
			Item.shoot = ModContent.ProjectileType<Projectiles.IchorBreathPro>();
			Item.shootSpeed = 8f;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 155;
			Item.rare = 5;
			Item.consumable = true;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ichor Breath");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DragonBreath>(), 25);
			recipe.AddIngredient(ItemID.Ichor, 3);
			recipe.SetResult(this, 25);
			recipe.AddTile(134);
			recipe.AddRecipe();

		}
	}
}
