using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.ZombieEvent.Tiles;

namespace Tremor.Items
{
	public class ZombatStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 10;
			Item.width = 34;
			Item.height = 28;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Projectiles.Minions.ZombatStaffPro>();
			Item.shootSpeed = 1f;
			Item.buffType = ModContent.BuffType<Buffs.ZombatBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zombat Staff");
			// Tooltip.SetDefault("Summons a zombat to fight for you.");
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
			recipe.AddIngredient(ItemID.Diamond, 1);
			recipe.AddIngredient(ModContent.ItemType<ZombieEvent.Items.RupicideBar>(), 6);
			recipe.AddIngredient(ModContent.ItemType<TearsofDeath>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<NecromaniacWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
