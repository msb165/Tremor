using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MythrilStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 37;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 8;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 18440;
			Item.rare = 4;
			Item.UseSound = SoundID.Item82;
			Item.autoReuse = false;
			Item.staff[Item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			Item.shoot = ModContent.ProjectileType<Projectiles.MythrilBolt>();
			Item.shootSpeed = 14f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mythril Staff");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MythrilBar, 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
