using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor
{
	public static class Compat
	{
		public static bool active(this Tile that) => that.HasTile;
		public static bool active(this Tile that, bool value) => that.HasTile = value;

		public static bool nactive(this Tile that) => that.HasUnactuatedTile;

		public static bool halfBrick(this Tile that) => that.IsHalfBlock;
		public static bool topSlope(this Tile that) => that.TopSlope;

		public static bool lava(this Tile that) => that.LiquidType == LiquidID.Lava;
		public static bool honey(this Tile that) => that.LiquidType == LiquidID.Honey;

		//TODO: [1.4] Is this correct?
		public static int GetGoreSlot(this Mod that, string typeName) => that.Find<ModGore>(typeName).Type;

		public static int NPCType(this Mod that, string npcName) => that.Find<ModNPC>(npcName).Type;

		//TODO: Check paths on requested texture. Mod name probably won't be needed.
		public static Texture2D GetTexture(this Mod that, string path) => that.Assets.Request<Texture2D>(path, ReLogic.Content.AssetRequestMode.ImmediateLoad).Value;
		public static Asset<Texture2D> GetTextureAsset(this Mod that, string path) => that.Assets.Request<Texture2D>(path, ReLogic.Content.AssetRequestMode.ImmediateLoad);

		[Obsolete]public static int QuickSpawnItem(this Player that, int item, int stack = 1) => that.QuickSpawnItem(null, item, stack);
		[Obsolete]public static int QuickSpawnItem(this Player that, Item item, int stack = 1) => that.QuickSpawnItem(null, item, stack);

		[Obsolete]public static void TryGettingDevArmor(this Player that) => that.TryGettingDevArmor(null);


		public static int GetSpecialProjectileDamage(this Player player, int mult, int add)
		{
			//TODO: Damage
			return (int)player.GetTotalDamage(DamageClass.Generic).ApplyTo(mult) + 15;
			//return (mult * ((int)player.magicDamage + (int)player.meleeDamage + (int)player.minionDamage + (int)player.rangedDamage + (int)player.thrownDamage)) + add;
		}
	}

	public class ModRecipe
	{
		private readonly Recipe recipe;

		public ModRecipe(Mod mod)
		{
			recipe = Recipe.Create(ItemID.None);
		}

		public ModRecipe AddIngredient(ModItem item, int stack = 1)
		{
			recipe.AddIngredient(item, stack);
			return this;
		}
		public ModRecipe AddIngredient(int item, int stack = 1)
		{
			recipe.AddIngredient(item, stack);
			return this;
		}
		public ModRecipe AddIngredient(Mod mod, string itemName, int stack = 1)
		{
			recipe.AddIngredient(mod, itemName, stack);
			return this;
		}

		public ModRecipe SetResult(ModItem item, int stack = 1)
		{
			recipe.ReplaceResult(item, stack);
			return this;
		}
		public ModRecipe SetResult(int item, int stack = 1)
		{
			recipe.ReplaceResult(item, stack);
			return this;
		}

		public ModRecipe AddTile(ModTile tile)
		{
			recipe.AddTile(tile);
			return this;
		}
		public ModRecipe AddTile(int tile)
		{
			recipe.AddTile(tile);
			return this;
		}

		public void AddRecipe()
		{
			recipe.Register();
		}
	}

	public abstract class TremorModBuff:ModBuff
	{
		public override void SetStaticDefaults()
		{
			SetDefaults();
		}

		public virtual void SetDefaults(){}
	}
	public abstract class TremorModItem:ModItem
	{
		public Mod mod => Mod;
		public Item item => Item;

		private bool canShoot;

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			canShoot = Shoot(player, ref position, ref velocity.X, ref velocity.Y, ref type, ref damage, ref knockback);
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			return canShoot;
		}

		public virtual bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) => true;
	}
	public abstract class TremorModNPC:ModNPC
	{
		public Mod mod => Mod;
		public NPC npc => NPC;

		public int aiType
		{
			get => AIType;
			set => AIType = value;
		}

		public int animationType
		{
			get => AnimationType;
			set => AnimationType = value;
		}

		public int banner
		{
			get => Banner;
			set => Banner = value;
		}

		public int bannerItem
		{
			get => BannerItem;
			set => BannerItem = value;
		}

		public int music
		{
			get => Music;
			set => Music = value;
		}

		public int bossBag{private get;set;}

		//TODO: Fix NPC looting
		public virtual void NPCLoot(){}

		public sealed override void OnKill()
		{
			if(PreNPCLoot())
			{
				NPCLoot();
			}
		}

		//TODO: Doesn't fully work in 1.4
		public virtual bool PreNPCLoot() => true;

		//Was part of npc in 1.3.5
		public void DropBossBags()
		{
			if(bossBag!=0)
			{
				NPC.NewItem(bossBag);
			}
		}

		public sealed override bool PreDraw(SpriteBatch spriteBatch, Vector2 screenPos, Color drawColor)
		{
			return PreDraw(spriteBatch, drawColor);
		}
		public virtual bool PreDraw(SpriteBatch spriteBatch, Color lightColor) => true;


		public override List<string> SetNPCNameList()
		{
			return new List<string>{TownNPCName()};
		}

		public virtual string TownNPCName() => Name;
	}
	public abstract class TremorModProjectile:ModProjectile
	{
		public Mod mod => Mod;
		public Projectile projectile => Projectile;

		public int aiType
		{
			get => AIType;
			set => AIType = value;
		}

		public override bool PreDraw(ref Color drawColor)
		{
			return PreDraw(Main.spriteBatch, drawColor);
		}

		public virtual bool PreDraw(SpriteBatch spriteBatch, Color drawColor) => true;
	}
	public abstract class TremorModTile:ModTile
	{
		public int[] adjTiles
		{
			get => AdjTiles;
			set => AdjTiles = value;
		}
		public string chest
		{
			get => ContainerName.GetDefault();
			set => ContainerName.SetDefault(value);
		}
		public int chestDrop
		{
			get => ChestDrop;
			set => ChestDrop = value;
		}
		public string dresser
		{
			get => ContainerName.GetDefault();
			set => ContainerName.SetDefault(value);
		}
		public int dresserDrop
		{
			get => DresserDrop;
			set => DresserDrop = value;
		}
		public int drop
		{
			get => ItemDrop;
			set => ItemDrop = value;
		}
		public int dustType
		{
			get => DustType;
			set => DustType = value;
		}
		public int soundType//Sound type is actually SoundStyle now
		{
			set => HitSound = SoundID.SoundByIndex[(ushort)value];
		}
		//TODO: [Skipped for 1.4] Do we even need this anymore
		public int soundStyle{get;set;}//Sound style is now SoundType

		//TODO: [Skipped for 1.4] disableSmartCursor
		public bool disableSmartCursor{get;set;}

		public override void SetStaticDefaults() => SetDefaults();
		public virtual void SetDefaults(){}
	}
}
