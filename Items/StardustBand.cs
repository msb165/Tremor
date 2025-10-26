using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StardustBand:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.rare = 11;
			Item.value = 380000;
			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<Projectiles.StardustSquid>();
			Item.buffType = ModContent.BuffType<Buffs.StardustSquidBuff>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stardust Band");
			// Tooltip.SetDefault("Summons a stardust squid");
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(Item.buffType, 3600, true);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<UnchargedBand>());
			recipe.AddIngredient(3459, 10);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
