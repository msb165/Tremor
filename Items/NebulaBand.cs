using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NebulaBand:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.rare = 11;
			Item.value = 380000;
			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<Projectiles.NebulaJellyfish>();
			Item.buffType = ModContent.BuffType<Buffs.NebulaJellyfishBuff>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nebula Band");
			// Tooltip.SetDefault("Summons a nebula jellyfish");
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
			recipe.AddIngredient(3457, 10);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
