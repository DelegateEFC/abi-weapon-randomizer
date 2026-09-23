using BackendRandomizer.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendRandomizer.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<WeaponAttachment> WeaponAttachments { get; set; }
        public DbSet<RollHistory> RollHistory { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Konfiguruje relacje, klucze złożone i dane początkowe przez HasData()
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weapon>().HasData(
                new Weapon { Id = 1, Name = "AKM", WeaponCategory = Weapon.Category.AssaultRifle },
                new Weapon { Id = 2, Name = "FAL", WeaponCategory = Weapon.Category.AssaultRifle},
                new Weapon { Id = 3, Name = "T191", WeaponCategory = Weapon.Category.AssaultRifle},

                new Weapon { Id = 4, Name = "MPX", WeaponCategory = Weapon.Category.SubmachineGun},
                new Weapon { Id = 5, Name = "P90", WeaponCategory = Weapon.Category.SubmachineGun },
                new Weapon { Id = 6, Name = "Banshee", WeaponCategory = Weapon.Category.SubmachineGun }

                /* NA NASTEPNY RAZ BO DUŻO
                new Weapon { Id = 7, Name = "M16", WeaponCategory = Weapon.Category.Carabine },
                new Weapon { Id = 8, Name = "M96", WeaponCategory = Weapon.Category.Carabine },
                new Weapon { Id = 9, Name = "SA85M", WeaponCategory = Weapon.Category.Carabine }
                
                new Weapon { Id = 10, Name = "SVDS", WeaponCategory = Weapon.Category.MarksmanRifle },
                new Weapon { Id = 11, Name = "Mk14", WeaponCategory = Weapon.Category.MarksmanRifle },
                new Weapon { Id = 12, Name = "M110", WeaponCategory = Weapon.Category.MarksmanRifle },

                new Weapon { Id = 13, Name = "Mosin", WeaponCategory = Weapon.Category.BoltActionRifle },
                new Weapon { Id = 14, Name = "SJ16", WeaponCategory = Weapon.Category.BoltActionRifle },
                new Weapon { Id = 15, Name = "M24", WeaponCategory = Weapon.Category.BoltActionRifle }

                // NA KIEDYŚ (rzadko używane)
                new Weapon { Id = 16, Name = "USAS-12", WeaponCategory = Weapon.Category.Shotgun },
                new Weapon { Id = 17, Name = "S12K", WeaponCategory = Weapon.Category.Shotgun },
                new Weapon { Id = 18, Name = "MP-133", WeaponCategory = Weapon.Category.Shotgun },
                
                new Weapon { Id = 4, Name = "RPK-16", WeaponCategory = Weapon.Category.LightMachineGun },

                new Weapon { Id = 5, Name = "Deagle", WeaponCategory = Weapon.Category.Pistol },
                new Weapon { Id = 6, Name = "F57", WeaponCategory = Weapon.Category.Pistol },
                new Weapon { Id = 7, Name = "M9A3", WeaponCategory = Weapon.Category.Pistol }
                */
            );


            modelBuilder.Entity<Attachment>().HasData(
                // MUZZLE
                //AKM
                new Attachment { Id = 1, Name = "7.62x39 Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 2, Name = "AKM Premium Stable Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 3, Name = "AKM Precision Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 4, Name = "AK Series 7.62x39 Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 5, Name = "AKM Standard Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 6, Name = "AKM Stabilized Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 7, Name = "AKM Compatible Hexagon Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 8, Name = "AK Guard Muzzle Brake", Slot = Attachment.Socket.Muzzle },

                //FAL
                new Attachment { Id = 9, Name = "Classic Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 10, Name = "Multi-Port Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 11, Name = "Precission Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 12, Name = "AR-10 Muzzle Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 13, Name = "MG 3 Muzzle Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 14, Name = "Mk14/M14 Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 15, Name = "7.62x51mm Caliber SureFire Suppressor", Slot = Attachment.Socket.Muzzle },

                //T191
                new Attachment { Id = 16, Name = "191 Muzzle Compensator", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 17, Name = "T19X Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 18, Name = "U191 Suppressor", Slot = Attachment.Socket.Muzzle },

                // SCOPE
                //AKM / FAL / T191 / MPX
                new Attachment { Id = 19, Name = "1x/4x Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 20, Name = "1x/6x Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 21, Name = "2x Sight*", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 22, Name = "3.5x Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 23, Name = "6.5/20x Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 24, Name = "2x/7x Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 25, Name = "4x/16x Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 26, Name = "3x Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 27, Name = "3x Combination Holographic Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 28, Name = "4x Holographic Triangle Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 29, Name = "533 Holographic Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 30, Name = "EKP-8-18 Reflex Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 31, Name = "Bat Ear Holographic Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 32, Name = "Classic Holographic Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 33, Name = "Classic Compact Red Dot Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 34, Name = "Whirlpool Holographic Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 35, Name = "Periscope Hybrid Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 36, Name = "M1 Tactical Red Dot", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 37, Name = "Modern Red Dot Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 38, Name = "PK-06 Reflex Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 39, Name = "PZ4 THERMAL SCOPE", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 40, Name = "Raised Precision Red Dot Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 41, Name = "Simple Red Dot Sight", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 42, Name = "Tactical Red Dot Scope", Slot = Attachment.Socket.Scope},
                new Attachment { Id = 43, Name = "Triangle Precision Sight", Slot = Attachment.Socket.Scope},


                // BACK GRIP
                //AKM
                new Attachment { Id = 44, Name = "AK Compatible Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 45, Name = "Industrial AK Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 46, Name = "AK Modern Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 47, Name = "AK 12 Standard Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 48, Name = "KGB Lightweight AK Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 49, Name = "Lightweight AK Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 50, Name = "RK-3 Industrial AK Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 51, Name = "SAW Tactical AK Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 52, Name = "AK Series Standard Rear Grip", Slot = Attachment.Socket.BackGrip },

                //FAL
                new Attachment { Id = 53, Name = "Dedicated FAL Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 54, Name = "FAL Comfortable Rear Grip", Slot = Attachment.Socket.BackGrip },

                //T191
                new Attachment { Id = 55, Name = "T19X Standard Rear Grip", Slot = Attachment.Socket.BackGrip },


                // STOCK
                //AKM
                new Attachment { Id = 56, Name = "Type 81 Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 57, Name = "AK-74 Wooden Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 58, Name = "AK Series High-Performance Buttstock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 59, Name = "AK-74 Polymer Bootstock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 60, Name = "AK Series AP Tactical Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 61, Name = "AK Series FAB Buttstock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 62, Name = "AK Series GS FixedStock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 63, Name = "AK Series GS Modern Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 64, Name = "AK Series ME Modern Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 65, Name = "AK-Series SF Gen 2 Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 66, Name = "AK-Series SF Lightweight Buttstock", Slot = Attachment.Socket.Stock },

                //FAL
                new Attachment { Id = 67, Name = "FAL Lightweight Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 68, Name = "FAL Polymer Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 69, Name = "FAL Special Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 70, Name = "FAL Stable Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 71, Name = "FAL Triangle Stock", Slot = Attachment.Socket.Stock },

                //T191
                new Attachment { Id = 72, Name = "191 Assault Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 73, Name = "191 Sniper Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 74, Name = "T19X Standard Stock", Slot = Attachment.Socket.Stock },


                // FRONT GRIP
                //AKM / FAL / T191
                new Attachment { Id = 75, Name = "Alloy Tactical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 76, Name = "Alluminum Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 77, Name = "Comfortable Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 78, Name = "KIR Tilt Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 79, Name = "Lightweight Tactical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 80, Name = "Lightweight Long Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 81, Name = "Lightweight Short Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 82, Name = "Lightweight Tilt Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 83, Name = "Lightweight Tactical Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 84, Name = "RK-O Control Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 85, Name = "RK-6 Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 86, Name = "Short Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 87, Name = "B25 Tilt Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 88, Name = "Stable Triangular Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 89, Name = "Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 90, Name = "NO GRIP", Slot = Attachment.Socket.FrontGrip },


                // SMG

                // MUZZLE
                //MPX
                new Attachment { Id = 91, Name = "9mm Muzzle Brake", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 92, Name = "9x19 Conventional Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 93, Name = "9mm Lightweight Muzzle Brake", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 94, Name = "9x19 Lightweight Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 95, Name = "9x19 Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 96, Name = "Dedicated MPX Muzzle Brake", Slot = Attachment.Socket.Muzzle },

                //P90
                new Attachment { Id = 97, Name = "P90 Special Handguard", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 98, Name = "Dedicated P90 Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 99, Name = "P90 Conventional Suppressor", Slot = Attachment.Socket.Muzzle },

                //Banshee
                new Attachment { Id = 100, Name = "P50A Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 101, Name = "Dedicated P90 Flash Suppressor", Slot = Attachment.Socket.Muzzle },
                new Attachment { Id = 102, Name = "P90 Flash Suppressor Adapter + P90 Conventional Suppressor", Slot = Attachment.Socket.Muzzle },


                // FRONT GRIP
                //MPX / Banshee
                new Attachment { Id = 103, Name = "Alloy Tactical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 104, Name = "Alluminum Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 105, Name = "Comfortable Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 106, Name = "KIR Tilt Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 107, Name = "Lightweight Tactical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 108, Name = "Lightweight Long Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 109, Name = "Lightweight Short Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 110, Name = "Lightweight Tilt Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 111, Name = "Lightweight Tactical Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 112, Name = "RK-O Control Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 113, Name = "RK-6 Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 114, Name = "Short Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 115, Name = "B25 Tilt Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 116, Name = "Stable Triangular Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 117, Name = "Vertical Front Grip", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 118, Name = "NO GRIP", Slot = Attachment.Socket.FrontGrip },

                //P90
                new Attachment { Id = 119, Name = "Available", Slot = Attachment.Socket.FrontGrip },
                new Attachment { Id = 120, Name = "NO FRONT GRIP", Slot = Attachment.Socket.FrontGrip },


                // STOCK
                //MPX
                new Attachment { Id = 121, Name = "MPX Standard-Issue Collapsible Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 122, Name = "MPX Collapsible Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 123, Name = "AR Recoil Buffer", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 124, Name = "FA Gen4 Tactical Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 125, Name = "FA Desert Tan Gen 2 Collapsible Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 126, Name = "FA Gen 2 Collapsible Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 127, Name = "M16 Standard Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 128, Name = "M4A1 Simple Recoil Buffer", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 129, Name = "Professional Collapsible Stock", Slot = Attachment.Socket.Stock },

                //P90
                new Attachment { Id = 130, Name = "P90 OEM Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 131, Name = "P90 High-Performance Stock", Slot = Attachment.Socket.Stock },

                //Banshee
                new Attachment { Id = 132, Name = "AR Modernizer Improved Buttstock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 133, Name = "AR Universal Nylon Buttstock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 134, Name = "AR Precision Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 135, Name = "AR Balanced Buttstock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 136, Name = "Banshee Standard Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 137, Name = "Carabine Lightweight Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 138, Name = "Carabine Industrial Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 139, Name = "Collapsible Compatible Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 140, Name = "Compatible Lightweight Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 141, Name = "FA Gen 3 Precision Rifle Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 142, Name = "GL Shock Lightweight Stock", Slot = Attachment.Socket.Stock },
                new Attachment { Id = 143, Name = "M4 Standard Stock", Slot = Attachment.Socket.Stock },


                // BACK GRIP
                //MPX / Banshee
                new Attachment { Id = 144, Name = "AR Comfortable Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 145, Name = "AR Compatible Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 146, Name = "Industrial AR Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 147, Name = "AR Modernized Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 148, Name = "Premium AR Compatible Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 149, Name = "AR Classic Third-Party Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 150, Name = "Lightweight AR Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 151, Name = "Lightweight Skeleton AR Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 152, Name = "Lightweight Tactical AR Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 153, Name = "MPX Standard Polymer Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 154, Name = "Standard Polymer AR Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 155, Name = "Polymer Lightweight AR Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 156, Name = "SCAR Stomped Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 157, Name = "SCAR-L Rear Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 158, Name = "Stable Industrial AR Rear Grip", Slot = Attachment.Socket.BackGrip },

                //Banshee
                new Attachment { Id = 159, Name = "Banshee Standard Grip", Slot = Attachment.Socket.BackGrip },
                new Attachment { Id = 160, Name = "Universal Tactical Rear Grip", Slot = Attachment.Socket.BackGrip }
            );

            modelBuilder.Entity<WeaponAttachment>()
                .HasKey(wa => new { wa.WeaponId, wa.AttachmentId });

            modelBuilder.Entity<WeaponAttachment>().HasData(

            /*
            new WeaponAttachment { WeaponId = 1, AttachmentId = 1 },
            new WeaponAttachment { WeaponId = 1, AttachmentId = 2 } ...
            NIEOPTYMALNE; Lepiej przez lista + LINQ
            */

            // AKM
            (new[] { 1, 2, 3, 4, 5, 8, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
                      44, 45, 46, 47, 48, 49, 50, 51, 52,
                      56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66,
                      75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 }
            .Select(attId => new WeaponAttachment { WeaponId = 1, AttachmentId = attId })).Concat

            // FAL
            (new[] { 9, 10, 11, 12, 13, 14, 15, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
                      53, 54,
                      67, 68, 69, 70, 71,
                      75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 }
            .Select(attId => new WeaponAttachment { WeaponId = 2, AttachmentId = attId })).Concat

            // T191
            (new[] { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
                      55,
                      72, 73, 74,
                      75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 }
            .Select(attId => new WeaponAttachment { WeaponId = 3, AttachmentId = attId })).Concat

            // MPX
            (new[] {
                // Muzzle
                91, 92, 93, 94, 95, 96,

                // Scope
                19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,

                // Front Grip
                103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118,

                // Stock
                121, 122, 123, 124, 125, 126, 127, 128, 129,

                // Back Grip
                144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158
            }
            .Select(attId => new WeaponAttachment { WeaponId = 4, AttachmentId = attId })).Concat

            // P90
            (new[] {
                // Muzzle
                97, 98, 99,

                // Scope
                19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,

                // Front Grip
                119, 120,

                // Stock
                130, 131
            }
            .Select(attId => new WeaponAttachment { WeaponId = 5, AttachmentId = attId })).Concat

            // Banshee
            (new[] {
                // Muzzle
                100, 101, 102,

                // Scope
                19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,

                // Front Grip - wspólne z MPX
                103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118,

                // Stock
                132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143,

                // Back Grip - wspólne z MPX + 2 dodatkowe
                144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158,
                159, 160
            }
            .Select(attId => new WeaponAttachment { WeaponId = 6, AttachmentId = attId }))
            );
        }
    }
}
