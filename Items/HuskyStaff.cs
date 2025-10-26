using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wolf;

namespace Tremor.Items
{
	public class HuskyStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 10;
			Item.width = 34;
			Item.height = 28;

			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.value = 8000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Projectiles.Minions.HuskyStaffPro>();
			Item.shootSpeed = 1f;
			Item.buffType = ModContent.BuffType<Buffs.HuskyBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Husky Staff");
			// Tooltip.SetDefault("Summons a husky to fight for you.");
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}

		public override bool? UseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim(false);
			}
			return base.UseItem(player);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.BorealWood, 25);
			recipe.AddIngredient(ModContent.ItemType<WolfPelt>(), 7);
			recipe.AddIngredient(ModContent.ItemType<AlphaClaw>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
