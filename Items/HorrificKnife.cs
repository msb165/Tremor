using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HorrificKnife:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 80;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.HorrificKnifePro>();
			Item.shootSpeed = 22f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 11;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Horrific Knife");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ThrowingKnife, 50);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 1);
			recipe.SetResult(this, 50);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
