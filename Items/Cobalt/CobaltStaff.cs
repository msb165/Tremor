using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Cobalt
{
	public class CobaltStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 32;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 9;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 28;
			Item.useAnimation = 28;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 13800;
			Item.rare = 4;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = true;
			Item.staff[Item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			Item.shoot = ModContent.ProjectileType<Projectiles.CobaltBolt>();
			Item.shootSpeed = 12f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cobalt Staff");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.CobaltBar, 12);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
