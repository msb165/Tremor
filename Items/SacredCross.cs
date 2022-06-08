using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wood;

namespace Tremor.Items
{
	public class SacredCross : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 56;
			item.magic = true;
			item.mana = 8;
			item.width = 40;
			item.height = 40;
			item.useTime = 35;
			item.useAnimation = 35;

			item.useStyle = 5;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 700;
			item.rare = 5;
			item.UseSound = SoundID.Item75;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.SacredCrossPro>();
			item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sacred Cross");
			Tooltip.SetDefault("Shoots magical crosses that heal you");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<WoodenCross>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ItemID.HallowedBar, 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
