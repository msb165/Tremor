using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FieryKunai:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 18;
			item.height = 32;

			item.DamageType = DamageClass.Throwing;
			item.width = 18;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.consumable = true;
			item.useTime = 18;
			item.useAnimation = 18;
			item.shoot = ModContent.ProjectileType<Projectiles.FieryKunai>();
			item.shootSpeed = 16f;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 60;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fiery Kunai");
			Tooltip.SetDefault("50% chance to set enemy on fire");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Kunai>(), 50);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>());
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
