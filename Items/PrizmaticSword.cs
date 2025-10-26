using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PrizmaticSword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 65;
			Item.DamageType = DamageClass.Melee;
			Item.width = 35;
			Item.height = 20;

			Item.useTime = 20;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 120000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Prizmatic Fang");
			// Tooltip.SetDefault("Grants mana upon hitting an enemy");
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			player.statMana += damageDone / 6;
			player.ManaEffect(damageDone / 6);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(2))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 27);
			}
		}
	}
}

