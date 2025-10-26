using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Igniter:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.mana = 9;
			Item.UseSound = SoundID.Item105;
			Item.useStyle = 5;
			Item.damage = 40;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.width = 36;
			Item.height = 40;
			Item.shoot = ModContent.ProjectileType<Projectiles.Igniter>();
			Item.shootSpeed = 13f;
			Item.knockBack = 4.4f;
			Item.staff[Item.type] = true;
			Item.DamageType = DamageClass.Magic;
			Item.autoReuse = true;
			Item.value = Item.sellPrice(0, 4, 0, 0);
			Item.rare = 5;
			Item.noMelee = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Igniter");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SoulofLight, 15);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 9);
			recipe.AddIngredient(2701, 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
