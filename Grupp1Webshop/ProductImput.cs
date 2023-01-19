using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class ProductImput
    {

        public static List<Models.Product> Products { get; set; }


        //public static List<Models.Product> GetAllproducts()
        //{
        //    Random rnd = new Random();

        //    Products = new List<Models.Product>
        //    {
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category= "Dresses",
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dress with wrinkle",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "XS",
        //                Color =  "Dark beige",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "S",
        //                Color =  "Dark beige",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "M",
        //                Color =  "Dark beige",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "L",
        //                Color =  "Dark beige",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "XL",
        //                Color =  "Dark beige",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "XS",
        //                Color =  "White",
        //                Price = 399.00,
        //                Category = "Dres",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "S",
        //                Color =  "White",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "M",
        //                Color =  "White",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "L",
        //                Color =  "White",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbed dress",
        //                Size = "XL",
        //                Color =  "White",
        //                Price = 399.00,
        //                Category = "Dresses",
        //                Description = "A short, figure-close dress in soft, ribbed quality with a shapely knit part at the top. The dress has a wide neckline and long, wide sleeve. Straight bottom.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "XS",
        //                Color = "Black/Striped",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "S",
        //                Color = "Black/Striped",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "M",
        //                Color = "Black/Striped",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "L",
        //                Color = "Black/Striped",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "XL",
        //                Color = "Black/Striped",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "XS",
        //                Color = "Black/Floral",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "S",
        //                Color = "Black/Floral",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "M",
        //                Color = "Black/Floral",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "L",
        //                Color = "Black/Floral",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "XL",
        //                Color = "Black/Floral",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "XS",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "S",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "M",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "L",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Wrap dress with balloon sleeve",
        //                Size = "XL",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Dresses",
        //                Description = "A calf-length dress in soft leotard. The dress is V-necked and has wrap in the front with wide tie ties in one side and narrow, hidden ties in the other side. Slightly downsized shoulder and long balloon sleeve with narrow elastic at the cuff. Unlined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Size = "XS",
        //                Color = "Green",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Size = "S",
        //                Color = "Green",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Size = "M",
        //                Color = "Green",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Size = "L",
        //                Color = "Green",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Size = "XL",
        //                Color = "Green",
        //                Price = 299.00,
        //                Category = "Dresses",
        //                Description = "A knee-length shirt dress in woven quality. It has a collar, buttoning in the front and uncut with counter-folds at the rear. Long, voluminous sleeve with a wide cuff that has a slit and button. Open breast pocket. Rounded bottom edge. Slightly longer back cover.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Size = "XS",
        //                Color = "Silver",
        //                Price = 599.00,
        //                Category = "Dresses",
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Size = "S",
        //                Color = "Silver",
        //                Price = 599.00,
        //                Category = "Dresses",
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Size = "M",
        //                Color = "Silver",
        //                Price = 599.00,
        //                Category = "Dresses",
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Size = "L",
        //                Color = "Silver",
        //                Price = 599.00,
        //                Category = "Dresses",
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sequin-embroidered wrap dress",
        //                Size = "XL",
        //                Color = "Silver",
        //                Price = 599.00,
        //                Category = "Dresses",
        //                Description = "A short dress in glittery, sequin-embroidered mesh. The dress has shoulder pads and a long sleeve. Cut off with elastic at the waist and wrapped in the front with a hidden button. Hush and catch in one side. Lined.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Size = "32",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Size = "34",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Size = "36",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls"
        //                Size = "38",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Size = "40",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Size = "42",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Size = "44",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Net dress with pearls",
        //                Size = "46",
        //                Color = "Silver",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description = "Calf-length mesh dress in a figure-close fit with pearl details and fringed hem. Deep rounded neckline at the back Length of the dress.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "XS",
        //                Color = "Red",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "S",
        //                Color = "Red",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "M",
        //                Color = "Red",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "L",
        //                Color = "Red",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Short off shoulder dress with ruffles",
        //                Size = "XL",
        //                Color = "Red",
        //                Price = 1300.00,
        //                Category = "Dresses",
        //                Description ="Short off shoulder dress with large ruffles, figure-close fit and small slit in the side. Corset with support rails at the topHidden zipper in the side.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 249.00,
        //                Category = "Bottoms",
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 249.00,
        //                Category = "Bottoms",
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 249.00,
        //                Category = "Bottoms",
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 249.00,
        //                Category = "Bottoms",
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Flared leggings",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 249.00,
        //                Category = "Bottoms",
        //                Description ="A pair of leggings with slender legs. The leggings have a high waist with V-cutting and flared leg ends with sprund.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Bottoms",
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Bottoms",
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Bottoms",
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Bottoms",
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Bottoms",
        //                Description = "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Running Tights Seamless",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "32",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "34",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "36",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "38",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "40",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "42",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "44",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "46",
        //                Color = "Black",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "32",
        //                Color ="Beige",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "34",
        //                Color ="Beige",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "36",
        //                Color ="Beige",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "38",
        //                Color ="Beige",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "40",
        //                Color ="Beige",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "42",
        //                Color ="Beige",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "44",
        //                Color ="Beige",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "46",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "32",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "34",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "36",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "38",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "40",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "42",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "44",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Dressed pants",
        //                Size = "46",
        //                Color ="Blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of ankle-length, dressy trousers in woven quality. The pants have gylf with zipper and buttoning with hush and hook. Oblique front pockets and decorative post pockets at the rear. Straight legs with folds front and back and folded folds at the top. Little slit at the end of the legs.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "32",
        //                Color = "Denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "34",
        //                Color = "Denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "36",
        //                Color = "Denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "38",
        //                Color = "Denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "40",
        //                Color = "Denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "42",
        //                Color = "Denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "44",
        //                Color = "Denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "32",
        //                Color = "Light denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "34",
        //                Color = "Light denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "36",
        //                Color = "Light denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "38",
        //                Color = "Light denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "40",
        //                Color = "Light denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "42",
        //                Color = "Light denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = "44",
        //                Color = "Light denim blue",
        //                Price = 399.00,
        //                Category = "Bottoms",
        //                Description = "A pair of 5-pocket jeans in sturdy cotton denim. The jeans have a high waist and straight legs with a slit at the end of the legs. Gylf with zipper and button.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = "32",
        //                Color = "Light denim blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = "34",
        //                Color = "Light denim blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = "36",
        //                Color = "Light denim blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = "38",
        //                Color = "Light denim blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = "40",
        //                Color = "Light denim blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = "42",
        //                Color = "Light denim blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = "44",
        //                Color = "Light denim blue",
        //                Price = 299.00,
        //                Category = "Bottoms",
        //                Description = "A pair of full-length 5-pocket jeans in washed cotton denim with hard-worn details. The jeans have a high waist and straight legs that provide the perfect 90s vibe. Buttongylf.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "32",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "34",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "36",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "38",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "40",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "42",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "44",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = "46",
        //                Color = "White",
        //                Price = 890.00,
        //                Category = "Tops",
        //                Description = "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "XS",
        //                Color = "Cream",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "S",
        //                Color = "Cream",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "M",
        //                Color = "Cream",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "L",
        //                Color = "Cream",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "XS",
        //                Color = "Black/Striped",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "S",
        //                Color = "Black/Striped",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "M",
        //                Color = "Black/Striped",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = "L",
        //                Color = "Black/Striped",
        //                Price = 345.00,
        //                Category = "Tops",
        //                Description = "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "XS",
        //                Color = "Beige",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "S",
        //                Color = "Beige",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "M",
        //                Color = "Beige",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "L",
        //                Color = "Beige",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "XL",
        //                Color = "Beige",
        //                Price = 199.00,
        //                Category = "Shirts",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "M",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "L",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Rib-knit top",
        //                Size = "XL",
        //                Color = "White",
        //                Price = 199.00,
        //                Category = "Tops",
        //                Description = "Fitted, rib-knit top with a square neckline and short sleeves.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "XS",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "S",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "M",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "L",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "XL",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "XS",
        //                Color = "Grey",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "XS",
        //                Color = "Grey",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "S",
        //                Color = "Grey",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "M",
        //                Color = "Grey",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "L",
        //                Color = "Grey",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Printed T-shirt",
        //                Size = "XL",
        //                Color = "Grey",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "Fitted T-shirt in soft cotton jersey with a print motif on the front.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Size = "S",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Size = "M",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Sweater in leotard",
        //                Size = "L",
        //                Color = "White",
        //                Price = 99.00,
        //                Category = "Tops",
        //                Description = "A figure-close sweater in soft leotard. The sweater has a long sleeve and deep neckline.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "35",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "36",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "37",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity=rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "38",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "39",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "40",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "41",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "42",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "43",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Boots",
        //                Size = "44",
        //                Color = "Black/Varnish",
        //                Price = 299.00,
        //                Category = "Shoes",
        //                Description = "Chunky-soled boots in imitation leather with an ankle-height shaft, lacing at the front and a loop at the back. Imitation leather insoles. Heel 3 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "35",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "36",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "37",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "39",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "40",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "41",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "42",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "43",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Paired Ph Warm - Sneaker High",
        //                Size = "44",
        //                Color = "Black",
        //                Price = 1249.00,
        //                Category = "Shoes",
        //                Description = "Sporty sneakers like the Paired PH Warm Sneaker High will give your vegan winter look a cool finish. The stylish nubuck look in black can be combined with almost anything. In addition, thanks to the soft fur lining, these sneakers become very comfortable to wear. The padded shaft and removable Memory Foam insole provide a smooth ride. This makes these sneakers look ultra-light and makes any outfit trendy. ",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "35",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "36",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "37",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "38",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "39",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "40",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "41",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "42",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "43",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Knee-high boots",
        //                Size = "44",
        //                Color = "Black",
        //                Price = 699.00,
        //                Category = "Shoes",
        //                Description = "A pair of boots with a knee-high shaft that has a decorative strap with D-rings at the top. Feed in satin. Heel height 3.5 cm.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "35",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "36",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "37",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "38",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "39",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "40",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "41",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "42",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "43",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "44",
        //                Color = "Beige",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "35",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "36",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "37",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "38",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "39",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "40",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "41",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Leather Chelsea boots",
        //                Size = "42",
        //                Color = "Black",
        //                Price = 899.00,
        //                Category = "Shoes",
        //                Description = "Chelsea boots in leather with elastic gores in the sides and a loop front and back. Cotton canvas linings and insoles and chunky soles that are patterned underneath.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Size = "32",
        //                Color = "Black/Checked",
        //                Price = 399.00,
        //                Category = "Skirts",
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Size = "34",
        //                Color = "Black/Checked",
        //                Price = 399.00,
        //                Category = "Skirts",
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Size = "36",
        //                Color = "Black/Checked",
        //                Price = 399.00,
        //                Category = "Skirts",
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Size = "38",
        //                Color = "Black/Checked",
        //                Price = 399.00,
        //                Category = "Skirts",
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Size = "40",
        //                Color = "Black/Checked",
        //                Price = 399.00,
        //                Category = "Skirts",
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Size = "42",
        //                Color = "Black/Checked",
        //                Price = 399.00,
        //                Category = "Skirts",
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Skirt in bouclé",
        //                Size = "44",
        //                Color = "Black/Checked",
        //                Price = 399.00,
        //                Category = "Skirts",
        //                Description = "A short, figure-close skirt in textured bouclé yarn with hints of cotton. The skirt has French accents, slanted side pockets, hidden zipper in one side and slits at the bottom at the front. Lined.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Size = "XS",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Jackets",
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Size = "S",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Jackets",
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Size = "M",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Jackets",
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Size = "L",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Jackets",
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity =rnd.Next(5, 50)
        //            },
        //            new Product()
        //            {
        //                Name = "Puffer jacket",
        //                Size = "XL",
        //                Color = "Black",
        //                Price = 399.00,
        //                Category = "Jackets",
        //                Description = "En quiltad pufferjacka i vävd kvalitet. Jackan har avslappnad passform med ståkrage, dragkedja fram och stolpfickor. Klädd resår vid ärmslut samt resår och dragsko med snörstopp i nederkant. Fodrad.",
        //                Quantity = rnd.Next(5, 50)
        //            }


        //    };
        //    return Products;
        //}

        //private int GenerateQuantity()
        //{
        //    int quantity = 0;
        //    Random rnd = new();
        //    quantity = rnd.Next(5, 50);
        //    return quantity;
        //}
    }
}

    


