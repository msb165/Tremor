using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items
{
	public class BloodyBow:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 59;
			item.width = 16;
			item.height = 32;
			item.DamageType = DamageClass.Ranged;
			item.useTime = 30;
			item.shoot = 1;

			item.shootSpeed = 60f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 1040;
			item.useAmmo = AmmoID.Arrow;
			item.rare = 6;
			item.crit = 7;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloody Bow");
			Tooltip.SetDefault("Launches arrows at lightning speed!");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.BloodyArrow>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SkullTeeth>(), 4);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
