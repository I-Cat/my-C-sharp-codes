using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo();
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);

        //    PhotoProcessor.photoFilterHander filterHandler = filters.ApplyBrightness;


            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

                processor.Process("photo.jpg", filterHandler);
            //}
        }
            static void RemoveRedEyeFilter(Photo photo)
            {
                Console.WriteLine("Apply RemoveRedEye");
            }
        }
    }

