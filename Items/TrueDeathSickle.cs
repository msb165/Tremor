using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrueDeathSickle:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 71;
			Item.DamageType = DamageClass.Melee;
			Item.width = 120;
			Item.height = 112;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.useTurn = true;
			Item.useStyle = 100;
			Item.knockBack = 8f;
			Item.value = Item.sellPrice(0, 10, 0, 0);
			Item.rare = 8;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.TrueDeathSickleProj>();
			Item.shootSpeed = 0f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Death Sickle");
			// Tooltip.SetDefault("");
		}

		public override void UseItemFrame(Player player)
		{
			player.bodyFrame.Y = 3 * player.bodyFrame.Height;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(1327);
			recipe.AddIngredient(1570);
			recipe.AddIngredient(548, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
