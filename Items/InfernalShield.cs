using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class InfernalShield:TremorModItem
	{
		const int ShootType = 376; 
		const float ShootRange = 600.0f; 
		const float ShootKN = 1.0f; 
		const int ShootRate = 60; 
		const int ShootCount = 3; 
		const float ShootSpeed = 15f; 
		const int spread = 45; 
		const float spreadMult = 0.045f; 

		int TimeToShoot = ShootRate;

		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 36;

			Item.value = 45000;
			Item.rare = 9;
			Item.expert = true;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Infernal Shield");
			// Tooltip.SetDefault("Casts fireballs at nearby enemies");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{

			if (--TimeToShoot <= 0)
			{
				TimeToShoot = ShootRate;
				int Target = GetTarget();
				if (Target != -1) Shoot(Target, GetDamage());
			}
		}

		int GetTarget()
		{
			int Target = -1;
			for (int k = 0; k < Main.npc.Length; k++)
			{
				if (Main.npc[k].active && Main.npc[k].lifeMax > 5 && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].Distance(Main.player[Item.playerIndexTheItemIsReservedFor].Center) <= ShootRange && Collision.CanHitLine(Main.player[Item.playerIndexTheItemIsReservedFor].Center, 4, 4, Main.npc[k].Center, 4, 4))
				{
					Target = k;
					break;
				}
			}
			return Target;
		}

		int GetDamage()
		{
			return Main.player[Item.playerIndexTheItemIsReservedFor].GetSpecialProjectileDamage(10, 15);
		}

		void Shoot(int Target, int Damage)
		{
			Vector2 velocity = Helper.VelocityToPoint(Main.player[Item.playerIndexTheItemIsReservedFor].Center, Main.npc[Target].Center, ShootSpeed);
			for (int l = 0; l < ShootCount; l++)
			{
				velocity.X = velocity.X + Main.rand.Next(-spread, spread + 1) * spreadMult;
				velocity.Y = velocity.Y + Main.rand.Next(-spread, spread + 1) * spreadMult;
				int i = Projectile.NewProjectile(null, Main.player[Item.playerIndexTheItemIsReservedFor].Center.X, Main.player[Item.playerIndexTheItemIsReservedFor].Center.Y, velocity.X, velocity.Y, ShootType, Damage, ShootKN, Item.playerIndexTheItemIsReservedFor);
			}
		}
	}
}
