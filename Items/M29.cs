using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class M29:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 313;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 98;
			Item.height = 28;
			Item.useTime = 60;
			Item.useAmmo = AmmoID.Bullet;
			Item.useAnimation = 60;
			Item.shoot = 242;
			Item.shootSpeed = 15f;
			Item.useStyle = 5;
			Item.knockBack = 10;
			Item.value = 96300;
			Item.rare = 10;
			Item.UseSound = SoundID.Item40;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("M-29");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 242;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-25, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<EyeofOblivion>(), 1);
			recipe.AddIngredient(ItemID.ShroomiteBar, 15);
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 6);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
