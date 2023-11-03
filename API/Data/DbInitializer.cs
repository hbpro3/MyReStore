using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data {
    public static class DbInitializer {
        public static void Initialize (StoreContext context) {
            if (context.Products.Any ()) return;

            var products = new List<Product> {
                new Product {
                Name = "Angular Blue Boots",
                Description = "These elegant blue boots by Angular combine style and comfort. Crafted from premium materials, they are suitable for all seasons.",
                Price = 18000,
                PictureUrl = "/images/products/boot-ang1.png",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
                },
                new Product {
                Name = "Red Sneakers",
                Description = "Make a bold fashion statement with these vibrant red sneakers from SneakerCo. They offer both style and support for active individuals.",
                Price = 25000,
                PictureUrl = "/images/products/sneakers-red.png",
                Brand = "SneakerCo",
                Type = "Sneakers",
                QuantityInStock = 50
                },
                new Product {
                Name = "Leather Wallet",
                Description = "Stay organized and stylish with this leather wallet from FashionBags. It features multiple compartments for your cards and cash.",
                Price = 1500,
                PictureUrl = "/images/products/wallet-leather.png",
                Brand = "FashionBags",
                Type = "Accessories",
                QuantityInStock = 200
                },
                new Product {
                Name = "Smartphone Case",
                Description = "Protect your smartphone in style with this durable case from TechGear. It offers both protection and a sleek design.",
                Price = 500,
                PictureUrl = "/images/products/case-smartphone.png",
                Brand = "TechGear",
                Type = "Accessories",
                QuantityInStock = 80
                },
                new Product {
                Name = "Classic Sunglasses",
                Description = "Complete your look with timeless style using these classic sunglasses from EyeWear. They provide both fashion and sun protection.",
                Price = 1000,
                PictureUrl = "/images/products/sunglasses-classic.png",
                Brand = "EyeWear",
                Type = "Accessories",
                QuantityInStock = 120
                },
                new Product {
                Name = "Men's Dress Shirt",
                Description = "Achieve a sophisticated appearance with this high-quality men's dress shirt by FashionStyles. It's perfect for formal occasions and everyday wear.",
                Price = 2800,
                PictureUrl = "/images/products/shirt-mens.png",
                Brand = "FashionStyles",
                Type = "Apparel",
                QuantityInStock = 60
                },
                new Product {
                Name = "Laptop Bag",
                Description = "Carry your laptop and essentials with style in this versatile laptop bag from TechGear. It offers protection and organization for your devices.",
                Price = 3500,
                PictureUrl = "/images/products/bag-laptop.png",
                Brand = "TechGear",
                Type = "Bags",
                QuantityInStock = 90
                },
                new Product {
                Name = "Fancy Watch",
                Description = "Elevate your wrist with this exquisite fancy watch from TimeWear. It exudes elegance and sophistication, making it a perfect choice for special occasions.",
                Price = 7500,
                PictureUrl = "/images/products/watch-fancy.png",
                Brand = "TimeWear",
                Type = "Watches",
                QuantityInStock = 30
                },
                new Product {
                Name = "Running Shoes",
                Description = "Stay active and comfortable with these high-performance running shoes by SneakerCo. They offer optimal support for your workouts.",
                Price = 21000,
                PictureUrl = "/images/products/shoes-running.png",
                Brand = "SneakerCo",
                Type = "Sports Shoes",
                QuantityInStock = 70
                },
                new Product {
                Name = "Designer Handbag",
                Description = "Elevate your style with this designer handbag from FashionBags. It's a fashion statement that complements your outfits and carries your essentials in style.",
                Price = 4500,
                PictureUrl = "/images/products/handbag-designer.png",
                Brand = "FashionBags",
                Type = "Bags",
                QuantityInStock = 40
                },
                new Product {
                Name = "Casual Slip-On Shoes",
                Description = "Experience comfort and style with these casual slip-on shoes. They're perfect for relaxed outings and are easy to slip into for convenience.",
                Price = 16000,
                PictureUrl = "/images/products/shoes-slip-on.png",
                Brand = "FootEase",
                Type = "Casual Shoes",
                QuantityInStock = 90
                },
                new Product {
                Name = "Designer Sunglasses",
                Description = "Protect your eyes from the sun in style with these designer sunglasses from EyeWear. They combine UV protection and high fashion.",
                Price = 1800,
                PictureUrl = "/images/products/sunglasses-designer.png",
                Brand = "EyeWear",
                Type = "Accessories",
                QuantityInStock = 80
                },
                new Product {
                Name = "Leather Laptop Sleeve",
                Description = "Give your laptop the protection it deserves with this premium leather laptop sleeve from TechGear. It's sleek, stylish, and functional.",
                Price = 1200,
                PictureUrl = "/images/products/laptop-sleeve-leather.png",
                Brand = "TechGear",
                Type = "Accessories",
                QuantityInStock = 60
                },
                new Product {
                Name = "Women's Evening Dress",
                Description = "Make a statement at special events with this stunning evening dress by FashionStyles. It features an elegant design that exudes grace and charm.",
                Price = 3200,
                PictureUrl = "/images/products/dress-womens-evening.png",
                Brand = "FashionStyles",
                Type = "Apparel",
                QuantityInStock = 35
                },
                new Product {
                Name = "Sports Duffel Bag",
                Description = "Carry your gear with ease in this spacious sports duffel bag from SportsPro. It's designed for athletes and fitness enthusiasts on the go.",
                Price = 2700,
                PictureUrl = "/images/products/duffel-bag-sports.png",
                Brand = "SportsPro",
                Type = "Bags",
                QuantityInStock = 55
                },
                new Product {
                Name = "Elegant Diamond Ring",
                Description = "Enhance your elegance with this exquisite diamond ring. It's a symbol of love and luxury that adds a touch of sparkle to any outfit.",
                Price = 10500,
                PictureUrl = "/images/products/ring-diamond-elegant.png",
                Brand = "LuxuryJewels",
                Type = "Jewelry",
                QuantityInStock = 25
                },
                new Product {
                Name = "Professional Chef's Knife",
                Description = "Experience culinary excellence with this professional chef's knife from KitchenMaster. It's razor-sharp and designed for precision in the kitchen.",
                Price = 3600,
                PictureUrl = "/images/products/knife-chefs-professional.png",
                Brand = "KitchenMaster",
                Type = "Kitchen Tools",
                QuantityInStock = 40
                }
            };

            context.AddRange (products);
            context.SaveChanges ();
        }
    }
}