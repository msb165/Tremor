using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class IceDrill:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 32;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 5;
			Item.useAnimation = 25;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.pick = 200;
			Item.axe = 24;
			Item.tileBoost++;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 20, 0, 0);
			Item.rare = 7;
			Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.IceDrillPro>();
			Item.shootSpeed = 40f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ice Drill");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FrostoneBar>(), 12);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
