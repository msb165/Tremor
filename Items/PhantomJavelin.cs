﻿using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class PhantomJavelin:TremorModItem
	{
		public override void SetDefaults()
		{

			item.value = 100000;
			item.useStyle = 1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.autoReuse = true;
			item.rare = 3;
			item.width = 42;
			item.height = 42;
			item.UseSound = SoundID.Item8;
			item.damage = 28;
			item.knockBack = 4;
			item.mana = 7;
			item.shoot = ModContent.ProjectileType<Projectiles.PhantomSpear>();
			item.shootSpeed = 14f;
			item.noMelee = true; //So that the swing itself doesn't do damage; this weapon is projectile-only
			item.noUseGraphic = true; //No swing animation
			item.DamageType = DamageClass.Magic;
			item.crit = 7;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phantom Javelin");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
