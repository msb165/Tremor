using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightFury:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 10;
			item.value = Item.sellPrice(2, 0, 0, 0);
			item.rare = 4;
			item.noMelee = true;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.knockBack = 7.5F;
			item.damage = 36;
			item.scale = 1.1F;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<Projectiles.NightFuryPro>();
			item.shootSpeed = 15.9F;
			item.UseSound = SoundID.Item1;
			item.DamageType = DamageClass.Melee;
			item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Fury");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Sunfury, 1);
			recipe.AddIngredient(ModContent.ItemType<LeafBall>(), 1);
			recipe.AddIngredient(ItemID.BallOHurt, 1);
			recipe.AddIngredient(ItemID.BlueMoon, 1);
			recipe.SetResult(this);
			recipe.AddTile(26);
			recipe.AddRecipe();
		}
	}
}
