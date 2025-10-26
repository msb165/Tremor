using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Chaos;

namespace Tremor.Items.Crystal
{

	public class CrystalChainmer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 12;
			Item.useAnimation = 25;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.hammer = 100;
			Item.axe = 22;
			Item.tileBoost++;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 1, 50, 0);
			Item.rare = 5;
			Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.CrystalChainmer>();
			Item.shootSpeed = 40f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crystal Chainmer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ChaosBar>(), 15);
			recipe.AddIngredient(ItemID.CrystalShard, 22);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
