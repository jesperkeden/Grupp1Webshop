using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class NewProductImput
    {
        //public static List<Product> Products { get; set; }
        //public static List<Product> GetAllProducts()
        //{
        //    Random rnd = new();
        //    if (Products == null || !Products.Any())
        //    {
        //         Products = new List<Product>()
        //         {
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 299,
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.";
        //              //Quantity = rnd.Next(5,50),
        //              //Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 299,
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.";
        //              //Quantity = rnd.Next(5,50),
        //              //Category = 2
        //            }
        //            new Product()
        //   {
        //                Name = "Dress with wrinkle",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 299,                       
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 299,                       
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //                
        //            },
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 299,                       
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0

        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Dark beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Dark beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Dark beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Dark beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "Dark beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 399,
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0            
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0   
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Floral"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Floral"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Floral"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Floral"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "Black/Floral"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 199,
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category = 0 
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Color = new List<string>()
        //                {
        //                   "Green"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 199,
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Color = new List<string>()
        //                {
        //                   "Green"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 199,
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Color = new List<string>()
        //                {
        //                   "Green"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 199,
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Color = new List<string>()
        //                {
        //                   "Green"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 199,
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 599,
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 599,
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 599,
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 599,
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 599,
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "32"
        //                },
        //                UnitPrice = 1300.00,
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 1300.00,
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 1300.00,
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 1300.00,
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 1300.00,
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 1300.00,
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Color = new List<string>()
        //                {
        //                   "Silver"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 1300.00,
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0  
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Red"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Red"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Red"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Red"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Color = new List<string>()
        //                {
        //                   "Red"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 1300.00,
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=0 
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 249.00,
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 249.00,
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 249.00,
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 249.00,
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 249.00,
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 249.00,
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 249.00,
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 249.00,
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 249.00,
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 249.00,
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Color = new List<string>()
        //                {
        //                   "Blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },

        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "32"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "32"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Color = new List<string>()
        //                {
        //                   "Light Denim blue"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=5
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "32"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "46"
        //                },
        //                UnitPrice = 890.00,
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Cream"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Cream"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Cream"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Cream"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Color = new List<string>()
        //                {
        //                   "Black/Striped"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 345.00,
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 199.00,
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "Grey"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "Grey"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "Grey"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "Grey"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Color = new List<string>()
        //                {
        //                   "Grey"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Color = new List<string>()
        //                {
        //                   "White"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 99.00,
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=2
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "35"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "37"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },

        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "39"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "41"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "43"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 299.00,
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "35"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "37"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "39"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "41"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "43"
        //                },
        //                UnitPrice = 1249.00,
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "35"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "37"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "39"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "41"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "43"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 699.00,
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "35"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "37"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {

        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "39"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "41"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Beige"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "43"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "35"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "37"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "39"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "41"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "43"
        //                },
        //                UnitPrice = 899.00,
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=1
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "34"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=3
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "36"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=3
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "38"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=3
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "40"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=3
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "42"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=3
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "44"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=3
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XS"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=4
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "S"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=4
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "M"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=4
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "L"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=4
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Color = new List<string>()
        //                {
        //                   "Black"
        //                },
        //                Size = new List<string>()
        //                {
        //                   "XL"
        //                },
        //                UnitPrice = 399.00,
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50),
        //                Category=4
        //            }

        //        };
        //    }
        //        //return Products;
        // }
    }
}
