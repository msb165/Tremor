using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class OceanBate:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 168;
			item.DamageType = DamageClass.Ranged;
			//item.melee = false;
			item.width = 28;
			item.height = 52;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useAmmo = AmmoID.Arrow;
			item.useStyle = 5;
			item.shootSpeed = 30f;
			item.knockBack = 3;
			item.value = 85000;
			item.rare = 10;
			item.shoot = 408;
			item.shootSpeed = 19f;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ocean Bate");
			Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 408;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 25);
			recipe.AddIngredient(ItemID.Coral, 20);
			recipe.AddIngredient(ItemID.SharkFin, 8);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

	}
}
